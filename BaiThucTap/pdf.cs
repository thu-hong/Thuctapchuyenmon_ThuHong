using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Text;
using System.ComponentModel;
using System.IO;

namespace BaiThucTap
{
    public partial class pdf : Form
    {
        public pdf()
        {
            InitializeComponent();
        }
        public void xuatPDF(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dgv.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void xuatpdf_Click(object sender, EventArgs e)
        {
            xuatPDF(dataGridView1, "Danh sach Hoa Don");
        }

        private void pdf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.dataSet1.HoaDon);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
