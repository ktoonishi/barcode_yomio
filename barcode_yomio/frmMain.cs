using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using OpenCvSharp;
using OpenCvSharp.Extensions;
using barcode_yomio.Properties;

using System.Threading;
using System.IO;
using System.Media;

using ZXing;

namespace barcode_yomio
{
    public partial class frmMain : Form
    {

        // ----------------------------------------------------------------------------------------
        // 定数宣言
        // ----------------------------------------------------------------------------------------
        private const int F_WIDTH = 640;
        private const int F_HEIGHT = 480;


        // ----------------------------------------------------------------------------------------
        // グローバル変数
        // ----------------------------------------------------------------------------------------
        private VideoCapture cap;
        private Mat Frame;          // 画像オリジナル
        private Mat Frame_gray;     // グレースケール
        private Mat Frame_tag;      // 処理対象

        private ZXing.BarcodeReader br = new ZXing.BarcodeReader();
        private SoundPlayer Sp;

        private bool cap_flag = false;

        public frmMain()
        {
            InitializeComponent();
        }


        // ----------------------------------------------------------------------------------------
        // フォームロード
        // ----------------------------------------------------------------------------------------
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Frame = new Mat(F_HEIGHT, F_WIDTH, MatType.CV_8UC3);
                Frame_gray = new Mat(F_HEIGHT, F_WIDTH, MatType.CV_8UC1);
                Frame_tag = new Mat(F_HEIGHT, F_WIDTH, MatType.CV_8UC1);
                
                // 音声ファイル
                // ファイル存在の検証 1974.wav固定
                if (File.Exists(Application.StartupPath + @"\1974.wav"))
                    Sp = new SoundPlayer(Application.StartupPath + @"\1974.wav");


                // カメラオープン
                cap = new VideoCapture(Settings.Default.cam_no);
                cap.FrameWidth = F_WIDTH;
                cap.FrameHeight = F_HEIGHT;
                if (!cap.IsOpened())
                    throw new ApplicationException("カメラが見つかりませんでした\n設定[カメラNo]を確認してください");



                // キャプチャースタート
                cap_flag = true;
                tim.Start();


            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "カメラオープンエラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // ----------------------------------------------------------------------------------------
        // フォームクローズ
        // ----------------------------------------------------------------------------------------
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tim.Stop();
            cap_flag = false;
            if (cap != null) cap.Dispose();
            if (fs != null) fs.Dispose();
            Frame.Dispose(); Frame_gray.Dispose(); Frame_tag.Dispose();
        }



        // ----------------------------------------------------------------------------------------
        // 画像処理タイマー
        // ----------------------------------------------------------------------------------------
        private void tim_Tick(object sender, EventArgs e)
        {
            if (cap_flag && cap.IsOpened())
            {
                if (cap.Read(Frame))
                {
                    cap_flag = false;
                    // プレビュー更新
                    pic.Image = BitmapConverter.ToBitmap(Frame_gray);
                    // ガーベジコレクション
                    if (GC.GetTotalMemory(false) > 1000000){
                        GC.Collect();
                    }

                    // グレースケール（１要素抽出）
                    Frame_gray = Frame.Split()[Settings.Default.cam_color];
                    Cv2.ConvertScaleAbs(Frame_gray, Frame_gray, Settings.Default.cam_contrust);
                    Cv2.MedianBlur(Frame_gray, Frame_gray, 3);

                    // 二値化
                    Cv2.Threshold(Frame_gray, Frame_tag, 100d, 255d, ThresholdTypes.Otsu);
                    //Cv2.ImShow("thresho1", Frame_tag);

                    // バーコード読み取り
                    ZXing.Result res = br.Decode(BitmapConverter.ToBitmap(Frame_tag));
                    if (res != null)
                    {
                        // 結果の確認
                        if (res.Text.Length > 0)
                        {
                            // 共通処理
                            lblResult.Text = res.Text;                      // 読み取り結果
                            lblType.Text = res.BarcodeFormat.ToString();    // バーコードフォーマット
                           
                            // 確認モード(0)
                            if (Settings.Default.mode == 0)
                            {
                                lblMode.Text = "確認モード";
                            }
                            // バーコードモード(1)
                            else if (Settings.Default.mode == 1)
                            {
                                lblMode.Text = "バーコードリーダー";
                                for (int i = 0; i < res.Text.Length; i++)
                                    SendKeys.Send("" + res.Text.Substring(i, 1) + "");
                                if (Settings.Default.mode_enter)
                                    SendKeys.Send("{ENTER}");
                            }
                            // ?モード（ハンドル指定のつもり）
                            else if (Settings.Default.mode == 2)
                            {
                                lblMode.Text = "?モード";
                            }

                            // 音声の再生
                            if (Settings.Default.mode_sound)
                            {
                                // ファイル存在の検証 1974.wav固定
                                if (File.Exists(Application.StartupPath + @"\1974.wav") && Sp != null){
                                    Sp.Play();
                                }
                            }
                            // 一定時間待機（二度読み防止）
                            Thread.Sleep(Settings.Default.mode_wait);
                            cap.Read(Frame);
                        }
                    }
                    

                    cap_flag = true;
                }
            }
        }



        #region フォームコントロール
        // ----------------------------------------------------------------------------------------
        // カメラボタンクリック
        // ----------------------------------------------------------------------------------------
        private void btnCamera_Click(object sender, EventArgs e)
        {
            btnCamera.Enabled = false;
            if (!cap.IsOpened())
            {
                try
                {
                    // カメラオープン
                    cap = new VideoCapture(Settings.Default.cam_no);
                    cap.FrameWidth = F_WIDTH;
                    cap.FrameHeight = F_HEIGHT;
                    if (!cap.IsOpened())
                        throw new ApplicationException("カメラが見つかりませんでした\n設定[カメラNo]を確認してください");
                    // キャプチャースタート
                    cap_flag = true;
                    tim.Start();
                }
                catch (ApplicationException ex)
                {
                    btnCamera.Enabled = true;
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                tim.Stop();
                cap_flag = false;
                cap.Release();
                pic.Image = null;
            }
            btnCamera.Enabled = true;
        }

        frmSetting fs;
        // ----------------------------------------------------------------------------------------
        // 設定ボタンクリック
        // ----------------------------------------------------------------------------------------
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (fs == null || fs.IsDisposed)
            {
                fs = new frmSetting();
                fs.Left = 0; fs.Top = 0;
                fs.Show();
            }
            else
            {
                fs.Activate();
            }
        }

        #endregion


        //private string ConvertSKFormat(string s)
        //{




        //}

    }
}
