using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BaiThucTap
{
    public partial class LoadHinhTrangSuc : Form
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public LoadHinhTrangSuc()
        {
            InitializeComponent();
        }

        private void LoadHinhTrangSuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTrangSuc.TrangSuc' table. You can move, or remove it, as needed.
            this.trangSucTableAdapter.Fill(this.dataSetTrangSuc.TrangSuc);

        }
        string img = "";

      
        private void loadhinh_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            string file = openFile.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            if (file == "openFileDialog1")
                return;
            else
            {
                img = openFile.FileName.ToString();
                Image myimage = Image.FromFile(file);
                loadhinh.Image = myimage;

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTS.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updateTrangSuc(txtMaTS.Text);
           
        }
        private void updateTrangSuc(string MaTS)
        {
            TrangSuc ts = trangsuc.TrangSucs.FirstOrDefault(p => p.MaTS == MaTS);
            MemoryStream me = new MemoryStream();
            byte[] images = null;
            FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            ts.HinhAnh = images;
            trangsuc.SaveChanges();
            dataGridView1.DataSource = trangsuc.TrangSucs.ToList();
            MessageBox.Show("Update thành công");

        }
    }
}
