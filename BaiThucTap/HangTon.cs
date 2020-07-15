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
    public partial class HangTon : Form
    {
        public HangTon()
        {
            InitializeComponent();
        }

        private void HangTon_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'hangkho.hangtonkhoaaa' table. You can move, or remove it, as needed.
            //this.hangtonkhoaaaTableAdapter.Fill(this.hangkho.hangtonkhoaaa);

            //this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hangkho.hangtonkhoaaa' table. You can move, or remove it, as needed.
            this.hangtonkhoaaaTableAdapter.Fill(this.hangkho.hangtonkhoaaa,dateTimePicker1.Value.Month,dateTimePicker1.Value.Year);

            this.reportViewer1.RefreshReport();
        }
    }
}
