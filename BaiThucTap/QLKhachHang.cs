using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaiThucTap
{
    public partial class QLKhachHang : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void btfile_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\Hong\Documents\KhachHang.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                writer.Write(dataGridView1.Rows[i].Cells[4].Value.ToString() + "\n");
            }
            writer.Close();
            MessageBox.Show("Đã nhập vào ok");
        }

        private void btxoa1_Click(object sender, EventArgs e)
        {
            KhachHang kh = trangsuc.KhachHangs.FirstOrDefault(p => p.MaKH == txtmakh.Text);
            trangsuc.KhachHangs.Remove(kh);
            trangsuc.SaveChanges();
            dataGridView1.DataSource = trangsuc.KhachHangs.ToList();
        }

        private void btthem1_Click(object sender, EventArgs e)
        {
            if (!kiemtramakh())
                return;
            if (!kiemtra())
                return;
            KhachHang kh = new KhachHang();
            kh.MaKH = txtmakh.Text;
            kh.TenKH = txttenkh.Text;
            kh.DiaChi = txtdiachi.Text;
            kh.SDT = txtsdt.Text;        
            kh.Email = txtemail.Text;
            trangsuc.KhachHangs.Add(kh);
            trangsuc.SaveChanges();
            dataGridView1.DataSource = trangsuc.KhachHangs.ToList();
        }

        private void btsua1_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            KhachHang kh = trangsuc.KhachHangs.FirstOrDefault(p => p.MaKH == txtmakh.Text);
            if (kh != null)
            {
                kh.TenKH = txttenkh.Text;            
                kh.DiaChi = txtdiachi.Text;
                kh.SDT = txtsdt.Text;
                kh.Email = txtemail.Text;
                trangsuc.SaveChanges();
                dataGridView1.DataSource = trangsuc.KhachHangs.ToList();
            }
        }


        private void bttimkiem1_Click(object sender, EventArgs e)
        {
            List<KhachHang> kh1 = trangsuc.KhachHangs.Where(p => p.SDT == txtnhapmatim.Text).ToList();
            string timKiem = txtnhapmatim.Text.Trim();
            
            if (kh1.Count == 0)
            {
                MessageBox.Show(" SDT  không tồn tại !!");
                return;
            }
            dataGridView1.DataSource = trangsuc.TraCuu_LichSuMua(timKiem).ToList();

            //List<KhachHang> kh1 = trangsuc.KhachHangs.Where(p => p.MaKH == txtnhapmatim.Text).ToList();
            //if (kh1.Count == 0)
            //{
            //    MessageBox.Show(" Mã khách hàng  không tồn tại !!");
            //    return;
            //} 
            //dataGridView1.DataSource = kh1;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            txtmakh.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenkh.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trangsuc.KhachHangs.ToList();
        }

        private void bttrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool kiemtra()
        {
            if (txtmakh.Text == "" || txttenkh.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Bạn Chưa điền đủ thông tin.Vui lòng nhập đủ thông tin!");
                return false;
            }           
           
            return true;

        }
        public bool kiemtramakh()
        {
            KhachHang kh = trangsuc.KhachHangs.FirstOrDefault(p => p.MaKH == txtmakh.Text);
            if (kh != null)
            {
                MessageBox.Show("Mã khách hàng đã bị trùng !!!");
                return false;
            }
            return true;
        }
        public bool kiemsdt()
        {
            KhachHang kh = trangsuc.KhachHangs.FirstOrDefault(p => p.SDT == txtsdt.Text);
            if (kh != null)
            {
                MessageBox.Show("Số điện thoại  đã bị trùng !!!");
                return false;
            }
            return true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsdt_OnValueChanged(object sender, EventArgs e)
        {
          
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
           

        }

        private void btthoat1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chọn Yes No?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            if (!kiemsdt())
                return;
            KhachHang kh = new KhachHang();
            kh.MaKH = txtmakh.Text;
            kh.TenKH = txttenkh.Text;
            kh.DiaChi = txtdiachi.Text;
            kh.SDT = txtsdt.Text;
            kh.Email = txtemail.Text;
            trangsuc.KhachHangs.Add(kh);
            trangsuc.SaveChanges();
            dataGridView1.DataSource = trangsuc.KhachHangs.ToList();

        }

        private void txtnhapmatim_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
