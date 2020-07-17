namespace BaiThucTap
{
    partial class BaoCaoTheoNgay
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dttheongay1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhthungay = new BaiThucTap.danhthungay();
            this.dttheothang1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dttheothang = new BaiThucTap.dttheothang();
            this.dttheongayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dttheongay1TableAdapter = new BaiThucTap.danhthungayTableAdapters.dttheongay1TableAdapter();
            this.dttheothang1TableAdapter = new BaiThucTap.dttheothangTableAdapters.dttheothang1TableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dttheongay1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhthungay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttheothang1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttheothang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttheongayBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dttheongay1BindingSource
            // 
            this.dttheongay1BindingSource.DataMember = "dttheongay1";
            this.dttheongay1BindingSource.DataSource = this.danhthungay;
            // 
            // danhthungay
            // 
            this.danhthungay.DataSetName = "danhthungay";
            this.danhthungay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dttheothang1BindingSource
            // 
            this.dttheothang1BindingSource.DataMember = "dttheothang1";
            this.dttheothang1BindingSource.DataSource = this.dttheothang;
            // 
            // dttheothang
            // 
            this.dttheothang.DataSetName = "dttheothang";
            this.dttheothang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dttheongayBindingSource
            // 
            this.dttheongayBindingSource.DataMember = "dttheongay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(391, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(3, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dttheongay1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BaiThucTap.RPdanhthutheongay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(935, 259);
            this.reportViewer1.TabIndex = 0;
            // 
            // dttheongay1TableAdapter
            // 
            this.dttheongay1TableAdapter.ClearBeforeFill = true;
            // 
            // dttheothang1TableAdapter
            // 
            this.dttheothang1TableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(338, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(285, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Báo Cáo Doanh Thu Theo Ngày";
            // 
            // BaoCaoTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaoCaoTheoNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCaoTheoNgay";
            this.Load += new System.EventHandler(this.BaoCaoTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dttheongay1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhthungay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttheothang1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttheothang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttheongayBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource dttheongayBindingSource;
       // private DanhThuTheoNgay DanhThuTheoNgay;
        //private DanhThuTheoNgayTableAdapters.dttheongayTableAdapter dttheongayTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dttheongay1BindingSource;
        private danhthungay danhthungay;
        private danhthungayTableAdapters.dttheongay1TableAdapter dttheongay1TableAdapter;
        private System.Windows.Forms.BindingSource dttheothang1BindingSource;
        private dttheothang dttheothang;
        private dttheothangTableAdapters.dttheothang1TableAdapter dttheothang1TableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}