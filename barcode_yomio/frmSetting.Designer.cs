namespace barcode_yomio
{
    partial class frmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCamColor = new System.Windows.Forms.ComboBox();
            this.txtCamContrust = new System.Windows.Forms.NumericUpDown();
            this.txtCamNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbMode3 = new System.Windows.Forms.RadioButton();
            this.rdbMode2 = new System.Windows.Forms.RadioButton();
            this.rdbMode1 = new System.Windows.Forms.RadioButton();
            this.chkEnter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.txtWait = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCamContrust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCamNo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWait)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCamColor);
            this.groupBox1.Controls.Add(this.txtCamContrust);
            this.groupBox1.Controls.Add(this.txtCamNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "カメラ";
            // 
            // cmbCamColor
            // 
            this.cmbCamColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamColor.FormattingEnabled = true;
            this.cmbCamColor.Items.AddRange(new object[] {
            "青",
            "緑",
            "赤"});
            this.cmbCamColor.Location = new System.Drawing.Point(68, 46);
            this.cmbCamColor.Name = "cmbCamColor";
            this.cmbCamColor.Size = new System.Drawing.Size(68, 23);
            this.cmbCamColor.TabIndex = 2;
            this.cmbCamColor.SelectedIndexChanged += new System.EventHandler(this.cmbCamColor_SelectedIndexChanged);
            // 
            // txtCamContrust
            // 
            this.txtCamContrust.DecimalPlaces = 1;
            this.txtCamContrust.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtCamContrust.Location = new System.Drawing.Point(68, 75);
            this.txtCamContrust.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            65536});
            this.txtCamContrust.Name = "txtCamContrust";
            this.txtCamContrust.Size = new System.Drawing.Size(68, 23);
            this.txtCamContrust.TabIndex = 1;
            this.txtCamContrust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCamContrust.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.txtCamContrust.ValueChanged += new System.EventHandler(this.txtCamContrust_ValueChanged);
            // 
            // txtCamNo
            // 
            this.txtCamNo.Location = new System.Drawing.Point(68, 17);
            this.txtCamNo.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtCamNo.Name = "txtCamNo";
            this.txtCamNo.Size = new System.Drawing.Size(68, 23);
            this.txtCamNo.TabIndex = 1;
            this.txtCamNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCamNo.ValueChanged += new System.EventHandler(this.txtCamNo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "明るさ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "使う色";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "カメラ番号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rdbMode3);
            this.groupBox2.Controls.Add(this.rdbMode2);
            this.groupBox2.Controls.Add(this.rdbMode1);
            this.groupBox2.Location = new System.Drawing.Point(184, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "モード";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(23, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "バーコードを読み取りキー入力に変換します";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(23, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "バーコードを読みますが、データ入力はされません";
            // 
            // rdbMode3
            // 
            this.rdbMode3.AutoSize = true;
            this.rdbMode3.Enabled = false;
            this.rdbMode3.Location = new System.Drawing.Point(225, 14);
            this.rdbMode3.Name = "rdbMode3";
            this.rdbMode3.Size = new System.Drawing.Size(64, 19);
            this.rdbMode3.TabIndex = 0;
            this.rdbMode3.TabStop = true;
            this.rdbMode3.Text = "？モード";
            this.rdbMode3.UseVisualStyleBackColor = true;
            this.rdbMode3.Visible = false;
            // 
            // rdbMode2
            // 
            this.rdbMode2.AutoSize = true;
            this.rdbMode2.Location = new System.Drawing.Point(6, 73);
            this.rdbMode2.Name = "rdbMode2";
            this.rdbMode2.Size = new System.Drawing.Size(96, 19);
            this.rdbMode2.TabIndex = 0;
            this.rdbMode2.TabStop = true;
            this.rdbMode2.Text = "キー入力モード";
            this.rdbMode2.UseVisualStyleBackColor = true;
            this.rdbMode2.CheckedChanged += new System.EventHandler(this.rdbMode2_CheckedChanged);
            // 
            // rdbMode1
            // 
            this.rdbMode1.AutoSize = true;
            this.rdbMode1.Location = new System.Drawing.Point(6, 20);
            this.rdbMode1.Name = "rdbMode1";
            this.rdbMode1.Size = new System.Drawing.Size(76, 19);
            this.rdbMode1.TabIndex = 0;
            this.rdbMode1.TabStop = true;
            this.rdbMode1.Text = "確認モード";
            this.rdbMode1.UseVisualStyleBackColor = true;
            this.rdbMode1.CheckedChanged += new System.EventHandler(this.rdbMode1_CheckedChanged);
            // 
            // chkEnter
            // 
            this.chkEnter.AutoSize = true;
            this.chkEnter.Location = new System.Drawing.Point(6, 22);
            this.chkEnter.Name = "chkEnter";
            this.chkEnter.Size = new System.Drawing.Size(222, 19);
            this.chkEnter.TabIndex = 1;
            this.chkEnter.Text = "文字読み取り後にエンターキーを付加する";
            this.chkEnter.UseVisualStyleBackColor = true;
            this.chkEnter.CheckedChanged += new System.EventHandler(this.chkEnter_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "処理速度";
            // 
            // txtTim
            // 
            this.txtTim.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtTim.Location = new System.Drawing.Point(305, 21);
            this.txtTim.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtTim.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(52, 23);
            this.txtTim.TabIndex = 3;
            this.txtTim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTim.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtTim.ValueChanged += new System.EventHandler(this.txtTim_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSound);
            this.groupBox3.Controls.Add(this.txtWait);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.chkEnter);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 78);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "バーコード読み取り";
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(6, 47);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(165, 19);
            this.chkSound.TabIndex = 6;
            this.chkSound.Text = "読み取り時に効果音を鳴らす";
            this.chkSound.UseVisualStyleBackColor = true;
            this.chkSound.CheckedChanged += new System.EventHandler(this.chkSound_CheckedChanged);
            // 
            // txtWait
            // 
            this.txtWait.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWait.Location = new System.Drawing.Point(336, 50);
            this.txtWait.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtWait.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(65, 23);
            this.txtWait.TabIndex = 5;
            this.txtWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWait.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWait.ValueChanged += new System.EventHandler(this.txtWait_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "読み取り後の待ち";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "変更は即反映されます";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 45);
            this.panel1.TabIndex = 7;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(491, 269);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetting_FormClosing);
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCamContrust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCamNo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWait)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCamColor;
        private System.Windows.Forms.NumericUpDown txtCamContrust;
        private System.Windows.Forms.NumericUpDown txtCamNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbMode3;
        private System.Windows.Forms.RadioButton rdbMode2;
        private System.Windows.Forms.RadioButton rdbMode1;
        private System.Windows.Forms.CheckBox chkEnter;
        private System.Windows.Forms.NumericUpDown txtTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtWait;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}