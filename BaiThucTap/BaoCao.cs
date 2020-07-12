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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void theoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTheoNgay f1 = new BaoCaoTheoNgay();
            f1.ShowDialog();

        }

        private void theoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoThongKeTheoThang f2 = new BaoCaoThongKeTheoThang();
            f2.ShowDialog();
        }
    }
}
