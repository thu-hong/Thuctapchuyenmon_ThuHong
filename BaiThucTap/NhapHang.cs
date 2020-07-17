using DevExpress.Utils.Extensions;
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
    public partial class NhapHang : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public NhapHang()
        {
            InitializeComponent();
        }

       

        private void NhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetchitietphieunhap.ChiTietPN' table. You can move, or remove it, as needed.
            this.chiTietPNTableAdapter.Fill(this.dataSetchitietphieunhap.ChiTietPN);

            loadPN();
            loadTS();
            loadLoaiTS();

        }
        public void loadPN()
        {
            
            List<PhieuNhap> pn = trangsuc.PhieuNhaps.ToList();
            cbMaPN.DataSource = pn;
            cbMaPN.DisplayMember = "MaPN";
            cbMaPN.ValueMember = "MaPN";
        }
        public void loadTS()
        {
            List<TrangSuc> ts = trangsuc.TrangSucs.ToList();
            CbMaTS.DataSource = ts;
            CbMaTS.DisplayMember = "TenTS";
            CbMaTS.ValueMember = "MaTS";    
        }
        public void loadLoaiTS()
        {
            List<LoaiTrangSuc> loai = trangsuc.LoaiTrangSucs.ToList();
            CbLoai.DataSource = loai;
            CbLoai.DisplayMember = "TenLoai";
            CbLoai.ValueMember = "MaLoai";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            trangsuc.themCTNP(cbMaPN.Text, CbMaTS.SelectedValue.ToString(), Int32.Parse(txtsoluong.Text), Double.Parse(txtgianhap.Text), CbLoai.SelectedValue.ToString(), txtdonvi.Text);
            trangsuc.SaveChanges();
            MessageBox.Show("Đã Thêm");
            NhapHang_Load(sender, e);
          
        } 

        private void btsua_Click(object sender, EventArgs e)
        {
            
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            //NhanVien nv = trangsuc.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
            //trangsuc.NhanViens.Remove(nv);
            //trangsuc.SaveChanges();
            //dataGridView1.DataSource = trangsuc.dsnhanvien().ToList();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Bạn có muốn xóa hoa dơn này không?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mapn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string mats = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    trangsuc.xoactpn1(mapn, mats);
                    MessageBox.Show("Đã xóa!!");
                    trangsuc.SaveChanges();
                    NhapHang_Load(sender, e);
                }
            }
        }
    }
}
