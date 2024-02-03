using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace testtcp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient();
           
            
        }
        TcpClient client;
        NetworkStream stream;
        byte[] ReadBuffer = new byte[10];
        byte[] WriteBuffer = new byte[10];

        private void btnRead_Click(object sender, EventArgs e)
        {
           
            int soluong= stream.Read(ReadBuffer, 0, int.Parse(txtNum.Text));
            lbRead.Text = Encoding.ASCII.GetString(ReadBuffer, 0, soluong);
            lbSoluongdoc.Text = soluong.ToString();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            var data = Encoding.ASCII.GetBytes(txtWrite.Text);
            stream.Write(data, 0, data.Length);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stream.Close();
            // client.Close();
            MessageBox.Show(Convert.ToBoolean(0).ToString());
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.Connect("127.0.0.1", 502);
            client.ReceiveTimeout = 3000;
            client.SendTimeout = 3000;
            stream = client.GetStream();
            stream.ReadTimeout = 3000;
            stream.WriteTimeout = 3000;
        }
    }
}
