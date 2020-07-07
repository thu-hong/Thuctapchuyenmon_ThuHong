using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucTap
{
    public partial class QuanLyTrangSuc : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public QuanLyTrangSuc()
        {
            InitializeComponent();
        }

        private void QuanLyTrangSuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTrangSuc.TrangSuc' table. You can move, or remove it, as needed.
            this.trangSucTableAdapter.Fill(this.dataSetTrangSuc.TrangSuc);

        }
        private void themsanpham()
        {
            TrangSuc ts = new TrangSuc();
            ts.MaTS = txtMaTS.Text;
            ts.TenTS = txtTenTS.Text;
            ts.SoLuong = Int32.Parse(txtSoLuong.Text);
            ts.DonGia = float.Parse(txtDonGia.Text);
            ts.DonVi = txtDonVi.Text;
            ts.MaLoai = txtMaLoai.Text;
            //Byte[] img = ts.HinhAnh;
            //if (img != null)
            //{
            //    using(MemoryStream stream = new MemoryStream(img))
            //    {
            //        Image returnImage = Image.FromStream(stream);
            //        hinhanh.Image = returnImage;
            //    }
            //}
           
            trangsuc.TrangSucs.Add(ts);
            trangsuc.SaveChanges();
            MessageBox.Show("Thêm thành công.");
            dataGridView1.DataSource = trangsuc.TrangSucs.ToList();


        }

        private void btthem_Click(object sender, EventArgs e)
        {
            themsanpham();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTS.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenTS.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDonVi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMaLoai.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            hinhanh.Image = Image.FromStream(ms);
           
        }
       // string img = "";
        private void hinhanh_Click(object sender, EventArgs e)
        {
            //openFile.ShowDialog();
            //string file = openFile.FileName;
            //if (string.IsNullOrEmpty(file))
            //    return;
            //if (file == "openFileDialog1")
            //    return;
            //else
            //{
            //    img = openFile.FileName.ToString();
            //    Image myimage = Image.FromFile(file);
            //    hinhanh.Image = myimage;

            //}
            LoadHinhTrangSuc f = new LoadHinhTrangSuc();
            f.ShowDialog();
            
        }

        byte[] a;
        private void btxoa_Click(object sender, EventArgs e)
        {
            TrangSuc ts = trangsuc.TrangSucs.FirstOrDefault(p => p.MaTS == txtMaTS.Text);
            trangsuc.TrangSucs.Remove(ts);
            trangsuc.SaveChanges();
            using (Stream stream = new MemoryStream(a))
            {
                hinhanh.Image = Image.FromStream(stream);
                stream.Dispose();
            }
            MessageBox.Show("Xóa Thành công");
            dataGridView1.DataSource = trangsuc.TrangSucs.ToList();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            TrangSuc ts = trangsuc.TrangSucs.FirstOrDefault(p => p.MaTS == txtMaTS.Text);
            ts.TenTS = txtTenTS.Text;
            ts.SoLuong = Int32.Parse(txtSoLuong.Text);
            ts.DonGia = float.Parse(txtDonGia.Text);
            ts.DonVi = txtDonVi.Text;
            ts.MaLoai = txtMaLoai.Text;
            trangsuc.SaveChanges();
            MessageBox.Show("Sửa thành công.");
            dataGridView1.DataSource = trangsuc.TrangSucs.ToList();

        }


    }
}
