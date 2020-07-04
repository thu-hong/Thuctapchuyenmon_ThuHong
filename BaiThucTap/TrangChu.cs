using DevExpress.XtraBars.Navigation.Accessible;
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
    public partial class TrangChu : Form
    {
       
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public TrangChu()
        {
            InitializeComponent();
        }
       


        string quyen = "";
        private void DongGoiSanPham_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q04"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            lbMaNV.Text = Login.maquaform.manv;
            AccessibleAccordionElement bt= sender as AccessibleAccordionElement;
            List<CTPhanQuyen> dsquyen = trangsuc.CTPhanQuyens.Where(p=>p.MaNV==lbMaNV.Text).ToList();
            foreach(CTPhanQuyen item in dsquyen)
            {
                quyen += item.MaPQ.Trim() + " ";
            }
            
        }

        private void QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q05"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
        }

        private void QuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q06"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
        }

        private void NhapKho_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q07"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
        }

        private void TonKho_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q08"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
        }

        private void DanhThu_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q09"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }

        }

        private void LienHeGmail_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q10"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
        }
    }
}
