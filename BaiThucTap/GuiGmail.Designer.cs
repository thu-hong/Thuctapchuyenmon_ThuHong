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
            this.lbthongbao = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdoGuiNhieuNguoi = new System.Windows.Forms.RadioButton();
            this.rdoGuiMotNguoi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btGuiNhieuMail = new DevExpress.XtraEditors.SimpleButton();
            this.richtinnhan = new System.Windows.Forms.RichTextBox();
            this.btgui = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btdinhkem = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubject = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtTo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtmatkhau = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txttendangnhap = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtFile = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // lbthongbao
            // 
            this.lbthongbao.AutoSize = true;
            this.lbthongbao.Location = new System.Drawing.Point(9, 388);
            this.lbthongbao.Name = "lbthongbao";
            this.lbthongbao.Size = new System.Drawing.Size(62, 13);
            this.lbthongbao.TabIndex = 41;
            this.lbthongbao.Text = "Thông báo ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 388);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rdoGuiNhieuNguoi
            // 
            this.rdoGuiNhieuNguoi.AutoSize = true;
            this.rdoGuiNhieuNguoi.Location = new System.Drawing.Point(216, 66);
            this.rdoGuiNhieuNguoi.Name = "rdoGuiNhieuNguoi";
            this.rdoGuiNhieuNguoi.Size = new System.Drawing.Size(99, 17);
            this.rdoGuiNhieuNguoi.TabIndex = 39;
            this.rdoGuiNhieuNguoi.Text = "Gửi nhiều người";
            this.rdoGuiNhieuNguoi.UseVisualStyleBackColor = true;
            this.rdoGuiNhieuNguoi.CheckedChanged += new System.EventHandler(this.rdoGuiNhieuNguoi_CheckedChanged);
            // 
            // rdoGuiMotNguoi
            // 
            this.rdoGuiMotNguoi.AutoSize = true;
            this.rdoGuiMotNguoi.Checked = true;
            this.rdoGuiMotNguoi.Location = new System.Drawing.Point(116, 66);
            this.rdoGuiMotNguoi.Name = "rdoGuiMotNguoi";
            this.rdoGuiMotNguoi.Size = new System.Drawing.Size(90, 17);
            this.rdoGuiMotNguoi.TabIndex = 38;
            this.rdoGuiMotNguoi.TabStop = true;
            this.rdoGuiMotNguoi.Text = "Gửi một người";
            this.rdoGuiMotNguoi.UseVisualStyleBackColor = true;
            this.rdoGuiMotNguoi.CheckedChanged += new System.EventHandler(this.rdoGuiMotNguoi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Chức Năng Gửi Mail Cho Khách Hàng ";
            // 
            // btGuiNhieuMail
            // 
            this.btGuiNhieuMail.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuiNhieuMail.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btGuiNhieuMail.Appearance.Options.UseFont = true;
            this.btGuiNhieuMail.Appearance.Options.UseForeColor = true;
            this.btGuiNhieuMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btGuiNhieuMail.ImageOptions.Image")));
            this.btGuiNhieuMail.Location = new System.Drawing.Point(372, 83);
            this.btGuiNhieuMail.Name = "btGuiNhieuMail";
            this.btGuiNhieuMail.Size = new System.Drawing.Size(94, 30);
            this.btGuiNhieuMail.TabIndex = 35;
            this.btGuiNhieuMail.Text = "List Mail";
            this.btGuiNhieuMail.Click += new System.EventHandler(this.btGuiNhieuMail_Click);
            // 
            // richtinnhan
            // 
            this.richtinnhan.Location = new System.Drawing.Point(112, 260);
            this.richtinnhan.Name = "richtinnhan";
            this.richtinnhan.Size = new System.Drawing.Size(241, 111);
            this.richtinnhan.TabIndex = 34;
            this.richtinnhan.Text = "";
            // 
            // btgui
            // 
            this.btgui.Location = new System.Drawing.Point(112, 201);
            this.btgui.Name = "btgui";
            this.btgui.Size = new System.Drawing.Size(75, 23);
            this.btgui.TabIndex = 33;
            this.btgui.Text = "Send";
            this.btgui.Click += new System.EventHandler(this.btgui_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tên đăng nhập ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Message";
            // 
            // btdinhkem
            // 
            this.btdinhkem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdinhkem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btdinhkem.Appearance.Options.UseFont = true;
            this.btdinhkem.Appearance.Options.UseForeColor = true;
            this.btdinhkem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdinhkem.ImageOptions.Image")));
            this.btdinhkem.Location = new System.Drawing.Point(372, 228);
            this.btdinhkem.Name = "btdinhkem";
            this.btdinhkem.Size = new System.Drawing.Size(94, 31);
            this.btdinhkem.TabIndex = 28;
            this.btdinhkem.Text = "Attach";
            this.btdinhkem.Click += new System.EventHandler(this.btdinhkem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "To";
            // 
            // txtsubject
            // 
            this.txtsubject.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtsubject.Location = new System.Drawing.Point(112, 115);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(241, 20);
            this.txtsubject.TabIndex = 26;
            // 
            // txtTo
            // 
            this.txtTo.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTo.Location = new System.Drawing.Point(112, 89);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(241, 20);
            this.txtTo.TabIndex = 25;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtmatkhau.Location = new System.Drawing.Point(112, 167);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(241, 20);
            this.txtmatkhau.TabIndex = 24;
            this.txtmatkhau.Text = "0329104765";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BorderColor = System.Drawing.Color.SeaGreen;
            this.txttendangnhap.Location = new System.Drawing.Point(112, 141);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(241, 20);
            this.txttendangnhap.TabIndex = 23;
            this.txttendangnhap.Text = "nguyenthithuhong7399@gmail.com";
            // 
            // txtFile
            // 
            this.txtFile.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFile.Location = new System.Drawing.Point(112, 234);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(241, 20);
            this.txtFile.TabIndex = 22;
            // 
            // GuiGmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(497, 444);
            this.Controls.Add(this.lbthongbao);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rdoGuiNhieuNguoi);
            this.Controls.Add(this.rdoGuiMotNguoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGuiNhieuMail);
            this.Controls.Add(this.richtinnhan);
            this.Controls.Add(this.btgui);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btdinhkem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.txtFile);
            this.Name = "GuiGmail";
            this.Text = "GuiGmail";
            this.Load += new System.EventHandler(this.GuiGmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbthongbao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdoGuiNhieuNguoi;
        private System.Windows.Forms.RadioButton rdoGuiMotNguoi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btGuiNhieuMail;
        private System.Windows.Forms.RichTextBox richtinnhan;
        private DevExpress.XtraEditors.SimpleButton btgui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btdinhkem;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtsubject;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtmatkhau;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txttendangnhap;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtFile;
    }
}