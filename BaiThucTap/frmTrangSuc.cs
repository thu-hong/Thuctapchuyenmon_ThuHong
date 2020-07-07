using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.IO;

namespace BaiThucTap
{
    public partial class frmTrangSuc : UserControl
    {
        quanlytrangsucEntities1 trangsuc = new quanlytrangsucEntities1();
        public frmTrangSuc()
        {
            InitializeComponent();
        }
        private void Loadtrangsuc(string v)
        {
            panelAnh.Controls.Clear();
            int i = 0;
            List<TrangSuc> ts = trangsuc.TrangSucs.Where(p => p.MaLoai == v).ToList();
            int dem = ts.Count % 3;
            int count = ts.Count / 3;
            foreach(var item in ts)
            {
                BunifuImageButton img = new BunifuImageButton();
                img.Name = item.MaTS.ToString();
                img.Size = new System.Drawing.Size(182, 138);
                img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                Byte[] hinhanh = item.HinhAnh;
                if(hinhanh != null)
                {
                    using (MemoryStream stream = new MemoryStream(hinhanh))
                    {
                        Image returnImage = Image.FromStream(stream);
                        img.Image = returnImage;
                    }
                    img.BorderStyle = BorderStyle.FixedSingle;
                    img.TabIndex = i;
                    img.TabStop = false;
                    img.Zoom = 10;
                    panelAnh.Controls.Add(img);
                    img.Click += new EventHandler(chonhinhanh); 
                }
                i++;
                if(i% 3 == 0)
                {
                    for(int j = i - 3; j < i; j++)
                    {
                        TextBox tb = new TextBox();
                        tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        tb.Size = new System.Drawing.Size(182, 13);
                        tb.Enabled = false;
                        tb.BackColor = Color.White;
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                        tb.Text = ts[j].TenTS;
                        panelAnh.Controls.Add(tb);
                    }
                }
            }
            if (dem < 3)
            {
                for (int k = 0; k < 3 - dem; k++)
                {
                    Label tb = new Label();
                    tb.Size = new System.Drawing.Size(182, 13);
                    tb.BackColor = Color.White;
                    panelAnh.Controls.Add(tb);
                    tb.Enabled = false;
                }
                for (int j = 0; j < dem; j++)
                {
                    TextBox tb = new TextBox();
                    tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    tb.Size = new System.Drawing.Size(182, 13);
                    tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    tb.Text = ts[3 * count + j].TenTS;
                    panelAnh.Controls.Add(tb);

                }
            }

        }
        string mats = "";

        private void chonhinhanh(object sender, EventArgs e)
        {
            BunifuImageButton img = sender as BunifuImageButton;
            mats = img.Name.ToString();
            TrangSuc ts = trangsuc.TrangSucs.FirstOrDefault(p => p.MaTS == mats);
            cbLoaiTS.SelectedValue = ts.MaLoai;
            txtTenTS.Text = ts.TenTS;
            txtDonGia.Text = ts.DonGia.ToString();
              
            
        }
        private void Loadloaitrangsuc()
        {
            List<LoaiTrangSuc> loai = trangsuc.LoaiTrangSucs.ToList();
            cbLoaiTS.DataSource = loai;
            cbLoaiTS.DisplayMember = "TenLoai";
            cbLoaiTS.ValueMember = "MaLoai";
           
        }


    }
}
