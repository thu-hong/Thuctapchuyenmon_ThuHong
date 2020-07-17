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
            this.lbthongbao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btdinhkem
            // 
            this.btdinhkem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdinhkem.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btdinhkem.Appearance.Options.UseFont = true;
            this.btdinhkem.Appearance.Options.UseForeColor = true;
            this.btdinhkem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdinhkem.ImageOptions.Image")));
            this.btdinhkem.Location = new System.Drawing.Point(358, 268);
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
            this.btGuiNhieuMail.Location = new System.Drawing.Point(358, 123);
            this.btGuiNhieuMail.Name = "btGuiNhieuMail";
            this.btGuiNhieuMail.Size = new System.Drawing.Size(94, 30);
            this.btGuiNhieuMail.TabIndex = 35;
            this.btGuiNhieuMail.Text = "List Mail";
            this.btGuiNhieuMail.Click += new System.EventHandler(this.btGuiNhieuMail_Click);
            // 
            // rdoGuiNhieuNguoi
            // 
            this.rdoGuiNhieuNguoi.AutoSize = true;
            this.rdoGuiNhieuNguoi.BackColor = System.Drawing.Color.Blue;
            this.rdoGuiNhieuNguoi.ForeColor = System.Drawing.Color.White;
            this.rdoGuiNhieuNguoi.Location = new System.Drawing.Point(223, 106);
            this.rdoGuiNhieuNguoi.Name = "rdoGuiNhieuNguoi";
            this.rdoGuiNhieuNguoi.Size = new System.Drawing.Size(99, 17);
            this.rdoGuiNhieuNguoi.TabIndex = 39;
            this.rdoGuiNhieuNguoi.Text = "Gửi nhiều người";
            this.rdoGuiNhieuNguoi.UseVisualStyleBackColor = false;
            this.rdoGuiNhieuNguoi.CheckedChanged += new System.EventHandler(this.rdoGuiNhieuNguoi_CheckedChanged);
            // 
            // rdoGuiMotNguoi
            // 
            this.rdoGuiMotNguoi.AutoSize = true;
            this.rdoGuiMotNguoi.BackColor = System.Drawing.Color.Blue;
            this.rdoGuiMotNguoi.Checked = true;
            this.rdoGuiMotNguoi.ForeColor = System.Drawing.Color.White;
            this.rdoGuiMotNguoi.Location = new System.Drawing.Point(102, 106);
            this.rdoGuiMotNguoi.Name = "rdoGuiMotNguoi";
            this.rdoGuiMotNguoi.Size = new System.Drawing.Size(90, 17);
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
            this.txtTo.Location = new System.Drawing.Point(98, 129);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(241, 20);
            this.txtTo.TabIndex = 25;
            // 
            // txtsubject
            // 
            this.txtsubject.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtsubject.ForeColor = System.Drawing.Color.Red;
            this.txtsubject.Location = new System.Drawing.Point(98, 155);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(241, 20);
            this.txtsubject.TabIndex = 26;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BorderColor = System.Drawing.Color.SeaGreen;
            this.txttendangnhap.ForeColor = System.Drawing.Color.Black;
            this.txttendangnhap.Location = new System.Drawing.Point(98, 181);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(241, 20);
            this.txttendangnhap.TabIndex = 23;
            this.txttendangnhap.Text = "nguyenthithuhong7399@gmail.com";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtmatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtmatkhau.Location = new System.Drawing.Point(98, 207);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(241, 20);
            this.txtmatkhau.TabIndex = 24;
            this.txtmatkhau.Text = "5851071025";
            // 
            // btgui
            // 
            this.btgui.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btgui.Appearance.Options.UseForeColor = true;
            this.btgui.Location = new System.Drawing.Point(98, 241);
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
            this.txtFile.Location = new System.Drawing.Point(98, 274);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(241, 20);
            this.txtFile.TabIndex = 22;
            // 
            // richtinnhan
            // 
            this.richtinnhan.ForeColor = System.Drawing.Color.Red;
            this.richtinnhan.Location = new System.Drawing.Point(98, 300);
            this.richtinnhan.Name = "richtinnhan";
            this.richtinnhan.Size = new System.Drawing.Size(241, 111);
            this.richtinnhan.TabIndex = 34;
            this.richtinnhan.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Red;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbthongbao
            // 
            this.lbthongbao.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthongbao.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbthongbao.Appearance.Options.UseFont = true;
            this.lbthongbao.Appearance.Options.UseForeColor = true;
            this.lbthongbao.Location = new System.Drawing.Point(19, 428);
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
            this.labelControl5.Location = new System.Drawing.Point(19, 303);
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
            this.labelControl4.Location = new System.Drawing.Point(19, 214);
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
            this.labelControl3.Location = new System.Drawing.Point(19, 188);
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
            this.labelControl2.Location = new System.Drawing.Point(19, 158);
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
            this.labelControl1.Location = new System.Drawing.Point(19, 129);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 15);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "To :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(185, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(116, 24);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "GỬI GMAIL";
            // 
            // GuiGmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 466);
            this.Controls.Add(this.lbthongbao);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.rdoGuiNhieuNguoi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btgui);
            this.Controls.Add(this.btGuiNhieuMail);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.rdoGuiMotNguoi);
            this.Controls.Add(this.btdinhkem);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.richtinnhan);
            this.Name = "GuiGmail";
            this.Text = "GuiGmail";
            this.Load += new System.EventHandler(this.GuiGmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraEditors.LabelControl lbthongbao;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}