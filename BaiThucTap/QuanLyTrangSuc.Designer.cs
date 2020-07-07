namespace BaiThucTap
{
    partial class QuanLyTrangSuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTrangSuc));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.trangSucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTrangSuc = new BaiThucTap.DataSetTrangSuc();
            this.label4 = new System.Windows.Forms.Label();
            this.trangSucTableAdapter = new BaiThucTap.DataSetTrangSucTableAdapters.TrangSucTableAdapter();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.btxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btsua = new DevExpress.XtraEditors.SimpleButton();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoLuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaLoai = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDonVi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDonGia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMaTS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTenTS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangSucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrangSuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTSDataGridViewTextBoxColumn,
            this.tenTSDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.trangSucBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maTSDataGridViewTextBoxColumn
            // 
            this.maTSDataGridViewTextBoxColumn.DataPropertyName = "MaTS";
            this.maTSDataGridViewTextBoxColumn.HeaderText = "MaTS";
            this.maTSDataGridViewTextBoxColumn.Name = "maTSDataGridViewTextBoxColumn";
            // 
            // tenTSDataGridViewTextBoxColumn
            // 
            this.tenTSDataGridViewTextBoxColumn.DataPropertyName = "TenTS";
            this.tenTSDataGridViewTextBoxColumn.HeaderText = "TenTS";
            this.tenTSDataGridViewTextBoxColumn.Name = "tenTSDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            // 
            // hinhAnhDataGridViewImageColumn
            // 
            this.hinhAnhDataGridViewImageColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
            // 
            // trangSucBindingSource
            // 
            this.trangSucBindingSource.DataMember = "TrangSuc";
            this.trangSucBindingSource.DataSource = this.dataSetTrangSuc;
            // 
            // dataSetTrangSuc
            // 
            this.dataSetTrangSuc.DataSetName = "DataSetTrangSuc";
            this.dataSetTrangSuc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(295, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "QUẢN LÝ TRANG SỨC";
            // 
            // trangSucTableAdapter
            // 
            this.trangSucTableAdapter.ClearBeforeFill = true;
            // 
            // btthem
            // 
            this.btthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthem.ImageOptions.Image")));
            this.btthem.Location = new System.Drawing.Point(217, 205);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 35);
            this.btthem.TabIndex = 9;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btxoa.ImageOptions.Image")));
            this.btxoa.Location = new System.Drawing.Point(298, 205);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 35);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btsua.ImageOptions.Image")));
            this.btsua.Location = new System.Drawing.Point(379, 205);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 35);
            this.btsua.TabIndex = 10;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // hinhanh
            // 
            this.hinhanh.Image = ((System.Drawing.Image)(resources.GetObject("hinhanh.Image")));
            this.hinhanh.Location = new System.Drawing.Point(603, 76);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(135, 109);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 12;
            this.hinhanh.TabStop = false;
            this.hinhanh.Click += new System.EventHandler(this.hinhanh_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(73, 66);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(192, 33);
            this.bunifuMaterialTextbox1.TabIndex = 13;
            this.bunifuMaterialTextbox1.Text = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuong.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoLuong.HintText = "";
            this.txtSoLuong.isPassword = false;
            this.txtSoLuong.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSoLuong.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoLuong.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSoLuong.LineThickness = 3;
            this.txtSoLuong.Location = new System.Drawing.Point(73, 139);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(192, 33);
            this.txtSoLuong.TabIndex = 14;
            this.txtSoLuong.Text = "Nhập số lượng vào";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMaLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaLoai.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaLoai.HintText = "";
            this.txtMaLoai.isPassword = false;
            this.txtMaLoai.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaLoai.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaLoai.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaLoai.LineThickness = 3;
            this.txtMaLoai.Location = new System.Drawing.Point(364, 139);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(192, 33);
            this.txtMaLoai.TabIndex = 15;
            this.txtMaLoai.Text = "Nhập mã loại trang sức";
            this.txtMaLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonVi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonVi.HintForeColor = System.Drawing.Color.Empty;
            this.txtDonVi.HintText = "";
            this.txtDonVi.isPassword = false;
            this.txtDonVi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDonVi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDonVi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDonVi.LineThickness = 3;
            this.txtDonVi.Location = new System.Drawing.Point(364, 107);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(192, 33);
            this.txtDonVi.TabIndex = 16;
            this.txtDonVi.Text = "Nhập đơn vị nhập hàng";
            this.txtDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox5.HintText = "";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(73, 107);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(192, 33);
            this.bunifuMaterialTextbox5.TabIndex = 17;
            this.bunifuMaterialTextbox5.Text = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonGia.HintForeColor = System.Drawing.Color.Empty;
            this.txtDonGia.HintText = "";
            this.txtDonGia.isPassword = false;
            this.txtDonGia.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDonGia.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDonGia.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDonGia.LineThickness = 3;
            this.txtDonGia.Location = new System.Drawing.Point(364, 68);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(192, 33);
            this.txtDonGia.TabIndex = 19;
            this.txtDonGia.Text = "Nhập đơn giá 1 chiếc";
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 76);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(57, 23);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Mã TS:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(9, 116);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 24);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Tên TS:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 149);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(60, 23);
            this.bunifuCustomLabel3.TabIndex = 22;
            this.bunifuCustomLabel3.Text = "Số Lượng:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(307, 76);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(50, 24);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "Đơn Giá:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(307, 125);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(50, 24);
            this.bunifuCustomLabel5.TabIndex = 24;
            this.bunifuCustomLabel5.Text = "Đơn Vị:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(307, 148);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(50, 24);
            this.bunifuCustomLabel6.TabIndex = 25;
            this.bunifuCustomLabel6.Text = "Mã Loại:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(641, 198);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(58, 33);
            this.bunifuCustomLabel7.TabIndex = 26;
            this.bunifuCustomLabel7.Text = "Hình Ảnh";
            // 
            // txtMaTS
            // 
            this.txtMaTS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMaTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaTS.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaTS.HintText = "";
            this.txtMaTS.isPassword = false;
            this.txtMaTS.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaTS.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaTS.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaTS.LineThickness = 3;
            this.txtMaTS.Location = new System.Drawing.Point(73, 68);
            this.txtMaTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.Size = new System.Drawing.Size(192, 33);
            this.txtMaTS.TabIndex = 13;
            this.txtMaTS.Text = "Nhập mã trang sức";
            this.txtMaTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTenTS
            // 
            this.txtTenTS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenTS.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenTS.HintText = "";
            this.txtTenTS.isPassword = false;
            this.txtTenTS.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTenTS.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenTS.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTenTS.LineThickness = 3;
            this.txtTenTS.Location = new System.Drawing.Point(73, 107);
            this.txtTenTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.Size = new System.Drawing.Size(192, 33);
            this.txtTenTS.TabIndex = 17;
            this.txtTenTS.Text = "Nhập tên trang sức";
            this.txtTenTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(307, 116);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(50, 24);
            this.bunifuCustomLabel8.TabIndex = 24;
            this.bunifuCustomLabel8.Text = "Đơn Vị:";
            // 
            // QuanLyTrangSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 459);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenTS);
            this.Controls.Add(this.bunifuMaterialTextbox5);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.txtMaTS);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.hinhanh);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyTrangSuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTrangSuc";
            this.Load += new System.EventHandler(this.QuanLyTrangSuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangSucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrangSuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private DataSetTrangSuc dataSetTrangSuc;
        private System.Windows.Forms.BindingSource trangSucBindingSource;
        private DataSetTrangSucTableAdapters.TrangSucTableAdapter trangSucTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private DevExpress.XtraEditors.SimpleButton btxoa;
        private DevExpress.XtraEditors.SimpleButton btsua;
        private System.Windows.Forms.PictureBox hinhanh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoLuong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaLoai;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDonVi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDonGia;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaTS;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenTS;
        private System.Windows.Forms.OpenFileDialog openFile;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
    }
}