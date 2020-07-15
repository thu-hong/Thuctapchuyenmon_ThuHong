using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace BaiThucTap
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1997);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                 
                client.Connect(IP);

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối với server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Close()
        {
            client.Close();
        }
        void Send()
        {
            if (txttinnhan.Text != string.Empty)
            {
                client.Send(Serialize(hong + " : " + txttinnhan.Text));
            }
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deseriliaze(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }
        void AddMessage(string s)
        {
            listMes.Items.Add(new ListViewItem() { Text = s });
            txttinnhan.Clear();

        }
      
      

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(hong + " : " + txttinnhan.Text);

        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deseriliaze(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        string hong;
        private void Client_Load(object sender, EventArgs e)
        {
            hong = khachhangdangnhap.tenquaform.tenkh;
        }
    }
}
