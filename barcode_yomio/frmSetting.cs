using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using barcode_yomio.Properties;

namespace barcode_yomio
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            // 設定を読み込む
            // カメラ -----------------------------------------------------------------------------
            txtCamNo.Value = (decimal)Settings.Default.cam_no;
            cmbCamColor.SelectedIndex = Settings.Default.cam_color;
            txtCamContrust.Value = (decimal)Settings.Default.cam_contrust;

            // モード -------------------------------------------------------------------------
            if (Settings.Default.mode == 0) rdbMode1.Checked = true;
            else if (Settings.Default.mode == 1) rdbMode2.Checked = true;
            else if (Settings.Default.mode == 2) rdbMode3.Checked = true;

            // バーコード読み取り
            chkEnter.Checked = Settings.Default.mode_enter;
            txtTim.Value = Settings.Default.tim_int;
            txtWait.Value = Settings.Default.mode_wait;
            chkSound.Checked = Settings.Default.mode_sound;

        }


        #region コントロール変更イベント
        // カメラ ---------------------------------------------------------------------------------
        // カメラ番号
        private void txtCamNo_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.cam_no = (int)txtCamNo.Value;
            Settings.Default.Save();
        }
        // カメラの色
        private void cmbCamColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.cam_color = cmbCamColor.SelectedIndex;
            Settings.Default.Save();
        }
        // 明るさ
        private void txtCamContrust_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.cam_contrust = (double)txtCamContrust.Value;
            Settings.Default.Save();
        }
        // 文字読み取り後にエンターキーを付加する
        private void chkEnter_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.mode_enter = chkEnter.Checked;
            Settings.Default.Save();
        }
        // 処理速度
        private void txtTim_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.tim_int = (int)txtTim.Value;
        }
        // 読み取り後の待ち
        private void txtWait_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.mode_wait = (int)txtWait.Value;
            Settings.Default.Save();
        }
        // 読み取り時に効果音を鳴らす
        private void chkSound_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.mode_sound = chkSound.Checked;
            Settings.Default.Save();
        }

        private void rdbMode1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.mode = 0;
            Settings.Default.Save();
        }
        private void rdbMode2_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.mode = 1;
            Settings.Default.Save();
        }
        // 動作モード ---------------------------------------------------------------------------


        #endregion

        

       

    }
}
