namespace BaiThucTap
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtten = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btdangnhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Checkbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtten
            // 
            this.txtten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtten.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtten.HintForeColor = System.Drawing.Color.Empty;
            this.txtten.HintText = "";
            this.txtten.isPassword = false;
            this.txtten.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtten.LineIdleColor = System.Drawing.Color.Red;
            this.txtten.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtten.LineThickness = 3;
            this.txtten.Location = new System.Drawing.Point(102, 46);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(220, 33);
            this.txtten.TabIndex = 3;
            this.txtten.Text = "Nhập tên đăng nhập vào";
            this.txtten.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.btdangnhap);
            this.groupBox1.Controls.Add(this.Checkbox1);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(0, 0);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(42, 20);
            this.txtMaNV.TabIndex = 31;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.Color.White;
            this.txtmatkhau.Location = new System.Drawing.Point(102, 91);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(220, 29);
            this.txtmatkhau.TabIndex = 29;
            this.txtmatkhau.Text = "Nhập mật khẩu ";
            // 
            // btthoat
            // 
            this.btthoat.ActiveBorderThickness = 1;
            this.btthoat.ActiveCornerRadius = 20;
            this.btthoat.ActiveFillColor = System.Drawing.Color.Blue;
            this.btthoat.ActiveForecolor = System.Drawing.Color.White;
            this.btthoat.ActiveLineColor = System.Drawing.Color.Blue;
            this.btthoat.BackColor = System.Drawing.Color.White;
            this.btthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthoat.BackgroundImage")));
            this.btthoat.ButtonText = "Exit";
            this.btthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.Color.Red;
            this.btthoat.IdleBorderThickness = 1;
            this.btthoat.IdleCornerRadius = 20;
            this.btthoat.IdleFillColor = System.Drawing.Color.White;
            this.btthoat.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btthoat.IdleLineColor = System.Drawing.Color.Blue;
            this.btthoat.Location = new System.Drawing.Point(208, 163);
            this.btthoat.Margin = new System.Windows.Forms.Padding(5);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(76, 37);
            this.btthoat.TabIndex = 28;
            this.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.ActiveBorderThickness = 1;
            this.btdangnhap.ActiveCornerRadius = 20;
            this.btdangnhap.ActiveFillColor = System.Drawing.Color.Blue;
            this.btdangnhap.ActiveForecolor = System.Drawing.Color.White;
            this.btdangnhap.ActiveLineColor = System.Drawing.Color.Blue;
            this.btdangnhap.BackColor = System.Drawing.Color.White;
            this.btdangnhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdangnhap.BackgroundImage")));
            this.btdangnhap.ButtonText = "Login";
            this.btdangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdangnhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangnhap.ForeColor = System.Drawing.Color.Red;
            this.btdangnhap.IdleBorderThickness = 1;
            this.btdangnhap.IdleCornerRadius = 20;
            this.btdangnhap.IdleFillColor = System.Drawing.Color.White;
            this.btdangnhap.IdleForecolor = System.Drawing.Color.Blue;
            this.btdangnhap.IdleLineColor = System.Drawing.Color.Blue;
            this.btdangnhap.Location = new System.Drawing.Point(102, 163);
            this.btdangnhap.Margin = new System.Windows.Forms.Padding(5);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(76, 37);
            this.btdangnhap.TabIndex = 27;
            this.btdangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // Checkbox1
            // 
            this.Checkbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.Checked = false;
            this.Checkbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox1.ForeColor = System.Drawing.Color.White;
            this.Checkbox1.Location = new System.Drawing.Point(102, 128);
            this.Checkbox1.Name = "Checkbox1";
            this.Checkbox1.Size = new System.Drawing.Size(20, 20);
            this.Checkbox1.TabIndex = 26;
            this.Checkbox1.OnChange += new System.EventHandler(this.Checkbox1_OnChange);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(116, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 24);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "ĐĂNG NHẬP";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(128, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 15);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Show password !!!";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(14, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 29);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "PassWord :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(14, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 33);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "UserName :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 247);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmatkhau;
        private Bunifu.Framework.UI.BunifuThinButton2 btthoat;
        private Bunifu.Framework.UI.BunifuThinButton2 btdangnhap;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox1;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}