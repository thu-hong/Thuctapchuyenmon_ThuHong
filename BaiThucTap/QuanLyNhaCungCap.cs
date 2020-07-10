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
    public partial class QuanLyNhaCungCap : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public QuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            trangsuc.themncc(tenncc, diachi, int.Parse(sdt));
            MessageBox.Show("Đã Thêm NCC");
            QuanLyNhaCungCap_Load(sender, e);
            
        }
        string mancc1 = "";

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (mancc1 == "")
            {
                MessageBox.Show("Hãy chọn nhà cung cấp mà  bạn cần sửa.");
                return;
            }
            NhaCungCap ncc = trangsuc.NhaCungCaps.FirstOrDefault(p => p.MaNCC == mancc1);
            ncc.TenNCC = txttenncc.Text;
            ncc.DiaChi = txtdiachi.Text;
            ncc.SDT = txtsdt.Text;
            trangsuc.SaveChanges();
            MessageBox.Show("Đã sửa");
            QuanLyNhaCungCap_Load(sender, e);

        }

        private void QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridview1.AutoGenerateColumns = false;
            Console.WriteLine(trangsuc.NhaCungCaps.ToList().Count);
            dataGridview1.DataSource = trangsuc.NhaCungCaps.ToList();

        }

       

        private void dataGridview1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            mancc1 = dataGridview1.CurrentRow.Cells[0].Value.ToString();
            txttenncc.Text = dataGridview1.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dataGridview1.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dataGridview1.CurrentRow.Cells[3].Value.ToString(); 
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    trangsuc.xoancc(mancc1);
                    MessageBox.Show("Đã xóa ");
                    QuanLyNhaCungCap_Load(sender, e);
                }
            }
        }
    }
}
