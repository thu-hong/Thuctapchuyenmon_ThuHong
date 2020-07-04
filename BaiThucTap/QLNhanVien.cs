using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucTap
{
    public partial class QLNhanVien : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trangsuc.dsnhanvien().ToList();
            List<ChucVu> ds_chucvu = trangsuc.ChucVus.ToList();
            cbchucvu.DisplayMember = "TenCV";
            cbchucvu.ValueMember = "MaCV";
            cbchucvu.DataSource = ds_chucvu;
        }

        private void btxoa1_Click(object sender, EventArgs e)
        {
            NhanVien nv = trangsuc.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
            trangsuc.NhanViens.Remove(nv);
            trangsuc.SaveChanges();
            dataGridView1.DataSource = trangsuc.dsnhanvien().ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
            {
                CheckboxNam.Checked = true;
                CheckboxNu.Checked = false;
            }
            else
            {
                CheckboxNu.Checked = true;
                CheckboxNam.Checked = false;
            }
            txtCMND.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbchucvu.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btthem1_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            if (!kiemtramanv())
                return;
            NhanVien nv = new NhanVien(); 
            nv.MaNV = txtMaNV.Text;
            nv.MaCV = cbchucvu.SelectedValue.ToString();
            nv.TenNV = txtTenNV.Text;
            if (CheckboxNu.Checked)
                nv.GioiTinh = true;
            else
                nv.GioiTinh = false;
            nv.CMND = Int32.Parse(txtCMND.Text);
            nv.DiaChi = txtDiaChi.Text;
            nv.SDT = txtSDT.Text;
            Console.WriteLine("insert into Nhanvien values(" + nv.MaNV + "," + nv.TenNV + "," + nv.GioiTinh + "," + nv.CMND + "," + nv.DiaChi + "," + nv.MaCV + ")");
            trangsuc.NhanViens.Add(nv);
            trangsuc.SaveChanges();
            dataGridView1.DataSource = trangsuc.dsnhanvien().ToList();

        }
        public bool kiemtramanv()
        {
            NhanVien nv = trangsuc.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
            if (nv != null)
            {
                MessageBox.Show("Mã nhân viên đã bị trùng !!!");
                return false;
            }
            return true;
        }
        public bool kiemtra()
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn Chưa điền đủ thông tin.Vui lòng nhập đủ thông tin!");
                return false;
            }
            if (!CheckboxNu.Checked && !CheckboxNam.Checked)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
                return false;
            }
            try
            {
                int sdt = Int32.Parse(txtSDT.Text);
                int cmnd = Int32.Parse(txtCMND.Text);
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu không đúng. Nó là kiểu số nguyên!");
                return false;
            }
            return true;

        }

        private void btsua1_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            NhanVien nv = trangsuc.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
            if (nv != null)
            {
                nv.TenNV = txtTenNV.Text;
                if (CheckboxNu.Checked)
                    nv.GioiTinh = true;
                else
                    nv.GioiTinh = false;
                nv.CMND = Int32.Parse(txtCMND.Text);
                nv.DiaChi = txtDiaChi.Text;
                nv.SDT = txtSDT.Text;
                nv.MaCV = trangsuc.ChucVus.FirstOrDefault(p => p.TenCV == cbchucvu.SelectedItem.ToString()).MaCV;
                trangsuc.SaveChanges();
                dataGridView1.DataSource = trangsuc.dsnhanvien().ToList();

            }
        }

        private void bttimkiem1_Click(object sender, EventArgs e)
        {
            List<dsnhanvien_Result> ds_nhanvien = trangsuc.dsnhanvien().Where(p => p.MaNV == txtmatim.Text).ToList();
            if (ds_nhanvien.Count == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại !!");
                return;
            }
            dataGridView1.DataSource = ds_nhanvien;
        }
    }
}
