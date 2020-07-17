using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiThucTap
{
    public partial class DongGoiDuLieu : Form
    {
        public DongGoiDuLieu()
        {
            InitializeComponent();
        }
    //   SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LDL6HFF\SQLEXPRESS;Initial Catalog=quanlytrangsuc;Integrated Security=True");

        private void btbrowser_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fd = new FolderBrowserDialog();
            //if( fd.ShowDialog()== DialogResult.OK)
            //{
            //    txtPath.text = fd.SelectedPath;
        
            //}
        }

        private void btbackup_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    string qry = "BACKUP DATABASE ["+ con.Database+"] TO  DISK = N'"+ txtPath.text + "\\"+ con.Database + ".bak' ";
            //    SqlCommand cmd = new SqlCommand(qry, con);
            //    cmd.ExecuteNonQuery();

            //    con.Close();
            //    MessageBox.Show("Backup Successfully done.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            try
            {
                
                SqlConnection connect;
               // connect.Open();
                string con = @"Data Source=DESKTOP-LDL6HFF\SQLEXPRESS;Initial Catalog=quanlytrangsuc;Integrated Security=True";
                connect = new SqlConnection(con);
                 connect.Open();
                SqlCommand command;

                command = new SqlCommand(@"BACKUP DATABASE[quanlytrangsuc] TO  DISK = 'D:\Backup.bak'");
                //command = new SqlCommand(@"Backup database qlthucung to disk ='e:\SQLBackup\BackUp.bak'", connect);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
