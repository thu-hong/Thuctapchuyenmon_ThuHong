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
    public partial class Login : Form
    {
        public class tranferData
        {

        }
        public Login()
        {
            InitializeComponent();  
        }
        public class maquaform
        {
            static public string manv;
        }
        private void btdangnhap_Click(object sender, EventArgs e)
        {
            using (quanlytrangsucEntities1 trangsuc= new quanlytrangsucEntities1())
            {
                List<DangNhap> list = trangsuc.DangNhaps.ToList();
                
                DangNhap dn = trangsuc.DangNhaps.FirstOrDefault(p => p.UserName.Trim() == txtten.Text && p.PassWord.Trim() == txtmatkhau.Text && p.MaNV.Trim()==txtMaNV.Text );
                if (dn != null)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    maquaform.manv = txtMaNV.Text;
                    TrangChu f = new TrangChu();  
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đăng nhập hoặc mật khẩu không chính xác!!!");

                }
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
            if (Checkbox1.Checked == true)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtMaNV.Select();
        }
    }
}
