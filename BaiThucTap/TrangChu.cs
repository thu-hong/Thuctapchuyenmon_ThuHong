﻿using DevExpress.XtraBars.Navigation.Accessible;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            else
            {
                QLNhanVien f5 = new QLNhanVien();
                f5.ShowDialog();

            }
        }

        private void QuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q06"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
            else
            {
                QuanLyNhaCungCap f4 = new QuanLyNhaCungCap();
                f4.ShowDialog();
            }

        }

        private void NhapKho_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q07"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
            else
            {
                NhapHang f12 = new NhapHang();
                f12.ShowDialog();
            }
           
        }

        private void TonKho_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q08"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
            else
            {
                HangTon f10 = new HangTon();
                f10.ShowDialog();
            }
        }

        private void DanhThu_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q09"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
            else
            {
                BaoCao f7 = new BaoCao();
                f7.ShowDialog();
                
            }

        }

        private void LienHeGmail_Click(object sender, EventArgs e)
        {
            if (!quyen.Contains("Q10"))
            {
                MessageBox.Show("Bạn Không có quyền");
                return;
            }
            else
            {
                GuiGmail f8 = new GuiGmail();
                f8.ShowDialog();
            }
        }

        private void hinhFb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void hinhZalo_Click(object sender, EventArgs e)
        {
            Process.Start("https://id.zalo.me/");
        }

        public Panel pannelcotrol
        {
            get { return panelcontrol; }
            set { panelcontrol = value; }
        }
        private void QuanLyTrangSuc_Click(object sender, EventArgs e)
        {
            //frmTrangSuc f1 = new frmTrangSuc();
            //f1.Dock = DockStyle.Fill;
            //panelcontrol.Controls.Add(f1);
            loadthu f1 = new loadthu();
            f1.ShowDialog();

        }

        private void QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            QLKhachHang f2 = new QLKhachHang();
            f2.ShowDialog();
        }

        private void LienHe_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            khachhangdangnhap f9 = new khachhangdangnhap();
            f9.ShowDialog();
        }

        private void QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon f11 = new QuanLyHoaDon();
            f11.ShowDialog();
        }
    }
}
