namespace BaiThucTap
{
    partial class GuiGmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiGmail));
            this.label1 = new System.Windows.Forms.Label();
            this.btdinhkem = new DevExpress.XtraEditors.SimpleButton();
            this.btGuiNhieuMail = new DevExpress.XtraEditors.SimpleButton();
            this.rdoGuiNhieuNguoi = new System.Windows.Forms.RadioButton();
            this.rdoGuiMotNguoi = new System.Windows.Forms.RadioButton();
            this.txtTo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtsubject = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txttendangnhap = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtmatkhau = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btgui = new DevExpress.XtraEditors.SimpleButton();
            this.txtFile = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.richtinnhan = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbthongbao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "GỬI THƯ GMAIL";
            // 
            // btdinhkem
            // 
            this.btdinhkem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdinhkem.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btdinhkem.Appearance.Options.UseFont = true;
            this.btdinhkem.Appearance.Options.UseForeColor = true;
            this.btdinhkem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdinhkem.ImageOptions.Image")));
            this.btdinhkem.Location = new System.Drawing.Point(371, 186);
            this.btdinhkem.Name = "btdinhkem";
            this.btdinhkem.Size = new System.Drawing.Size(94, 31);
            this.btdinhkem.TabIndex = 28;
            this.btdinhkem.Text = "Attach";
            this.btdinhkem.Click += new System.EventHandler(this.btdinhkem_Click);
            // 
            // btGuiNhieuMail
            // 
            this.btGuiNhieuMail.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuiNhieuMail.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btGuiNhieuMail.Appearance.Options.UseFont = true;
            this.btGuiNhieuMail.Appearance.Options.UseForeColor = true;
            this.btGuiNhieuMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btGuiNhieuMail.ImageOptions.Image")));
            this.btGuiNhieuMail.Location = new System.Drawing.Point(371, 41);
            this.btGuiNhieuMail.Name = "btGuiNhieuMail";
            this.btGuiNhieuMail.Size = new System.Drawing.Size(94, 30);
            this.btGuiNhieuMail.TabIndex = 35;
            this.btGuiNhieuMail.Text = "List Mail";
            this.btGuiNhieuMail.Click += new System.EventHandler(this.btGuiNhieuMail_Click);
            // 
            // rdoGuiNhieuNguoi
            // 
            this.rdoGuiNhieuNguoi.AutoSize = true;
            this.rdoGuiNhieuNguoi.BackColor = System.Drawing.SystemColors.Control;
            this.rdoGuiNhieuNguoi.ForeColor = System.Drawing.Color.Red;
            this.rdoGuiNhieuNguoi.Location = new System.Drawing.Point(236, 24);
            this.rdoGuiNhieuNguoi.Name = "rdoGuiNhieuNguoi";
            this.rdoGuiNhieuNguoi.Size = new System.Drawing.Size(116, 19);
            this.rdoGuiNhieuNguoi.TabIndex = 39;
            this.rdoGuiNhieuNguoi.Text = "Gửi nhiều người";
            this.rdoGuiNhieuNguoi.UseVisualStyleBackColor = false;
            this.rdoGuiNhieuNguoi.CheckedChanged += new System.EventHandler(this.rdoGuiNhieuNguoi_CheckedChanged);
            // 
            // rdoGuiMotNguoi
            // 
            this.rdoGuiMotNguoi.AutoSize = true;
            this.rdoGuiMotNguoi.BackColor = System.Drawing.SystemColors.Control;
            this.rdoGuiMotNguoi.Checked = true;
            this.rdoGuiMotNguoi.ForeColor = System.Drawing.Color.Red;
            this.rdoGuiMotNguoi.Location = new System.Drawing.Point(115, 24);
            this.rdoGuiMotNguoi.Name = "rdoGuiMotNguoi";
            this.rdoGuiMotNguoi.Size = new System.Drawing.Size(105, 19);
            this.rdoGuiMotNguoi.TabIndex = 38;
            this.rdoGuiMotNguoi.TabStop = true;
            this.rdoGuiMotNguoi.Text = "Gửi một người";
            this.rdoGuiMotNguoi.UseVisualStyleBackColor = false;
            this.rdoGuiMotNguoi.CheckedChanged += new System.EventHandler(this.rdoGuiMotNguoi_CheckedChanged);
            // 
            // txtTo
            // 
            this.txtTo.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTo.ForeColor = System.Drawing.Color.Red;
            this.txtTo.Location = new System.Drawing.Point(111, 47);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(241, 22);
            this.txtTo.TabIndex = 25;
            // 
            // txtsubject
            // 
            this.txtsubject.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtsubject.ForeColor = System.Drawing.Color.Red;
            this.txtsubject.Location = new System.Drawing.Point(111, 73);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(241, 22);
            this.txtsubject.TabIndex = 26;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BorderColor = System.Drawing.Color.SeaGreen;
            this.txttendangnhap.ForeColor = System.Drawing.Color.Black;
            this.txttendangnhap.Location = new System.Drawing.Point(111, 99);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(241, 22);
            this.txttendangnhap.TabIndex = 23;
            this.txttendangnhap.Text = "nguyenthithuhong7399@gmail.com";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtmatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtmatkhau.Location = new System.Drawing.Point(111, 125);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(241, 22);
            this.txtmatkhau.TabIndex = 24;
            this.txtmatkhau.Text = "5851071025";
            // 
            // btgui
            // 
            this.btgui.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btgui.Appearance.Options.UseForeColor = true;
            this.btgui.Location = new System.Drawing.Point(111, 159);
            this.btgui.Name = "btgui";
            this.btgui.Size = new System.Drawing.Size(75, 23);
            this.btgui.TabIndex = 33;
            this.btgui.Text = "Send";
            this.btgui.Click += new System.EventHandler(this.btgui_Click);
            // 
            // txtFile
            // 
            this.txtFile.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFile.ForeColor = System.Drawing.Color.Red;
            this.txtFile.Location = new System.Drawing.Point(111, 192);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(241, 22);
            this.txtFile.TabIndex = 22;
            // 
            // richtinnhan
            // 
            this.richtinnhan.ForeColor = System.Drawing.Color.Red;
            this.richtinnhan.Location = new System.Drawing.Point(111, 218);
            this.richtinnhan.Name = "richtinnhan";
            this.richtinnhan.Size = new System.Drawing.Size(241, 111);
            this.richtinnhan.TabIndex = 34;
            this.richtinnhan.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Red;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 23);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lbthongbao);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.btGuiNhieuMail);
            this.groupBox1.Controls.Add(this.txttendangnhap);
            this.groupBox1.Controls.Add(this.btdinhkem);
            this.groupBox1.Controls.Add(this.richtinnhan);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.rdoGuiMotNguoi);
            this.groupBox1.Controls.Add(this.txtsubject);
            this.groupBox1.Controls.Add(this.btgui);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.rdoGuiNhieuNguoi);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 387);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // lbthongbao
            // 
            this.lbthongbao.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthongbao.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbthongbao.Appearance.Options.UseFont = true;
            this.lbthongbao.Appearance.Options.UseForeColor = true;
            this.lbthongbao.Location = new System.Drawing.Point(32, 346);
            this.lbthongbao.Name = "lbthongbao";
            this.lbthongbao.Size = new System.Drawing.Size(46, 15);
            this.lbthongbao.TabIndex = 48;
            this.lbthongbao.Text = "Ưu Đãi :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(32, 221);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 15);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Message :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(32, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 15);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "Pass Gmail :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(32, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 15);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Tên Gmail :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(32, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 15);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Subject :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 15);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "To :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 78);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // GuiGmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuiGmail";
            this.Text = "GuiGmail";
            this.Load += new System.EventHandler(this.GuiGmail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btdinhkem;
        private DevExpress.XtraEditors.SimpleButton btGuiNhieuMail;
        private System.Windows.Forms.RadioButton rdoGuiNhieuNguoi;
        private System.Windows.Forms.RadioButton rdoGuiMotNguoi;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtsubject;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txttendangnhap;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtmatkhau;
        private DevExpress.XtraEditors.SimpleButton btgui;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtFile;
        private System.Windows.Forms.RichTextBox richtinnhan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl lbthongbao;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}