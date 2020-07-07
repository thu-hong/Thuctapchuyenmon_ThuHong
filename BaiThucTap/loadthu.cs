using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.IO;
using DevExpress.XtraEditors.Filtering.Templates;

namespace BaiThucTap
{
    public partial class loadthu : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public loadthu()
        {
            InitializeComponent();
        }
        private void Loadtrangsuc(string v)
        {
            panelAnh.Controls.Clear();
            int i = 0;
            List<TrangSuc> ts = trangsuc.TrangSucs.Where(p => p.MaLoai == v).ToList();
            int dem = ts.Count % 3;
            int count = ts.Count / 3;
            foreach (var item in ts)
            {
                BunifuImageButton img = new BunifuImageButton();
                img.Name = item.MaTS.ToString();
                img.Size = new System.Drawing.Size(182, 138);
                img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                Byte[] hinhanh = item.HinhAnh;
                if (hinhanh != null)
                {
                    using (MemoryStream stream = new MemoryStream(hinhanh))
                    {
                        Image returnImage = Image.FromStream(stream);
                        img.Image = returnImage;
                    }
                    
                }
                img.BorderStyle = BorderStyle.FixedSingle;
                img.TabIndex = i;
                img.TabStop = false;
                img.Zoom = 10;
                panelAnh.Controls.Add(img);
                img.Click += new EventHandler(chonhinhanh);
                i++;
                if (i % 3 == 0)
                {
                    for (int j = i - 3; j < i; j++)
                    {
                        TextBox tb = new TextBox();
                        tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        tb.Size = new System.Drawing.Size(182, 13);
                        tb.Enabled = false;
                        tb.BackColor = Color.White;
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                        tb.Text = ts[j].TenTS;
                        panelAnh.Controls.Add(tb);
                    }
                }
            }
            if (dem < 3)
            {
                for (int k = 0; k < 3 - dem; k++)
                {
                    Label tb = new Label();
                    tb.Size = new System.Drawing.Size(182, 13);
                    tb.BackColor = Color.White;
                    panelAnh.Controls.Add(tb);
                    tb.Enabled = false;
                }
                for (int j = 0; j < dem; j++)
                {
                    TextBox tb = new TextBox();
                    tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    tb.Size = new System.Drawing.Size(182, 13);
                    tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    tb.Text = ts[3 * count + j].TenTS;
                    panelAnh.Controls.Add(tb);

                }
            }

        }
        string mats = "";

        private void chonhinhanh(object sender, EventArgs e)
        {
            BunifuImageButton img = sender as BunifuImageButton;
            mats = img.Name.ToString();
            TrangSuc ts = trangsuc.TrangSucs.FirstOrDefault(p => p.MaTS == mats);
            cbLoaiTS.SelectedValue = ts.MaLoai;
            txtTenTS.Text = ts.TenTS;
            txtDonGia.Text = ts.DonGia.ToString();


        }
        private void Loadloaitrangsuc()
        {
            List<LoaiTrangSuc> loai = trangsuc.LoaiTrangSucs.ToList();
            cbLoaiTS.DataSource = loai;
            cbLoaiTS.DisplayMember = "TenLoai";
            cbLoaiTS.ValueMember = "MaLoai";

        }

        void Loaddanhmuc()
        {
            panelDanhMuc.Controls.Clear();
            List<LoaiTrangSuc> loai = trangsuc.LoaiTrangSucs.ToList();
            int i = 0;
            foreach(var item in loai)
            {
                BunifuThinButton2 bt = new BunifuThinButton2();
                bt.Size = new System.Drawing.Size(80, 45);
                bt.TabIndex = i;
                bt.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
                bt.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
                bt.IdleFillColor = Color.White;
                bt.IdleForecolor = Color.MidnightBlue;
                bt.IdleLineColor = System.Drawing.Color.LightSkyBlue;
                bt.Text = item.TenLoai.ToUpper();
                bt.Name = item.MaLoai;
                bt.Click += clickChonDanhMuc;
                bt.ButtonText = item.TenLoai.Trim();
                bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                panelDanhMuc.Controls.Add(bt);
                i++;
            }
            List<LoaiTrangSuc> ds = trangsuc.LoaiTrangSucs.ToList();
           

        }
        private void clickChonDanhMuc(object sender , EventArgs e)
        {
            BunifuThinButton2 btn = sender as BunifuThinButton2;
            if (btn.Name.Trim() == "ML01")
            {
                Loadtrangsuc("ML01");

            }
            if (btn.Name.Trim() == "ML02")
            {
                Loadtrangsuc("ML02");

            }
            if (btn.Name.Trim() == "ML03")
            {
                Loadtrangsuc("ML03");

            }
            if (btn.Name.Trim() == "ML04")
            {
                Loadtrangsuc("ML04");

            }
        }
        private  void Loaduudai()
        {
            List<UuDai> uudai = trangsuc.UuDais.ToList();
            foreach(var item in uudai)
            {
                DateTime ngaybd = (DateTime)item.NgayBD;
                DateTime ngaykt = (DateTime)item.NgayKT;
                if (DateTime.Now.Day >= ngaybd.Day && DateTime.Now.Day <= ngaykt.Day && DateTime.Now.Year == ngaybd.Year && DateTime.Now.Month == ngaybd.Month)
                {
                    txtUuDai.Text = item.GiamGia.ToString();
                    return;
                }
            }
        }

        private void loadthu_Load(object sender, EventArgs e)
        {
            Loadloaitrangsuc();
            Loaddanhmuc();
            Loadtrangsuc("ML01");
            dataGridView1.Rows.Clear();
            List<getmahd2_Result> kq = trangsuc.getmahd2().ToList();         
            foreach (var item in kq)
            {
                txtMaHD.Text = kq[0].MaHD;
            }
            Loadhdchuathanhtoan();
            
        }
       
        private void Loadhoadontrangsuc()
        {
            var result = from hd in trangsuc.HoaDons
                         join cthd in trangsuc.ChiTietHDs on hd.MaHD equals cthd.MaHD
                         join ts in trangsuc.TrangSucs on cthd.MaTS equals ts.MaTS
                         select new
                         {
                             cthd.MaTS,
                             ts.TenTS,
                             hd.MaUD,
                             hd.TongTien,
                             hd.TrangThai
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Value == 0)
            {
                MessageBox.Show("Số lượng không thể là 0");
                return;

            }
            float dongia = float.Parse(txtDonGia.Text);
            int soluong = int.Parse(txtSoLuong.Value.ToString());
            int uudai = int.Parse(txtUuDai.Text);
            for(int i=0; i < dataGridView1.Rows.Count; i++)
            {
                string loaitrangsuc = dataGridView1.Rows[i].Cells["loaitrangsuc"].Value.ToString();
                string tentrangsuc = dataGridView1.Rows[i].Cells["tentrangsuc"].Value.ToString();
                if(tentrangsuc == txtTenTS.Text && cbLoaiTS.Text == loaitrangsuc)
                {
                    int sl = int.Parse(dataGridView1.Rows[i].Cells["soluong"].Value.ToString()) + soluong;
                    dataGridView1.Rows[i].Cells["soluong"].Value = sl;
                    dataGridView1.Rows[i].Cells["thanhtien"].Value = sl * dongia;

                    return;
                }
            }
            float tongtien = dongia * soluong;
            dataGridView1.Rows.Add(new object[]  {mats,txtTenTS.Text,cbLoaiTS.Text,txtSoLuong.Value.ToString(),txtDonGia.Text,tongtien });

        }
        public void reset()
        {
            dataGridView1.Rows.Clear();
            cbLoaiTS.SelectedIndex = -1;
            txtDonGia.Text = "0";
            txtTenTS.Text = "";
        }
        public void Loadhdchuathanhtoan()
        {

            List<hdtrangsucchuathanhtoan_Result> hd = trangsuc.hdtrangsucchuathanhtoan().ToList();
            cbchuathanhtoan.DataSource = hd;
            cbchuathanhtoan.DisplayMember = "MaHD";
            cbchuathanhtoan.ValueMember = "MaHD";
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            HoaDon hd = trangsuc.HoaDons.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
            if(hd != null)
            {
                List<ChiTietHD> cthd = trangsuc.ChiTietHDs.Where(p => p.MaHD == txtMaHD.Text).ToList();
                foreach( var item in cthd)
                {
                    trangsuc.ChiTietHDs.Remove(item);
                    trangsuc.SaveChanges();
                }

            }
            else
            {
                hd = new HoaDon();
                hd.MaHD = txtMaHD.Text;
                hd.UserName = "Giám Đốc";
                hd.TGLap = DateTime.Now.Date;
                hd.TrangThai = false;
                trangsuc.HoaDons.Add(hd);
                trangsuc.SaveChanges();
            }
            foreach(DataGridViewRow rows in dataGridView1.Rows)
            {
                ChiTietHD ct = new ChiTietHD();
                string mats = rows.Cells["matrangsuc"].Value.ToString();
                string tents = rows.Cells["tentrangsuc"].Value.ToString();
                int sl = int.Parse(rows.Cells["soluong"].Value.ToString());
                ct.MaHD = txtMaHD.Text;
                ct.MaTS = mats;
                ct.TenTS = tents;
                ct.SoLuongBan = sl;
                trangsuc.ChiTietHDs.Add(ct);
                trangsuc.SaveChanges();
            }
            MessageBox.Show("Lưu thành công!");
            Loadhdchuathanhtoan();
            return;
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            HoaDon hd = trangsuc.HoaDons.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
            hd.TrangThai = true;
            trangsuc.SaveChanges();
            MessageBox.Show("Thanh Toán Thành Công");
            loadthu_Load(sender, e);
            cbchuathanhtoan.Text = null;
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                MessageBox.Show("Đã xóa!!");
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
            }
        }

        private void cbchuathanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtMaHD.Text = cbchuathanhtoan.Text;
            List<ChiTietHD> cthd1 = trangsuc.ChiTietHDs.Where(p => p.MaHD == txtMaHD.Text).ToList();
            foreach (var item in cthd1)
            {
                string maloai = trangsuc.TrangSucs.FirstOrDefault(p => p.MaTS == item.MaTS).MaLoai.ToString();
                string loaitrangsuc = trangsuc.LoaiTrangSucs.FirstOrDefault(p => p.MaLoai == maloai).TenLoai;
                float dongia = (float)trangsuc.TrangSucs.FirstOrDefault(p => p.MaTS == item.MaTS).DonGia;
                float thanhtien = dongia * (float)item.SoLuongBan;
                dataGridView1.Rows.Add(item.MaTS,item.TenTS, loaitrangsuc, item.SoLuongBan, dongia, thanhtien);
            }
        }
    }
}
