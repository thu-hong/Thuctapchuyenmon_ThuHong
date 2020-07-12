using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BaiThucTap
{
    public partial class BaoCaoTheoNgay : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public BaoCaoTheoNgay()
        {
            InitializeComponent();
        }

        private void BaoCaoTheoNgay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danhthungay.dttheongay1' table. You can move, or remove it, as needed.
           
            //TODO: This line of code loads data into the 'dttheothang.dttheothang1' table.You can move, or remove it, as needed.
            //    this.dttheothang1TableAdapter.Fill(this.dttheothang.dttheothang1);

            //// TODO: This line of code loads data into the 'DanhThuTheoNgay.dttheongay' table. You can move, or remove it, as needed.
            //this.dttheongayTableAdapter.Fill(this.DanhThuTheoNgay.dttheongay,dateTimePicker1.Value.Date);

            //this.reportViewer1.RefreshReport();
        }

        private void btbaocao_Click(object sender, EventArgs e)
        {
            
            //DataTable tb = new DataTable();
            ////tb.Columns.Add("ngaylap");
            //tb.Columns.Add("banhang");
            //tb.Columns.Add("nhaphang");
            //tb.Columns.Add("luongnv");
            //tb.Columns.Add("doanhthu");
            //List<dttheongay_Result> hd = trangsuc.dttheongay(dateTimePicker1.Value.Date).ToList();
            //foreach(var item in hd)
            //{
            //    tb.Rows.Add(item.ngaylap, item.banhang, item.nhaphang, item.luongnv, item.doanhthu);
            //}
            
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dttheongay1TableAdapter.Fill(this.danhthungay.dttheongay1, dateTimePicker1.Value.Date);
            this.reportViewer1.RefreshReport();
        }

      
    }
}
