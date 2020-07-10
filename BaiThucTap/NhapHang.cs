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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
          // dataGridView1.DataSource = trangsuc.dsnhanvien().ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttimkiem1_Click(object sender, EventArgs e)
        {
            string timKiem = txtnhapmatim.Text.Trim();
            dataGridView1.DataSource = trangsuc.TraCuu_LichSuMua(timKiem).ToList();
        }
    }
}
