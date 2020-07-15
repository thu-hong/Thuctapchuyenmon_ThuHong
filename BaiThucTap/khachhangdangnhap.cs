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
    public partial class khachhangdangnhap : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public khachhangdangnhap()
        {
            InitializeComponent();
        }
        public class tenquaform
        {
            static public string tenkh;
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            List<KhachHang> list= trangsuc.KhachHangs.ToList();
            KhachHang kh = trangsuc.KhachHangs.FirstOrDefault(p => p.TenKH.Trim() == txtten.Text&& p.Email.Trim() == txtmatkhau.Text);
            if(kh != null)
            {
                MessageBox.Show("Đăng nhập thành công.");
                tenquaform.tenkh = txtten.Text;
                Client f = new Client();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Khách hàng đăng nhập không thành công.");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult drl = MessageBox.Show("Chọn Yes No?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Checkbox1_OnChange(object sender, EventArgs e)
        {
            if (Checkbox1.Checked == false)
            {
                txtmatkhau.UseSystemPasswordChar = true;

            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
        }

        private void khachhangdangnhap_Load(object sender, EventArgs e)
        {
            txtten.Select();
        }
    }
}
