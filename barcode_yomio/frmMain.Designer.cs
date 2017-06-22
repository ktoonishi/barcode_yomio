namespace barcode_yomio
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stb = new System.Windows.Forms.StatusStrip();
            this.pic = new System.Windows.Forms.PictureBox();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMode = new System.Windows.Forms.Label();
            this.stb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // stb
            // 
            this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblResult,
            this.lblType});
            this.stb.Location = new System.Drawing.Point(0, 209);
            this.stb.Name = "stb";
            this.stb.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stb.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stb.Size = new System.Drawing.Size(294, 27);
            this.stb.SizingGrip = false;
            this.stb.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(294, 209);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // tim
            // 
            this.tim.Interval = 30;
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = false;
            this.lblResult.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblResult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(180, 22);
            this.lblResult.Text = "読み取り結果";
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.SystemColors.Control;
            this.btnCamera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamera.Location = new System.Drawing.Point(129, 1);
            this.btnCamera.Margin = new System.Windows.Forms.Padding(0);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(81, 31);
            this.btnCamera.TabIndex = 1;
            this.btnCamera.Text = "カメラ";
            this.btnCamera.UseVisualStyleBackColor = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(211, 1);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(81, 31);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "設定";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = false;
            this.lblType.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 22);
            this.lblType.Text = "動作モード";
            // 
            // lblMode
            // 
            this.lblMode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMode.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMode.Location = new System.Drawing.Point(1, 1);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(127, 31);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "動作モード";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(294, 236);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.stb);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "バーコード読み郎";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stb.ResumeLayout(false);
            this.stb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stb;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.ToolStripStatusLabel lblResult;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.ToolStripStatusLabel lblType;
        private System.Windows.Forms.Label lblMode;
    }
}

