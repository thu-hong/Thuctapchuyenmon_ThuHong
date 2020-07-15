namespace BaiThucTap
{
    partial class HangTon
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hangkho = new BaiThucTap.hangkho();
            this.hangtonkhoaaaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangtonkhoaaaTableAdapter = new BaiThucTap.hangkhoTableAdapters.hangtonkhoaaaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangtonkhoaaaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hangtonkhoaaaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BaiThucTap.hangtonkho11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(34, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(705, 297);
            this.reportViewer1.TabIndex = 1;
            // 
            // hangkho
            // 
            this.hangkho.DataSetName = "hangkho";
            this.hangkho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangtonkhoaaaBindingSource
            // 
            this.hangtonkhoaaaBindingSource.DataMember = "hangtonkhoaaa";
            this.hangtonkhoaaaBindingSource.DataSource = this.hangkho;
            // 
            // hangtonkhoaaaTableAdapter
            // 
            this.hangtonkhoaaaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Tháng";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(167, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "TÌM SỐ LƯỢNG TỒN KHO CỦA THÁNG ";
            // 
            // HangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "HangTon";
            this.Text = "HangTon";
            this.Load += new System.EventHandler(this.HangTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangtonkhoaaaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hangtonkhoaaaBindingSource;
        private hangkho hangkho;
        private hangkhoTableAdapters.hangtonkhoaaaTableAdapter hangtonkhoaaaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}