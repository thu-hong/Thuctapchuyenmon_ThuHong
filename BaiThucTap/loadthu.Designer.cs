namespace BaiThucTap
{
    partial class loadthu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadthu));
            this.btThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matrangsuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentrangsuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaitrangsuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbchuathanhtoan = new System.Windows.Forms.ComboBox();
            this.cbLoaiTS = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenTS = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtUuDai = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.panelAnh = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDanhMuc = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMua = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.panelMua.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(208, 432);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btThanhToan.TabIndex = 18;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(116, 432);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 17;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(26, 432);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrangsuc,
            this.tentrangsuc,
            this.loaitrangsuc,
            this.soluong,
            this.dongia,
            this.thanhtien,
            this.xoa});
            this.dataGridView1.Location = new System.Drawing.Point(6, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(503, 215);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matrangsuc
            // 
            this.matrangsuc.HeaderText = "Mã Trang Sức";
            this.matrangsuc.Name = "matrangsuc";
            this.matrangsuc.ReadOnly = true;
            // 
            // tentrangsuc
            // 
            this.tentrangsuc.HeaderText = "Tên Trang Sức";
            this.tentrangsuc.Name = "tentrangsuc";
            this.tentrangsuc.ReadOnly = true;
            // 
            // loaitrangsuc
            // 
            this.loaitrangsuc.HeaderText = "Loại TS";
            this.loaitrangsuc.Name = "loaitrangsuc";
            this.loaitrangsuc.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(399, 86);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 14;
            // 
            // cbchuathanhtoan
            // 
            this.cbchuathanhtoan.DisplayMember = "MaHD";
            this.cbchuathanhtoan.FormattingEnabled = true;
            this.cbchuathanhtoan.Location = new System.Drawing.Point(399, 33);
            this.cbchuathanhtoan.Name = "cbchuathanhtoan";
            this.cbchuathanhtoan.Size = new System.Drawing.Size(100, 21);
            this.cbchuathanhtoan.TabIndex = 13;
            this.cbchuathanhtoan.ValueMember = "MaHD";
            this.cbchuathanhtoan.SelectedIndexChanged += new System.EventHandler(this.cbchuathanhtoan_SelectedIndexChanged);
            // 
            // cbLoaiTS
            // 
            this.cbLoaiTS.FormattingEnabled = true;
            this.cbLoaiTS.Location = new System.Drawing.Point(85, 91);
            this.cbLoaiTS.Name = "cbLoaiTS";
            this.cbLoaiTS.Size = new System.Drawing.Size(100, 21);
            this.cbLoaiTS.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ưu đãi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hóa đơn chưa hoàn thành:";
            // 
            // txtTenTS
            // 
            this.txtTenTS.Enabled = false;
            this.txtTenTS.Location = new System.Drawing.Point(85, 56);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.Size = new System.Drawing.Size(100, 20);
            this.txtTenTS.TabIndex = 9;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(85, 129);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtUuDai
            // 
            this.txtUuDai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUuDai.Location = new System.Drawing.Point(399, 60);
            this.txtUuDai.Name = "txtUuDai";
            this.txtUuDai.Size = new System.Drawing.Size(100, 20);
            this.txtUuDai.TabIndex = 7;
            this.txtUuDai.Text = "0";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(85, 21);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 5;
            // 
            // panelAnh
            // 
            this.panelAnh.AutoScroll = true;
            this.panelAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnh.Location = new System.Drawing.Point(15, 12);
            this.panelAnh.Name = "panelAnh";
            this.panelAnh.Size = new System.Drawing.Size(599, 431);
            this.panelAnh.TabIndex = 6;
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.AutoScroll = true;
            this.panelDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDanhMuc.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.panelDanhMuc.Location = new System.Drawing.Point(12, 449);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(602, 93);
            this.panelDanhMuc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên trang sức:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loai trang sức:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // panelMua
            // 
            this.panelMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMua.Controls.Add(this.btThanhToan);
            this.panelMua.Controls.Add(this.btLuu);
            this.panelMua.Controls.Add(this.btThem);
            this.panelMua.Controls.Add(this.dataGridView1);
            this.panelMua.Controls.Add(this.txtSoLuong);
            this.panelMua.Controls.Add(this.cbchuathanhtoan);
            this.panelMua.Controls.Add(this.cbLoaiTS);
            this.panelMua.Controls.Add(this.label7);
            this.panelMua.Controls.Add(this.label6);
            this.panelMua.Controls.Add(this.txtTenTS);
            this.panelMua.Controls.Add(this.txtDonGia);
            this.panelMua.Controls.Add(this.txtUuDai);
            this.panelMua.Controls.Add(this.txtMaHD);
            this.panelMua.Controls.Add(this.label5);
            this.panelMua.Controls.Add(this.label4);
            this.panelMua.Controls.Add(this.label3);
            this.panelMua.Controls.Add(this.label2);
            this.panelMua.Controls.Add(this.label1);
            this.panelMua.Location = new System.Drawing.Point(620, 12);
            this.panelMua.Name = "panelMua";
            this.panelMua.Size = new System.Drawing.Size(509, 530);
            this.panelMua.TabIndex = 4;
            // 
            // loadthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1140, 558);
            this.Controls.Add(this.panelAnh);
            this.Controls.Add(this.panelDanhMuc);
            this.Controls.Add(this.panelMua);
            this.Name = "loadthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadthu";
            this.Load += new System.EventHandler(this.loadthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.panelMua.ResumeLayout(false);
            this.panelMua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btThanhToan;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.ComboBox cbchuathanhtoan;
        private System.Windows.Forms.ComboBox cbLoaiTS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenTS;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtUuDai;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.FlowLayoutPanel panelAnh;
        private System.Windows.Forms.FlowLayoutPanel panelDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrangsuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentrangsuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaitrangsuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}