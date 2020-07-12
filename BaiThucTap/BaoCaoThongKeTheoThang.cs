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
    public partial class BaoCaoThongKeTheoThang : Form
    {
        public BaoCaoThongKeTheoThang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'dttheothang.dttheothang1' table.You can move, or remove it, as needed.
        //    this.dttheothang1TableAdapter.Fill(this.dttheothang.dttheothang1);

        //    this.reportViewer1.RefreshReport();
        //    this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dttheothang.dttheothang1' table. You can move, or remove it, as needed.
            this.dttheothang1TableAdapter.Fill(this.dttheothang.dttheothang1,dateTimePicker2.Value.Month,dateTimePicker2.Value.Year);

            // this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
