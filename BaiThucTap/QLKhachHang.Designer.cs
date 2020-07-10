namespace BaiThucTap
{
    partial class QLKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btfile = new DevExpress.XtraEditors.SimpleButton();
            this.txtnhapmatim = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsdt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtemail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtdiachi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txttenkh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtmakh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttrove = new DevExpress.XtraEditors.SimpleButton();
            this.bttimkiem1 = new DevExpress.XtraEditors.SimpleButton();
            this.btthoat1 = new DevExpress.XtraEditors.SimpleButton();
            this.btsua1 = new DevExpress.XtraEditors.SimpleButton();
            this.btthem1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btxoa1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtngaymua = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btfile
            // 
            this.btfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btfile.ImageOptions.Image")));
            this.btfile.Location = new System.Drawing.Point(154, 229);
            this.btfile.Name = "btfile";
            this.btfile.Size = new System.Drawing.Size(83, 37);
            this.btfile.TabIndex = 43;
            this.btfile.Text = "File";
            this.btfile.Click += new System.EventHandler(this.btfile_Click);
            // 
            // txtnhapmatim
            // 
            this.txtnhapmatim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnhapmatim.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnhapmatim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnhapmatim.HintForeColor = System.Drawing.Color.Empty;
            this.txtnhapmatim.HintText = "";
            this.txtnhapmatim.isPassword = false;
            this.txtnhapmatim.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnhapmatim.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnhapmatim.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnhapmatim.LineThickness = 3;
            this.txtnhapmatim.Location = new System.Drawing.Point(453, 85);
            this.txtnhapmatim.Margin = new System.Windows.Forms.Padding(4);
            this.txtnhapmatim.Name = "txtnhapmatim";
            this.txtnhapmatim.Size = new System.Drawing.Size(220, 25);
            this.txtnhapmatim.TabIndex = 13;
            this.txtnhapmatim.Text = "Nhập mã khách hàng cần tìm";
            this.txtnhapmatim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnhapmatim.OnValueChanged += new System.EventHandler(this.txtnhapmatim_OnValueChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsdt.HintForeColor = System.Drawing.Color.Empty;
            this.txtsdt.HintText = "";
            this.txtsdt.isPassword = false;
            this.txtsdt.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtsdt.LineIdleColor = System.Drawing.Color.Gray;
            this.txtsdt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtsdt.LineThickness = 3;
            this.txtsdt.Location = new System.Drawing.Point(144, 90);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(220, 25);
            this.txtsdt.TabIndex = 12;
            this.txtsdt.Text = "vd:02929928";
            this.txtsdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsdt.OnValueChanged += new System.EventHandler(this.txtsdt_OnValueChanged);
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtemail.HintForeColor = System.Drawing.Color.Empty;
            this.txtemail.HintText = "";
            this.txtemail.isPassword = false;
            this.txtemail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtemail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtemail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtemail.LineThickness = 3;
            this.txtemail.Location = new System.Drawing.Point(453, 53);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(220, 25);
            this.txtemail.TabIndex = 11;
            this.txtemail.Text = "vd:hong@gmail.com";
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdiachi.HintForeColor = System.Drawing.Color.Empty;
            this.txtdiachi.HintText = "";
            this.txtdiachi.isPassword = false;
            this.txtdiachi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtdiachi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdiachi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtdiachi.LineThickness = 3;
            this.txtdiachi.Location = new System.Drawing.Point(453, 20);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(220, 25);
            this.txtdiachi.TabIndex = 10;
            this.txtdiachi.Text = "vd:172 Lê Văn Việt";
            this.txtdiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txttenkh
            // 
            this.txttenkh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenkh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttenkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttenkh.HintForeColor = System.Drawing.Color.Empty;
            this.txttenkh.HintText = "";
            this.txttenkh.isPassword = false;
            this.txttenkh.LineFocusedColor = System.Drawing.Color.Blue;
            this.txttenkh.LineIdleColor = System.Drawing.Color.Gray;
            this.txttenkh.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txttenkh.LineThickness = 3;
            this.txttenkh.Location = new System.Drawing.Point(144, 57);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(220, 25);
            this.txttenkh.TabIndex = 9;
            this.txttenkh.Text = "vd: Nguyễn Thị A";
            this.txttenkh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtmakh
            // 
            this.txtmakh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmakh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmakh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmakh.HintForeColor = System.Drawing.Color.Empty;
            this.txtmakh.HintText = "";
            this.txtmakh.isPassword = false;
            this.txtmakh.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtmakh.LineIdleColor = System.Drawing.Color.Gray;
            this.txtmakh.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtmakh.LineThickness = 3;
            this.txtmakh.Location = new System.Drawing.Point(144, 20);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(220, 25);
            this.txtmakh.TabIndex = 8;
            this.txtmakh.Text = "vd:KH01";
            this.txtmakh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhập mã tìm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // bttrove
            // 
            this.bttrove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttrove.ImageOptions.Image")));
            this.bttrove.Location = new System.Drawing.Point(18, 13);
            this.bttrove.Name = "bttrove";
            this.bttrove.Size = new System.Drawing.Size(42, 37);
            this.bttrove.TabIndex = 42;
            this.bttrove.Click += new System.EventHandler(this.bttrove_Click);
            // 
            // bttimkiem1
            // 
            this.bttimkiem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttimkiem1.ImageOptions.Image")));
            this.bttimkiem1.Location = new System.Drawing.Point(628, 229);
            this.bttimkiem1.Name = "bttimkiem1";
            this.bttimkiem1.Size = new System.Drawing.Size(86, 37);
            this.bttimkiem1.TabIndex = 41;
            this.bttimkiem1.Text = "Tìm Kiếm";
            this.bttimkiem1.Click += new System.EventHandler(this.bttimkiem1_Click);
            // 
            // btthoat1
            // 
            this.btthoat1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthoat1.ImageOptions.Image")));
            this.btthoat1.Location = new System.Drawing.Point(739, 13);
            this.btthoat1.Name = "btthoat1";
            this.btthoat1.Size = new System.Drawing.Size(43, 38);
            this.btthoat1.TabIndex = 40;
            this.btthoat1.Click += new System.EventHandler(this.btthoat1_Click);
            // 
            // btsua1
            // 
            this.btsua1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btsua1.ImageOptions.Image")));
            this.btsua1.Location = new System.Drawing.Point(510, 229);
            this.btsua1.Name = "btsua1";
            this.btsua1.Size = new System.Drawing.Size(79, 37);
            this.btsua1.TabIndex = 39;
            this.btsua1.Text = "Sửa";
            this.btsua1.Click += new System.EventHandler(this.btsua1_Click);
            // 
            // btthem1
            // 
            this.btthem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthem1.ImageOptions.Image")));
            this.btthem1.Location = new System.Drawing.Point(389, 229);
            this.btthem1.Name = "btthem1";
            this.btthem1.Size = new System.Drawing.Size(79, 37);
            this.btthem1.TabIndex = 38;
            this.btthem1.Text = "Thêm";
            this.btthem1.Click += new System.EventHandler(this.btthem1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "QUẢN LÍ KHÁCH HÀNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SDT";
            // 
            // btxoa1
            // 
            this.btxoa1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btxoa1.ImageOptions.Image")));
            this.btxoa1.Location = new System.Drawing.Point(265, 229);
            this.btxoa1.Name = "btxoa1";
            this.btxoa1.Size = new System.Drawing.Size(83, 37);
            this.btxoa1.TabIndex = 37;
            this.btxoa1.Text = "Xóa";
            this.btxoa1.Click += new System.EventHandler(this.btxoa1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(101, 19);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtngaymua);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnhapmatim);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 157);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txtngaymua
            // 
            this.txtngaymua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtngaymua.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtngaymua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtngaymua.HintForeColor = System.Drawing.Color.Empty;
            this.txtngaymua.HintText = "";
            this.txtngaymua.isPassword = false;
            this.txtngaymua.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtngaymua.LineIdleColor = System.Drawing.Color.Gray;
            this.txtngaymua.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtngaymua.LineThickness = 3;
            this.txtngaymua.Location = new System.Drawing.Point(144, 123);
            this.txtngaymua.Margin = new System.Windows.Forms.Padding(4);
            this.txtngaymua.Name = "txtngaymua";
            this.txtngaymua.Size = new System.Drawing.Size(220, 25);
            this.txtngaymua.TabIndex = 15;
            this.txtngaymua.Text = "7/2/2020";
            this.txtngaymua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày Mua";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(18, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 178);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // btluu
            // 
            this.btluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btluu.ImageOptions.Image")));
            this.btluu.Location = new System.Drawing.Point(53, 229);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(81, 37);
            this.btluu.TabIndex = 45;
            this.btluu.Text = "Lưu";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btfile);
            this.Controls.Add(this.bttrove);
            this.Controls.Add(this.bttimkiem1);
            this.Controls.Add(this.btthoat1);
            this.Controls.Add(this.btsua1);
            this.Controls.Add(this.btthem1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btxoa1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLKhachHang";
            this.Text = "QLKhachHang";
            this.Load += new System.EventHandler(this.QLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btfile;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnhapmatim;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsdt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtemail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdiachi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txttenkh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtmakh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton bttrove;
        private DevExpress.XtraEditors.SimpleButton bttimkiem1;
        private DevExpress.XtraEditors.SimpleButton btthoat1;
        private DevExpress.XtraEditors.SimpleButton btsua1;
        private DevExpress.XtraEditors.SimpleButton btthem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btxoa1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtngaymua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btluu;
    }
}