using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace BaiThucTap
{
    public partial class QuanLyHoaDon : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }
        private void loadhd()
        {
            // để tránh các cột bị mất thứ tự sau khi gán cột
            dataGridview1.AutoGenerateColumns = false;
            dataGridview1.DataSource = trangsuc.HoaDons.ToList();
        }

        public bool kiemtra()
        {
            if(cbuser.Text==""|| cbmaud.Text == "" || cbkhachhang.Text=="")
            {
                MessageBox.Show("Bạn Chưa nhập đủ thông tin");
                return false;
            }
            else
            {
                return true;
            }
            
        }
        private void btnthemHD_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
           
            trangsuc.themHD3(cbuser.Text, cbmaud.SelectedValue.ToString(), cbkhachhang.SelectedValue.ToString());
            trangsuc.SaveChanges();
            MessageBox.Show("Thêm Hóa Đơn Thành Công ");
            QuanLyHoaDon_Load(sender, e);
           

        }
        private void loaduser()
        {
            List<DangNhap> user = trangsuc.DangNhaps.ToList();
            cbuser.DataSource = user;
            cbuser.DisplayMember = "UserName";
            cbuser.ValueMember = "UserName";
        }

        private void loadkh()
        {
            List<KhachHang> kh = trangsuc.KhachHangs.ToList();
            cbkhachhang.DataSource = kh;
            cbkhachhang.DisplayMember = "TenKH";
            cbkhachhang.ValueMember = "MaKH";
        }
        private void loadud()
        {
            List<UuDai> ud = trangsuc.UuDais.ToList();
            cbmaud.DataSource = ud;
            cbmaud.DisplayMember = "TenUD";
            cbmaud.ValueMember = "MaUD";
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
         
            loadhd();
            loaduser();
            loadud();
            loadkh();            
        }

        private void dataGridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Bạn có muốn xóa hoa dơn này không?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mahd = dataGridview1.CurrentRow.Cells[0].Value.ToString();
                    trangsuc.deleHD1(mahd);
                    MessageBox.Show("Đã xóa!!");
                    QuanLyHoaDon_Load(sender, e);
                }
            }

        }
        string img = "";

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            moFile.ShowDialog();
            string file = moFile.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            if (file == "openFileDialog1")
                return;
            else
            {
                img = moFile.FileName.ToString();
            }
            Console.WriteLine(img);
            try
            {
                string saveExcelFile = img;

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;
                object misValue = System.Reflection.Missing.Value;
                Workbook wb = xlApp.Workbooks.Add(misValue);
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng tiêu đề của file 
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "E1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Thống kê hóa đơn";
                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2");//Cột A dòng 2 và dòng 3
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã Sản phẩm :
                Range row23_MaSP = ws.get_Range("B2");//Cột B dòng 2 và dòng 3
                row23_MaSP.Font.Size = fontSizeTenTruong;
                row23_MaSP.Font.Name = fontName;
                row23_MaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaSP.Value2 = "Mã Hóa Đơn";
                row23_MaSP.ColumnWidth = 20;

                //Tạo Ô Tên Sản phẩm :
                Range row23_TenSP = ws.get_Range("C2");//Cột C dòng 2 và dòng 3
                row23_TenSP.Font.Size = fontSizeTenTruong;
                row23_TenSP.Font.Name = fontName;
                row23_TenSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenSP.ColumnWidth = 20;
                row23_TenSP.Value2 = "Ngày Lập";

                //Tạo Ô Giá Nhập:
                Range row3_GiaNhap = ws.get_Range("D2");//Ô D3
                row3_GiaNhap.Font.Size = fontSizeTenTruong;
                row3_GiaNhap.Font.Name = fontName;
                row3_GiaNhap.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_GiaNhap.Value2 = "Nhân Viên";
                row3_GiaNhap.ColumnWidth = 20;

                //Tạo Ô Giá Xuất:
                Range row3_GiaXuat = ws.get_Range("E2");//Ô E3
                row3_GiaXuat.Font.Size = fontSizeTenTruong;
                row3_GiaXuat.Font.Name = fontName;
                row3_GiaXuat.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_GiaXuat.Value2 = "Tổng Tiền";
                row3_GiaXuat.ColumnWidth = 20;
                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "E2");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 2;
                foreach (HoaDon hd in trangsuc.HoaDons)
                {
                    stt++;
                    row++;
                    dynamic[] day = { stt, hd.MaHD.Trim(), Convert.ToDateTime(hd.TGLap),hd.UserName.Trim(),hd.TongTien };
                    Range rowData = ws.get_Range("A" + row, "E" + row);
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    rowData.Value2 = day;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "E" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                
                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
       
        private void btnxuatpdf_Click(object sender, EventArgs e)
        {
            pdf f = new pdf();
            f.ShowDialog();
        }

        private void cbuser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
