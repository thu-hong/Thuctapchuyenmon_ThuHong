namespace BaiThucTap
{
    partial class LoadHinhTrangSuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTS = new System.Windows.Forms.TextBox();
            this.loadhinh = new System.Windows.Forms.PictureBox();
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
            this.btnSua = new System.Windows.Forms.Button();
            this.trangSucTableAdapter = new BaiThucTap.DataSetTrangSucTableAdapters.TrangSucTableAdapter();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.loadhinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangSucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrangSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Trang Sức";
            // 
            // txtMaTS
            // 
            this.txtMaTS.Location = new System.Drawing.Point(102, 10);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.Size = new System.Drawing.Size(75, 20);
            this.txtMaTS.TabIndex = 2;
            // 
            // loadhinh
            // 
            this.loadhinh.BackColor = System.Drawing.Color.White;
            this.loadhinh.Location = new System.Drawing.Point(232, 10);
            this.loadhinh.Name = "loadhinh";
            this.loadhinh.Size = new System.Drawing.Size(171, 130);
            this.loadhinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadhinh.TabIndex = 3;
            this.loadhinh.TabStop = false;
            this.loadhinh.Click += new System.EventHandler(this.loadhinh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 100);
            this.dataGridView1.TabIndex = 4;
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
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(102, 99);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // trangSucTableAdapter
            // 
            this.trangSucTableAdapter.ClearBeforeFill = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // LoadHinhTrangSuc
            // 
            this.AcceptButton = this.btnSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(751, 275);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadhinh);
            this.Controls.Add(this.txtMaTS);
            this.Controls.Add(this.label1);
            this.Name = "LoadHinhTrangSuc";
            this.Text = "LoadHinhTrangSuc";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoadHinhTrangSuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadhinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangSucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrangSuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTS;
        private System.Windows.Forms.PictureBox loadhinh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSua;
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
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}