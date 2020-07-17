namespace BaiThucTap
{
    partial class NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataSetchitietphieunhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetchitietphieunhap = new BaiThucTap.DataSetchitietphieunhap();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.CbLoai = new System.Windows.Forms.ComboBox();
            this.txtdonvi = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cbMaPN = new System.Windows.Forms.ComboBox();
            this.CbMaTS = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chiTietPNTableAdapter = new BaiThucTap.DataSetchitietphieunhapTableAdapters.ChiTietPNTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chiTietPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetchitietphieunhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetchitietphieunhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPNDataGridViewTextBoxColumn,
            this.maTSDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.xoa});
            this.dataGridView1.DataSource = this.dataSetchitietphieunhapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(322, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 310);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maPNDataGridViewTextBoxColumn
            // 
            this.maPNDataGridViewTextBoxColumn.DataPropertyName = "MaPN";
            this.maPNDataGridViewTextBoxColumn.HeaderText = "MaPN";
            this.maPNDataGridViewTextBoxColumn.Name = "maPNDataGridViewTextBoxColumn";
            // 
            // maTSDataGridViewTextBoxColumn
            // 
            this.maTSDataGridViewTextBoxColumn.DataPropertyName = "MaTS";
            this.maTSDataGridViewTextBoxColumn.HeaderText = "MaTS";
            this.maTSDataGridViewTextBoxColumn.Name = "maTSDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            // 
            // dataSetchitietphieunhapBindingSource
            // 
            this.dataSetchitietphieunhapBindingSource.DataMember = "ChiTietPN";
            this.dataSetchitietphieunhapBindingSource.DataSource = this.dataSetchitietphieunhap;
            // 
            // dataSetchitietphieunhap
            // 
            this.dataSetchitietphieunhap.DataSetName = "DataSetchitietphieunhap";
            this.dataSetchitietphieunhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(111, 168);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(121, 20);
            this.txtgianhap.TabIndex = 54;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(111, 132);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(121, 20);
            this.txtsoluong.TabIndex = 55;
            // 
            // CbLoai
            // 
            this.CbLoai.FormattingEnabled = true;
            this.CbLoai.Location = new System.Drawing.Point(111, 95);
            this.CbLoai.Name = "CbLoai";
            this.CbLoai.Size = new System.Drawing.Size(121, 21);
            this.CbLoai.TabIndex = 58;
            // 
            // txtdonvi
            // 
            this.txtdonvi.Location = new System.Drawing.Point(111, 206);
            this.txtdonvi.Name = "txtdonvi";
            this.txtdonvi.Size = new System.Drawing.Size(121, 20);
            this.txtdonvi.TabIndex = 60;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(111, 254);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 39);
            this.simpleButton3.TabIndex = 63;
            this.simpleButton3.Text = "Thêm";
            this.simpleButton3.Click += new System.EventHandler(this.btthem_Click);
            // 
            // cbMaPN
            // 
            this.cbMaPN.FormattingEnabled = true;
            this.cbMaPN.Location = new System.Drawing.Point(112, 22);
            this.cbMaPN.Name = "cbMaPN";
            this.cbMaPN.Size = new System.Drawing.Size(121, 21);
            this.cbMaPN.TabIndex = 71;
            // 
            // CbMaTS
            // 
            this.CbMaTS.FormattingEnabled = true;
            this.CbMaTS.Location = new System.Drawing.Point(112, 57);
            this.CbMaTS.Name = "CbMaTS";
            this.CbMaTS.Size = new System.Drawing.Size(121, 21);
            this.CbMaTS.TabIndex = 72;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.CbMaTS);
            this.groupBox2.Controls.Add(this.cbMaPN);
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Controls.Add(this.txtdonvi);
            this.groupBox2.Controls.Add(this.CbLoai);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.txtgianhap);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 310);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhập hàng";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(56, 213);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 13);
            this.labelControl8.TabIndex = 79;
            this.labelControl8.Text = "Đơn Vị :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(44, 175);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 78;
            this.labelControl7.Text = "Giá Nhập :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(39, 135);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 13);
            this.labelControl6.TabIndex = 77;
            this.labelControl6.Text = "Số Lượng :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 76;
            this.labelControl5.Text = "Loại Trang Sức :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 65);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 75;
            this.labelControl4.Text = "Mã Trang Sức :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(104, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 13);
            this.labelControl3.TabIndex = 74;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 73;
            this.labelControl2.Text = "Mã Phiếu Nhập : ";
            // 
            // chiTietPNTableAdapter
            // 
            this.chiTietPNTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(396, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 22);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "NHẬP HÀNG";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1114, 392);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetchitietphieunhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetchitietphieunhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPNBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ComboBox CbLoai;
        private System.Windows.Forms.TextBox txtdonvi;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.ComboBox cbMaPN;
        private System.Windows.Forms.ComboBox CbMaTS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource dataSetchitietphieunhapBindingSource;
        private DataSetchitietphieunhap dataSetchitietphieunhap;
        private DataSetchitietphieunhapTableAdapters.ChiTietPNTableAdapter chiTietPNTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource chiTietPNBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}