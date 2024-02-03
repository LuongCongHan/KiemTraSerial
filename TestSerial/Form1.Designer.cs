namespace TestSerial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNumReadSerial = new System.Windows.Forms.Label();
            this.btnSerialWrite = new System.Windows.Forms.Button();
            this.btnSerialRead = new System.Windows.Forms.Button();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNumReadDOt = new System.Windows.Forms.Label();
            this.btndotPLCWrite = new System.Windows.Forms.Button();
            this.btndotPLCRead = new System.Windows.Forms.Button();
            this.btndotPLCConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbNumReadEasy = new System.Windows.Forms.Label();
            this.btnEasyWrite = new System.Windows.Forms.Button();
            this.btnEasyRead = new System.Windows.Forms.Button();
            this.btnEasyConnect = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radSerial = new System.Windows.Forms.RadioButton();
            this.raddotPLC = new System.Windows.Forms.RadioButton();
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnSet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNumReadSerial);
            this.groupBox1.Controls.Add(this.btnSerialWrite);
            this.groupBox1.Controls.Add(this.btnSerialRead);
            this.groupBox1.Controls.Add(this.btnSerialConnect);
            this.groupBox1.Location = new System.Drawing.Point(32, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // lbNumReadSerial
            // 
            this.lbNumReadSerial.AutoSize = true;
            this.lbNumReadSerial.Location = new System.Drawing.Point(20, 116);
            this.lbNumReadSerial.Name = "lbNumReadSerial";
            this.lbNumReadSerial.Size = new System.Drawing.Size(35, 13);
            this.lbNumReadSerial.TabIndex = 1;
            this.lbNumReadSerial.Text = "label1";
            // 
            // btnSerialWrite
            // 
            this.btnSerialWrite.Location = new System.Drawing.Point(20, 147);
            this.btnSerialWrite.Name = "btnSerialWrite";
            this.btnSerialWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSerialWrite.TabIndex = 0;
            this.btnSerialWrite.Text = "Write";
            this.btnSerialWrite.UseVisualStyleBackColor = true;
            this.btnSerialWrite.Click += new System.EventHandler(this.btnSerialWrite_Click);
            // 
            // btnSerialRead
            // 
            this.btnSerialRead.Location = new System.Drawing.Point(20, 86);
            this.btnSerialRead.Name = "btnSerialRead";
            this.btnSerialRead.Size = new System.Drawing.Size(75, 23);
            this.btnSerialRead.TabIndex = 0;
            this.btnSerialRead.Text = "Read";
            this.btnSerialRead.UseVisualStyleBackColor = true;
            this.btnSerialRead.Click += new System.EventHandler(this.btnSerialRead_Click);
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Location = new System.Drawing.Point(20, 35);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(75, 23);
            this.btnSerialConnect.TabIndex = 0;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNumReadDOt);
            this.groupBox2.Controls.Add(this.btndotPLCWrite);
            this.groupBox2.Controls.Add(this.btndotPLCRead);
            this.groupBox2.Controls.Add(this.btndotPLCConnect);
            this.groupBox2.Location = new System.Drawing.Point(159, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 176);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "dotPLC";
            // 
            // lbNumReadDOt
            // 
            this.lbNumReadDOt.AutoSize = true;
            this.lbNumReadDOt.Location = new System.Drawing.Point(18, 116);
            this.lbNumReadDOt.Name = "lbNumReadDOt";
            this.lbNumReadDOt.Size = new System.Drawing.Size(35, 13);
            this.lbNumReadDOt.TabIndex = 1;
            this.lbNumReadDOt.Text = "label1";
            // 
            // btndotPLCWrite
            // 
            this.btndotPLCWrite.Location = new System.Drawing.Point(21, 147);
            this.btndotPLCWrite.Name = "btndotPLCWrite";
            this.btndotPLCWrite.Size = new System.Drawing.Size(75, 23);
            this.btndotPLCWrite.TabIndex = 0;
            this.btndotPLCWrite.Text = "Write";
            this.btndotPLCWrite.UseVisualStyleBackColor = true;
            this.btndotPLCWrite.Click += new System.EventHandler(this.btndotPLCWrite_Click);
            // 
            // btndotPLCRead
            // 
            this.btndotPLCRead.Location = new System.Drawing.Point(20, 86);
            this.btndotPLCRead.Name = "btndotPLCRead";
            this.btndotPLCRead.Size = new System.Drawing.Size(75, 23);
            this.btndotPLCRead.TabIndex = 0;
            this.btndotPLCRead.Text = "Read";
            this.btndotPLCRead.UseVisualStyleBackColor = true;
            this.btndotPLCRead.Click += new System.EventHandler(this.btndotPLCRead_Click);
            // 
            // btndotPLCConnect
            // 
            this.btndotPLCConnect.Location = new System.Drawing.Point(20, 35);
            this.btndotPLCConnect.Name = "btndotPLCConnect";
            this.btndotPLCConnect.Size = new System.Drawing.Size(75, 23);
            this.btndotPLCConnect.TabIndex = 0;
            this.btndotPLCConnect.Text = "Connect";
            this.btndotPLCConnect.UseVisualStyleBackColor = true;
            this.btndotPLCConnect.Click += new System.EventHandler(this.btndotPLCConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbNumReadEasy);
            this.groupBox3.Controls.Add(this.btnEasyWrite);
            this.groupBox3.Controls.Add(this.btnEasyRead);
            this.groupBox3.Controls.Add(this.btnEasyConnect);
            this.groupBox3.Location = new System.Drawing.Point(288, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 176);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EasyModbus";
            // 
            // lbNumReadEasy
            // 
            this.lbNumReadEasy.AutoSize = true;
            this.lbNumReadEasy.Location = new System.Drawing.Point(17, 116);
            this.lbNumReadEasy.Name = "lbNumReadEasy";
            this.lbNumReadEasy.Size = new System.Drawing.Size(35, 13);
            this.lbNumReadEasy.TabIndex = 1;
            this.lbNumReadEasy.Text = "label1";
            // 
            // btnEasyWrite
            // 
            this.btnEasyWrite.Location = new System.Drawing.Point(20, 147);
            this.btnEasyWrite.Name = "btnEasyWrite";
            this.btnEasyWrite.Size = new System.Drawing.Size(75, 23);
            this.btnEasyWrite.TabIndex = 0;
            this.btnEasyWrite.Text = "Write";
            this.btnEasyWrite.UseVisualStyleBackColor = true;
            this.btnEasyWrite.Click += new System.EventHandler(this.btnEasyWrite_Click);
            // 
            // btnEasyRead
            // 
            this.btnEasyRead.Location = new System.Drawing.Point(20, 86);
            this.btnEasyRead.Name = "btnEasyRead";
            this.btnEasyRead.Size = new System.Drawing.Size(75, 23);
            this.btnEasyRead.TabIndex = 0;
            this.btnEasyRead.Text = "Read";
            this.btnEasyRead.UseVisualStyleBackColor = true;
            this.btnEasyRead.Click += new System.EventHandler(this.btnEasyRead_Click);
            // 
            // btnEasyConnect
            // 
            this.btnEasyConnect.Location = new System.Drawing.Point(20, 35);
            this.btnEasyConnect.Name = "btnEasyConnect";
            this.btnEasyConnect.Size = new System.Drawing.Size(75, 23);
            this.btnEasyConnect.TabIndex = 0;
            this.btnEasyConnect.Text = "Connect";
            this.btnEasyConnect.UseVisualStyleBackColor = true;
            this.btnEasyConnect.Click += new System.EventHandler(this.btnEasyConnect_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(176, 9);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(35, 13);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "label1";
            // 
            // serialPort1
            // 
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            this.serialPort1.PortName = "COM5";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(32, 13);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radSerial
            // 
            this.radSerial.AutoSize = true;
            this.radSerial.Location = new System.Drawing.Point(42, 228);
            this.radSerial.Name = "radSerial";
            this.radSerial.Size = new System.Drawing.Size(76, 17);
            this.radSerial.TabIndex = 1;
            this.radSerial.TabStop = true;
            this.radSerial.Text = "Auto-Read";
            this.radSerial.UseVisualStyleBackColor = true;
            this.radSerial.CheckedChanged += new System.EventHandler(this.radSerial_CheckedChanged);
            // 
            // raddotPLC
            // 
            this.raddotPLC.AutoSize = true;
            this.raddotPLC.Location = new System.Drawing.Point(179, 228);
            this.raddotPLC.Name = "raddotPLC";
            this.raddotPLC.Size = new System.Drawing.Size(76, 17);
            this.raddotPLC.TabIndex = 1;
            this.raddotPLC.TabStop = true;
            this.raddotPLC.Text = "Auto-Read";
            this.raddotPLC.UseVisualStyleBackColor = true;
            // 
            // radEasy
            // 
            this.radEasy.AutoSize = true;
            this.radEasy.Location = new System.Drawing.Point(308, 228);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(76, 17);
            this.radEasy.TabIndex = 1;
            this.radEasy.TabStop = true;
            this.radEasy.Text = "Auto-Read";
            this.radEasy.UseVisualStyleBackColor = true;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(313, 27);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(105, 17);
            this.chkEnable.TabIndex = 3;
            this.chkEnable.Text = "Cho phép AUTO";
            this.chkEnable.UseVisualStyleBackColor = true;
            this.chkEnable.CheckedChanged += new System.EventHandler(this.chkEnable_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "5";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(31, 260);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(130, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set/Cho phép chạy";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset/Không cho chạy";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(343, 260);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 295);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.radEasy);
            this.Controls.Add(this.raddotPLC);
            this.Controls.Add(this.radSerial);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSerialWrite;
        private System.Windows.Forms.Button btnSerialRead;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndotPLCWrite;
        private System.Windows.Forms.Button btndotPLCRead;
        private System.Windows.Forms.Button btndotPLCConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEasyWrite;
        private System.Windows.Forms.Button btnEasyRead;
        private System.Windows.Forms.Button btnEasyConnect;
        private System.Windows.Forms.Label lbData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radSerial;
        private System.Windows.Forms.RadioButton raddotPLC;
        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label lbNumReadSerial;
        private System.Windows.Forms.Label lbNumReadDOt;
        private System.Windows.Forms.Label lbNumReadEasy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRun;
    }
}

