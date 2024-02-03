using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotPLC.Mitsubishi;
using dotPLC.Mitsubishi.Types;

namespace Check_dotPLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            client = new SLMPClient();

            FluentModbus.ModbusRtuClient modbusRtuClient = new FluentModbus.ModbusRtuClient();
        }
        SLMPClient client ;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Close();
        }
        internal static readonly Regex sWhitespace = new Regex("\\s+");
        private void btnRead_Click(object sender, EventArgs e)
        {
            //Word[] words = new Word[180];
            //DWord[] dWords = new DWord[] { new DWord("X1"), new DWord("x2"), null, new DWord("x3") };
            //Float[] floats = new Float[] { new Float("X1"), new Float("x2"), new Float("x3"), null };
            //Bit[] bits = new Bit[] { new Bit("X1"), new Bit("y2"), new Bit("x3"), new Bit("y2"), new Bit("M0") };
            //client.WriteDeviceRandom(floats);
            //string txt = "";
            //foreach (var item in bits)
            //{
            //    txt += item.Label +" = "+ item.Value.ToString() + Environment.NewLine;
            //}
            //MessageBox.Show(txt);
            client.WriteText("D0", "");
            client.ReadText("D0",0);
            
           // client.WriteDeviceBlock<short>("D0", null);

            //client.RemoteUnlock("12412333333333333333vv1422222225555");
            //client.WriteDeviceBlock<short>("",12); //Chua xu ly loi
            //bool[] Input = null;
            //client.WriteDeviceBlock("M0", Input);
            //  var value = client.ReadDevice<short>("D0");
            try
            {
                //bool[] Input = null;
                //client.WriteDeviceBlock("M0", Input);
                //var res= client.ReadDeviceBlock<bool>("D0", 4);
                //string txt = "";
                //foreach (var item in res)
                //{
                //    txt = item.ToString() + Environment.NewLine;
                //}
                //MessageBox.Show(txt);

                //Word d0 = new Word("D0     2");
                //client.ReadDeviceRandom(d0);
                //lbData.Text = d0.Value.ToString();
                //client.WriteDeviceRandom();
               // client.SelfTest(null);
                // new Word() { };
                // client.WriteText("", "");
                //  var value1 = client.ReadText("", 22);
               // var value = client.ReadDevice<short>("Df0");
               // lbData.Text = value.ToString();
                //sWhitespace.Replace();
               // ArgumentNullException
            }
            catch(Exception ex)
            {
                lbData.Text = ex.GetType().Name.ToString() + " - " + ex.Message;
            }
            
            
        }
    }
}
