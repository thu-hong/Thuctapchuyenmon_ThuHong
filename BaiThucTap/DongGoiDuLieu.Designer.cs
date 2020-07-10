namespace BaiThucTap
{
    partial class DongGoiDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DongGoiDuLieu));
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.btbrowser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btbackup = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPath = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuTextbox3 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(6, 30);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(408, 58);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Hiện thị đường lưu";
            // 
            // btbrowser
            // 
            this.btbrowser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btbrowser.BackColor = System.Drawing.Color.White;
            this.btbrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbrowser.BorderRadius = 0;
            this.btbrowser.ButtonText = "Browser";
            this.btbrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbrowser.DisabledColor = System.Drawing.Color.Gray;
            this.btbrowser.Iconcolor = System.Drawing.Color.Transparent;
            this.btbrowser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btbrowser.Iconimage")));
            this.btbrowser.Iconimage_right = null;
            this.btbrowser.Iconimage_right_Selected = null;
            this.btbrowser.Iconimage_Selected = null;
            this.btbrowser.IconMarginLeft = 0;
            this.btbrowser.IconMarginRight = 0;
            this.btbrowser.IconRightVisible = true;
            this.btbrowser.IconRightZoom = 0D;
            this.btbrowser.IconVisible = true;
            this.btbrowser.IconZoom = 90D;
            this.btbrowser.IsTab = false;
            this.btbrowser.Location = new System.Drawing.Point(440, 30);
            this.btbrowser.Name = "btbrowser";
            this.btbrowser.Normalcolor = System.Drawing.Color.White;
            this.btbrowser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btbrowser.OnHoverTextColor = System.Drawing.Color.White;
            this.btbrowser.selected = false;
            this.btbrowser.Size = new System.Drawing.Size(146, 58);
            this.btbrowser.TabIndex = 1;
            this.btbrowser.Text = "Browser";
            this.btbrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbrowser.Textcolor = System.Drawing.Color.Red;
            this.btbrowser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbrowser.Click += new System.EventHandler(this.btbrowser_Click);
            // 
            // btbackup
            // 
            this.btbackup.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbackup.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btbackup.Appearance.Options.UseFont = true;
            this.btbackup.Appearance.Options.UseForeColor = true;
            this.btbackup.Location = new System.Drawing.Point(215, 104);
            this.btbackup.Name = "btbackup";
            this.btbackup.Size = new System.Drawing.Size(125, 54);
            this.btbackup.TabIndex = 2;
            this.btbackup.Text = "BACKUP";
            this.btbackup.Click += new System.EventHandler(this.btbackup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.bunifuTextbox1);
            this.groupBox1.Controls.Add(this.btbrowser);
            this.groupBox1.Controls.Add(this.btbackup);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPath);
            this.groupBox2.Controls.Add(this.bunifuFlatButton1);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 179);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup Database";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.Silver;
            this.txtPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPath.BackgroundImage")));
            this.txtPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPath.Icon = ((System.Drawing.Image)(resources.GetObject("txtPath.Icon")));
            this.txtPath.Location = new System.Drawing.Point(6, 40);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(408, 58);
            this.txtPath.TabIndex = 0;
            this.txtPath.text = "Hiện thị đường lưu";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Browser";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(440, 40);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(146, 58);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Browser";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.btbrowser_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(215, 119);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 54);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "BACKUP";
            this.simpleButton1.Click += new System.EventHandler(this.btbackup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuTextbox3);
            this.groupBox3.Controls.Add(this.bunifuFlatButton2);
            this.groupBox3.Controls.Add(this.simpleButton2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 179);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Backup Database";
            // 
            // bunifuTextbox3
            // 
            this.bunifuTextbox3.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox3.BackgroundImage")));
            this.bunifuTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTextbox3.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox3.Icon")));
            this.bunifuTextbox3.Location = new System.Drawing.Point(6, 30);
            this.bunifuTextbox3.Name = "bunifuTextbox3";
            this.bunifuTextbox3.Size = new System.Drawing.Size(408, 58);
            this.bunifuTextbox3.TabIndex = 0;
            this.bunifuTextbox3.text = "Hiện thị đường lưu";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Browser";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(440, 30);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(146, 58);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "Browser";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Red;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.btbrowser_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(215, 104);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(125, 54);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "BACKUP";
            this.simpleButton2.Click += new System.EventHandler(this.btbackup_Click);
            // 
            // DongGoiDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 210);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DongGoiDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DongGoiDuLieu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuFlatButton btbrowser;
        private DevExpress.XtraEditors.SimpleButton btbackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuTextbox txtPath;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}