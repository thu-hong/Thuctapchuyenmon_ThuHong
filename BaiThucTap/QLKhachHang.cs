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
            TextWriter writer = new StreamWriter(@"C:\Users\Hong\Documents\NhanVien.txt");
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
            KhachHang kh = new KhachHang();
            kh.MaKH = txtmakh.Text;
            kh.TenKH = txttenkh.Text;
            kh.SDT = txtsdt.Text;
            kh.DiaChi = txtdiachi.Text;
            kh.Email = txtemail.Text;
            trangsuc.KhachHangs.Add(kh);
            trangsuc.SaveChanges();
            dataGridView1.DataSource = trangsuc.KhachHangs.ToList();
        }

        private void btsua1_Click(object sender, EventArgs e)
        {

        }

        private void bttimkiem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenkh.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trangsuc.KhachHangs.ToList();
        }
    }
    
}
