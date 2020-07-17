namespace BaiThucTap
{
    partial class QuanLyHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthemHD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.cbuser = new System.Windows.Forms.ComboBox();
            this.txttongtien = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnxuatpdf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnxuatexcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbmaud = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridview1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataSetHoaDon1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetHoaDon1 = new BaiThucTap.DataSetHoaDon();
            this.dataSetHoaDon1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter1 = new BaiThucTap.DataSetHoaDonTableAdapters.HoaDonTableAdapter();
            this.moFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDon1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDon1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnthemHD);
            this.groupBox1.Controls.Add(this.cbkhachhang);
            this.groupBox1.Controls.Add(this.cbuser);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnxuatpdf);
            this.groupBox1.Controls.Add(this.btnxuatexcel);
            this.groupBox1.Controls.Add(this.cbmaud);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnthemHD
            // 
            this.btnthemHD.Activecolor = System.Drawing.Color.Transparent;
            this.btnthemHD.BackColor = System.Drawing.Color.Gainsboro;
            this.btnthemHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthemHD.BorderRadius = 0;
            this.btnthemHD.ButtonText = "THÊM HĐ";
            this.btnthemHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemHD.DisabledColor = System.Drawing.Color.Gray;
            this.btnthemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthemHD.Iconcolor = System.Drawing.Color.Transparent;
            this.btnthemHD.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnthemHD.Iconimage")));
            this.btnthemHD.Iconimage_right = null;
            this.btnthemHD.Iconimage_right_Selected = null;
            this.btnthemHD.Iconimage_Selected = null;
            this.btnthemHD.IconMarginLeft = 0;
            this.btnthemHD.IconMarginRight = 0;
            this.btnthemHD.IconRightVisible = true;
            this.btnthemHD.IconRightZoom = 0D;
            this.btnthemHD.IconVisible = true;
            this.btnthemHD.IconZoom = 90D;
            this.btnthemHD.IsTab = false;
            this.btnthemHD.Location = new System.Drawing.Point(114, 137);
            this.btnthemHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemHD.Name = "btnthemHD";
            this.btnthemHD.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnthemHD.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnthemHD.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnthemHD.selected = false;
            this.btnthemHD.Size = new System.Drawing.Size(122, 58);
            this.btnthemHD.TabIndex = 72;
            this.btnthemHD.Text = "THÊM HĐ";
            this.btnthemHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemHD.Textcolor = System.Drawing.Color.Blue;
            this.btnthemHD.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemHD.Click += new System.EventHandler(this.btnthemHD_Click);
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(114, 61);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(173, 23);
            this.cbkhachhang.TabIndex = 78;
            // 
            // cbuser
            // 
            this.cbuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbuser.FormattingEnabled = true;
            this.cbuser.Location = new System.Drawing.Point(114, 22);
            this.cbuser.Name = "cbuser";
            this.cbuser.Size = new System.Drawing.Size(173, 23);
            this.cbuser.TabIndex = 77;
            this.cbuser.SelectedIndexChanged += new System.EventHandler(this.cbuser_SelectedIndexChanged);
            // 
            // txttongtien
            // 
            this.txttongtien.BackColor = System.Drawing.Color.White;
            this.txttongtien.BorderColorFocused = System.Drawing.Color.Blue;
            this.txttongtien.BorderColorIdle = System.Drawing.Color.Black;
            this.txttongtien.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txttongtien.BorderThickness = 1;
            this.txttongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttongtien.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txttongtien.isPassword = false;
            this.txttongtien.Location = new System.Drawing.Point(475, 56);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(173, 23);
            this.txttongtien.TabIndex = 76;
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "UserName :";
            // 
            // btnxuatpdf
            // 
            this.btnxuatpdf.Activecolor = System.Drawing.Color.Transparent;
            this.btnxuatpdf.BackColor = System.Drawing.Color.Gainsboro;
            this.btnxuatpdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxuatpdf.BorderRadius = 0;
            this.btnxuatpdf.ButtonText = "XUẤT PDF";
            this.btnxuatpdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxuatpdf.DisabledColor = System.Drawing.Color.Gray;
            this.btnxuatpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatpdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnxuatpdf.Iconcolor = System.Drawing.Color.Transparent;
            this.btnxuatpdf.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnxuatpdf.Iconimage")));
            this.btnxuatpdf.Iconimage_right = null;
            this.btnxuatpdf.Iconimage_right_Selected = null;
            this.btnxuatpdf.Iconimage_Selected = null;
            this.btnxuatpdf.IconMarginLeft = 0;
            this.btnxuatpdf.IconMarginRight = 0;
            this.btnxuatpdf.IconRightVisible = true;
            this.btnxuatpdf.IconRightZoom = 0D;
            this.btnxuatpdf.IconVisible = true;
            this.btnxuatpdf.IconZoom = 90D;
            this.btnxuatpdf.IsTab = false;
            this.btnxuatpdf.Location = new System.Drawing.Point(475, 137);
            this.btnxuatpdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxuatpdf.Name = "btnxuatpdf";
            this.btnxuatpdf.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnxuatpdf.OnHovercolor = System.Drawing.Color.White;
            this.btnxuatpdf.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnxuatpdf.selected = false;
            this.btnxuatpdf.Size = new System.Drawing.Size(134, 58);
            this.btnxuatpdf.TabIndex = 73;
            this.btnxuatpdf.Text = "XUẤT PDF";
            this.btnxuatpdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxuatpdf.Textcolor = System.Drawing.Color.Blue;
            this.btnxuatpdf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatpdf.Click += new System.EventHandler(this.btnxuatpdf_Click);
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Activecolor = System.Drawing.Color.Transparent;
            this.btnxuatexcel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnxuatexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxuatexcel.BorderRadius = 0;
            this.btnxuatexcel.ButtonText = "XUẤT EXCEL";
            this.btnxuatexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxuatexcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnxuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatexcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnxuatexcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnxuatexcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnxuatexcel.Iconimage")));
            this.btnxuatexcel.Iconimage_right = null;
            this.btnxuatexcel.Iconimage_right_Selected = null;
            this.btnxuatexcel.Iconimage_Selected = null;
            this.btnxuatexcel.IconMarginLeft = 0;
            this.btnxuatexcel.IconMarginRight = 0;
            this.btnxuatexcel.IconRightVisible = true;
            this.btnxuatexcel.IconRightZoom = 0D;
            this.btnxuatexcel.IconVisible = true;
            this.btnxuatexcel.IconZoom = 90D;
            this.btnxuatexcel.IsTab = false;
            this.btnxuatexcel.Location = new System.Drawing.Point(286, 137);
            this.btnxuatexcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnxuatexcel.OnHovercolor = System.Drawing.Color.White;
            this.btnxuatexcel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnxuatexcel.selected = false;
            this.btnxuatexcel.Size = new System.Drawing.Size(142, 58);
            this.btnxuatexcel.TabIndex = 71;
            this.btnxuatexcel.Text = "XUẤT EXCEL";
            this.btnxuatexcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxuatexcel.Textcolor = System.Drawing.Color.Blue;
            this.btnxuatexcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatexcel.Click += new System.EventHandler(this.btnxuatexcel_Click);
            // 
            // cbmaud
            // 
            this.cbmaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbmaud.FormattingEnabled = true;
            this.cbmaud.Location = new System.Drawing.Point(475, 19);
            this.cbmaud.Name = "cbmaud";
            this.cbmaud.Size = new System.Drawing.Size(173, 23);
            this.cbmaud.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Khách Hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Ưu Đãi :";
            // 
            // dataGridview1
            // 
            this.dataGridview1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridview1.AutoGenerateColumns = false;
            this.dataGridview1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.tglap,
            this.makh,
            this.tongtien,
            this.maud,
            this.trangthai,
            this.username,
            this.xoa});
            this.dataGridview1.DataSource = this.dataSetHoaDon1BindingSource1;
            this.dataGridview1.DoubleBuffered = true;
            this.dataGridview1.EnableHeadersVisualStyles = false;
            this.dataGridview1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridview1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridview1.Location = new System.Drawing.Point(25, 279);
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridview1.Size = new System.Drawing.Size(819, 217);
            this.dataGridview1.TabIndex = 5;
            this.dataGridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview1_CellContentClick);
            // 
            // mahd
            // 
            this.mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahd.DataPropertyName = "MaHD";
            this.mahd.HeaderText = "Mã Hóa Đơn";
            this.mahd.Name = "mahd";
            // 
            // tglap
            // 
            this.tglap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tglap.DataPropertyName = "TGLap";
            this.tglap.HeaderText = "TG Lập";
            this.tglap.Name = "tglap";
            // 
            // makh
            // 
            this.makh.DataPropertyName = "MaKH";
            this.makh.HeaderText = "Mã Khách Hàng";
            this.makh.Name = "makh";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "TongTien";
            this.tongtien.HeaderText = "Tổng Tiền ";
            this.tongtien.Name = "tongtien";
            // 
            // maud
            // 
            this.maud.DataPropertyName = "MaUD";
            this.maud.HeaderText = "Mã Ưu Đãi";
            this.maud.Name = "maud";
            // 
            // trangthai
            // 
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.Name = "trangthai";
            // 
            // username
            // 
            this.username.DataPropertyName = "UserName";
            this.username.HeaderText = "UserName";
            this.username.Name = "username";
            // 
            // xoa
            // 
            this.xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xoa.DataPropertyName = "xoa";
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            // 
            // dataSetHoaDon1BindingSource1
            // 
            this.dataSetHoaDon1BindingSource1.DataSource = this.dataSetHoaDon1;
            this.dataSetHoaDon1BindingSource1.Position = 0;
            // 
            // dataSetHoaDon1
            // 
            this.dataSetHoaDon1.DataSetName = "DataSetHoaDon";
            this.dataSetHoaDon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetHoaDon1BindingSource
            // 
            this.dataSetHoaDon1BindingSource.DataMember = "HoaDon";
            this.dataSetHoaDon1BindingSource.DataSource = this.dataSetHoaDon1;
            // 
            // hoaDonTableAdapter1
            // 
            this.hoaDonTableAdapter1.ClearBeforeFill = true;
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(871, 507);
            this.Controls.Add(this.dataGridview1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyHoaDon";
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDon1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDon1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnthemHD;
        private Bunifu.Framework.UI.BunifuFlatButton btnxuatexcel;
        private System.Windows.Forms.ComboBox cbmaud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridview1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttongtien;
        private DataSetHoaDon dataSetHoaDon1;
        private DataSetHoaDonTableAdapters.HoaDonTableAdapter hoaDonTableAdapter1;
        private System.Windows.Forms.SaveFileDialog moFile;
        private System.Windows.Forms.ComboBox cbuser;
        private System.Windows.Forms.BindingSource dataSetHoaDon1BindingSource;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglap;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maud;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnxuatpdf;
        private System.Windows.Forms.BindingSource dataSetHoaDon1BindingSource1;
    }
}