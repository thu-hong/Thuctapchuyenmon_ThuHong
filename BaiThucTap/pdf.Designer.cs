namespace BaiThucTap
{
    partial class pdf
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xuatpdf = new System.Windows.Forms.Button();
            this.dataSet1 = new BaiThucTap.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter1 = new BaiThucTap.DataSetHoaDonTableAdapters.HoaDonTableAdapter();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonTableAdapter = new BaiThucTap.DataSet1TableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.tGLapDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn,
            this.maUDDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // xuatpdf
            // 
            this.xuatpdf.Location = new System.Drawing.Point(380, 26);
            this.xuatpdf.Name = "xuatpdf";
            this.xuatpdf.Size = new System.Drawing.Size(75, 23);
            this.xuatpdf.TabIndex = 1;
            this.xuatpdf.Text = "Xuất pdf";
            this.xuatpdf.UseVisualStyleBackColor = true;
            this.xuatpdf.Click += new System.EventHandler(this.xuatpdf_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataMember = "HoaDon";
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            // 
            // hoaDonTableAdapter1
            // 
            this.hoaDonTableAdapter1.ClearBeforeFill = true;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            // 
            // tGLapDataGridViewTextBoxColumn
            // 
            this.tGLapDataGridViewTextBoxColumn.DataPropertyName = "TGLap";
            this.tGLapDataGridViewTextBoxColumn.HeaderText = "TGLap";
            this.tGLapDataGridViewTextBoxColumn.Name = "tGLapDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // trangThaiDataGridViewCheckBoxColumn
            // 
            this.trangThaiDataGridViewCheckBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewCheckBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewCheckBoxColumn.Name = "trangThaiDataGridViewCheckBoxColumn";
            // 
            // maUDDataGridViewTextBoxColumn
            // 
            this.maUDDataGridViewTextBoxColumn.DataPropertyName = "MaUD";
            this.maUDDataGridViewTextBoxColumn.HeaderText = "MaUD";
            this.maUDDataGridViewTextBoxColumn.Name = "maUDDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // pdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuatpdf);
            this.Controls.Add(this.dataGridView1);
            this.Name = "pdf";
            this.Text = "pdf";
            this.Load += new System.EventHandler(this.pdf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button xuatpdf;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSetHoaDonTableAdapters.HoaDonTableAdapter hoaDonTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
    }
}