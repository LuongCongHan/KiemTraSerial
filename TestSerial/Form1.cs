using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotPLC.Modbus;
//using EasyModbus;
using System.IO.Ports;
using System.Threading;
using dotPLC.Mitsubishi.Types;
using PPC;

namespace TestSerial
{
    public partial class Form1 : Form
    {
        ManualResetEvent manual = new ManualResetEvent(false);
        ModbusClient easyclient = new ModbusClient("127.0.0.1",502)
        { UnitIdentifier = 1, Baudrate = 9600, Parity = Parity.Even, StopBits = StopBits.One };
        dotPLC.Modbus.ModbusRtuClient dotplcClient = new ModbusRtuClient()
        { SerialPort = "COM5", UnitIdentifier = 1, Baudrate = 9600, Parity = Parity.Even, StopBits = StopBits.One };
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            timer2.Start();
            serialPort1.DataReceived += SerialPort1_DataReceived;
        }

        private void btnSerialConnect_Click(object sender, EventArgs e)
        {

            AllDisconnect();
           // serialPort1.DataReceived += SerialPort1_DataReceived;
            serialPort1.Open();
            radSerial.Checked = true;
            //chophepghi = true;

            timer1.Start();
        }
        int num1 = 0;
        int num2 = 0;
        int up = 0;
        bool enableRead = true;
        private async void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            up++;
            serialPort1.DataReceived -= SerialPort1_DataReceived;
            enableRead = false;
            SerialPort sp = (SerialPort)sender;
           // chophepghi = false;
            //serialPort1.DataReceived -= SerialPort1_DataReceived;
            int index = 0;
            await Task.Delay(5000);
            DateTime dateTimeLastRead=DateTime.Now;
            while (index < 7)
            {
                while (sp.BytesToRead==0)
                {
                    await Task.Delay(10);
                    if((DateTime.Now.Ticks-dateTimeLastRead.Ticks)>TimeSpan.TicksPerMillisecond*2000)
                        break;
                }
                int numofbyte = sp.BytesToRead;


                index += serialPort1.Read(ReadMess, index, numofbyte);
            }

            num1 = index;
            //lbNumReadSerial.Text = index.ToString();
            num2 = ((ReadMess[3] << 8) + ReadMess[4]);
            // serialPort1.DataReceived += SerialPort1_DataReceived;
            //  chophepghi = true;
            enableRead = true;
            serialPort1.DataReceived += SerialPort1_DataReceived;
        }

        private void btndotPLCConnect_Click(object sender, EventArgs e)
        {
            AllDisconnect();
            dotplcClient.Connect();
            raddotPLC.Checked = true;
            timer1.Start();
        }

        private void btnEasyConnect_Click(object sender, EventArgs e)
        {
            AllDisconnect();
            easyclient.Connect();
            radEasy.Checked = true;
            timer1.Start();
        }
        byte[] ReadHz = { 0x01, 0x03, 0x00, 0xc8, 0x00, 0x01, 0x05, 0xf4 };
        byte[] ReadMess = new byte[20];
        private void btnSerialRead_Click(object sender, EventArgs e)
        {
            serialPort1.DiscardInBuffer();
            serialPort1.Write(ReadHz, 0, ReadHz.Length);
            serialPort1.DiscardInBuffer();

            //int index = 0;
            //while (index < 7)
            //{
            //    index += serialPort1.Read(ReadMess, index, 7- index);
            //}
            lbNumReadSerial.Text = serialPort1.Read(ReadMess, 0, 7).ToString();
            //lbNumReadSerial.Text = index.ToString();
            lbData.Text = ((ReadMess[3] << 8) + ReadMess[4]).ToString();
        }

        private void btndotPLCRead_Click(object sender, EventArgs e)
        {
            //lbData.Text =(await dotplcClient.ReadHoldingRegisters(200, 1))[0].ToString();
            lbData.Text = dotplcClient.ReadHoldingRegisters(200, 1)[0].ToString();

        }
        public static Task DelayEx(double milliseconds)
        {
            var tcs = new TaskCompletionSource<bool>();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (o, e) => tcs.TrySetResult(true);
            timer.Interval = milliseconds;
            timer.AutoReset = false;
            timer.Start();
            return tcs.Task;
        }
        private void btnEasyRead_Click(object sender, EventArgs e)
        {
            string txt = "";
            bool[] data = new bool[] { true, false, true, true, false, false, false, false, true, false, true, true, false, false, true, true, true };
            int[] idata = new int[] { 4000 };
            short[] sdata = new short[] { 4000 };
            var ret = easyclient.ReadWriteMultipleRegisters(200, 3, 200, idata);
            for (int i = 0; i < ret.Length; i++)
            {
                txt += ret[i].ToString() + Environment.NewLine;
            }
            MessageBox.Show(txt);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort1.Close();
            dotplcClient.Disconnect();
            easyclient.Disconnect();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (!chkEnable.Checked) return;
            if (radSerial.Checked)
            {
                serialPort1.Write(ReadHz, 0, ReadHz.Length);
                int index = 0;
                //while (index < 7)
                //{
                //    index += serialPort1.Read(ReadMess, index, 7-index);
                //}
                serialPort1.Read(ReadMess, 0, 7);
                lbData.Text = ((ReadMess[3] << 8) + ReadMess[4]).ToString();
            }
            else if (raddotPLC.Checked)
            {
                //lbData.Text = dotplcClient.ReadHoldingRegisters(200, 1)[0].ToString();
                // lbData.Text =( await dotplcClient.ReadHoldingRegistersAsync(200, 1))[0].ToString();
                lbData.Text = dotplcClient.ReadHoldingRegisters(200, 1)[0].ToString();

            }
            else if (radEasy.Checked)
            {
                lbData.Text = easyclient.ReadHoldingRegisters(200, 1)[0].ToString();

            }

        }
        int x = 0;
        private async Task ReadData()
        {

           await Task.Run(async() =>
            {
                if (!chkEnable.Checked) return;
                if (radSerial.Checked)
                {
                    await Task.Delay(100);

                    await serialPort1.BaseStream.WriteAsync(ReadHz, 0, ReadHz.Length);
                    int index = 0;

                    while (index < 7)
                    {

                        index += await serialPort1.BaseStream.ReadAsync(ReadMess, index, 7);
                    }
                    lbData.Text = ((ReadMess[3] << 8) + ReadMess[4]).ToString();
                }
                else if (raddotPLC.Checked)
                {
                    // lbData.Text = (await dotplcClient.ReadHoldingRegisters(200, 1))[0].ToString();
                    lbData.Text = dotplcClient.ReadHoldingRegisters(200, 1)[0].ToString();
                }
                else if (radEasy.Checked)
                {
                   // lbData.Text = easyclient.ReadHoldingRegisters(200, 1)[0].ToString();
                }
            });
        }

        private void AllDisconnect()
        {
            timer1.Stop();
            serialPort1.Close();
            dotplcClient.Disconnect();
            easyclient.Disconnect();
        }

        private async void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkEnable.Checked)
            //await  ReadData();
          //  chophepghi = !chophepghi;
           // MessageBox.Show(chophepghi.ToString());
        }
        int _isSafe = 1;
        bool chophepghi = false;
        private async void btnSerialWrite_Click(object sender, EventArgs e)
        {
            if (!enableRead) return;
            //if (!chophepghi) return;
            serialPort1.Write(ReadHz, 0, ReadHz.Length);
            //timer2.Start();
            // serialPort1.DiscardInBuffer();
           // await Task.Delay(3000);
           // MessageBox.Show("dellay xong");
        }
        int next = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //lbData.Text = TimeSpan.TicksPerMillisecond.ToString();
            //  System.Threading.Thread.Sleep(1);
            // next++;
            // lbNumReadSerial.Text = .ToString();
            // lbData.Text = num2.ToString();
          

        }

        private void radSerial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            manual.Set();//cho chay
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            manual.Reset();//khong cho chay
        }
        int test = 0;
        byte[] readBuffer = new byte[256];
        dotPLC.Mitsubishi.Simulator3 client = new dotPLC.Mitsubishi.Simulator3();
        private void btnRun_Click(object sender, EventArgs e)
        {
            //Task.Run(async () =>
            //{
            //    while(true)
            //    {
            //        manual.WaitOne(10000);
            //        await Task.Delay(10);
            //        next++;
            //    }
            //});

            Exception exx = new Exception();
            Word word= new Word() { Label = "x0" };
            try
            {
                //var regisers = new Word[] { new Word("1D1000"), new Word("sd" + int.MaxValue.ToString()) };


                // Word D0 = new Word("X0");
                // Bit X0 = new Bit("X8");
                //MessageBox.Show(client.ReadDevice<short>("D1F33").ToString());
                //  client.ReadDeviceRandom(word);
                var gt = client.ReadDevice<short>("D6");
                //MessageBox.Show(word.ValueU.ToString());
                MessageBox.Show(gt.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().Name +" - "+ex.Message);
            }
            //  client.WriteDevice("D2", (long)12222222222222222);

            //  MessageBox.Show(readBuffer.Length.ToString());

        }

        private void btndotPLCWrite_Click(object sender, EventArgs e)
        {
            lbData.Text= dotplcClient.ReadHoldingRegisters(200, 1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // client.Connect();
        }

        private void btnEasyWrite_Click(object sender, EventArgs e)
        {
            bool[] data = new bool[] { true, false, true, true, false, false, false, false, true, false, true, true, false, false, true, true, true };
            easyclient.WriteMultipleCoils(0, data);
        }
    }
}
