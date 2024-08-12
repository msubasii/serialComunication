namespace serialPortDeneme2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxSetVoltage1 = new System.Windows.Forms.TextBox();
            this.buttonSetVoltage1 = new System.Windows.Forms.Button();
            this.buttonSetVoltage2 = new System.Windows.Forms.Button();
            this.textBoxSetVoltage2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSetCurrent2 = new System.Windows.Forms.Button();
            this.textBoxSetCurrent2 = new System.Windows.Forms.TextBox();
            this.buttonSetCurrent1 = new System.Windows.Forms.Button();
            this.textBoxSetCurrent1 = new System.Windows.Forms.TextBox();
            this.buttonOutput1 = new System.Windows.Forms.Button();
            this.comboBoxPorts2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AcDc = new System.Windows.Forms.ComboBox();
            this.meters = new System.Windows.Forms.ComboBox();
            this.values = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.readValue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoRange = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.button2 = new System.Windows.Forms.Button();
            this.miliseconds = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(127, 72);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(181, 28);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(127, 113);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(82, 29);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(215, 113);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(99, 29);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxSetVoltage1
            // 
            this.textBoxSetVoltage1.Location = new System.Drawing.Point(27, 183);
            this.textBoxSetVoltage1.Name = "textBoxSetVoltage1";
            this.textBoxSetVoltage1.Size = new System.Drawing.Size(181, 27);
            this.textBoxSetVoltage1.TabIndex = 3;
            this.textBoxSetVoltage1.TextChanged += new System.EventHandler(this.textBoxSetVoltage1_TextChanged);
            this.textBoxSetVoltage1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoltageSet_KeyPress);
            // 
            // buttonSetVoltage1
            // 
            this.buttonSetVoltage1.Location = new System.Drawing.Point(73, 211);
            this.buttonSetVoltage1.Name = "buttonSetVoltage1";
            this.buttonSetVoltage1.Size = new System.Drawing.Size(75, 33);
            this.buttonSetVoltage1.TabIndex = 4;
            this.buttonSetVoltage1.Text = "Set";
            this.buttonSetVoltage1.UseVisualStyleBackColor = true;
            this.buttonSetVoltage1.Click += new System.EventHandler(this.buttonSetVoltage1_Click);
            // 
            // buttonSetVoltage2
            // 
            this.buttonSetVoltage2.Location = new System.Drawing.Point(81, 329);
            this.buttonSetVoltage2.Name = "buttonSetVoltage2";
            this.buttonSetVoltage2.Size = new System.Drawing.Size(75, 31);
            this.buttonSetVoltage2.TabIndex = 6;
            this.buttonSetVoltage2.Text = "Set";
            this.buttonSetVoltage2.UseVisualStyleBackColor = true;
            this.buttonSetVoltage2.Click += new System.EventHandler(this.buttonSetVoltage2_Click);
            // 
            // textBoxSetVoltage2
            // 
            this.textBoxSetVoltage2.Location = new System.Drawing.Point(27, 301);
            this.textBoxSetVoltage2.Name = "textBoxSetVoltage2";
            this.textBoxSetVoltage2.Size = new System.Drawing.Size(181, 27);
            this.textBoxSetVoltage2.TabIndex = 5;
            this.textBoxSetVoltage2.TextChanged += new System.EventHandler(this.textBoxSetVoltage2_TextChanged);
            this.textBoxSetVoltage2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoltageSet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "VOLTAGE CH1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "VOLTAGE CH2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "CURRENT CH2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "CURRENT CH1";
            // 
            // buttonSetCurrent2
            // 
            this.buttonSetCurrent2.Location = new System.Drawing.Point(294, 329);
            this.buttonSetCurrent2.Name = "buttonSetCurrent2";
            this.buttonSetCurrent2.Size = new System.Drawing.Size(75, 31);
            this.buttonSetCurrent2.TabIndex = 14;
            this.buttonSetCurrent2.Text = "Set";
            this.buttonSetCurrent2.UseVisualStyleBackColor = true;
            this.buttonSetCurrent2.Click += new System.EventHandler(this.buttonSetCurrent2_Click);
            // 
            // textBoxSetCurrent2
            // 
            this.textBoxSetCurrent2.Location = new System.Drawing.Point(240, 301);
            this.textBoxSetCurrent2.Name = "textBoxSetCurrent2";
            this.textBoxSetCurrent2.Size = new System.Drawing.Size(181, 27);
            this.textBoxSetCurrent2.TabIndex = 13;
            this.textBoxSetCurrent2.TextChanged += new System.EventHandler(this.textBoxSetCurrent2_TextChanged);
            this.textBoxSetCurrent2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoltageSet_KeyPress);
            // 
            // buttonSetCurrent1
            // 
            this.buttonSetCurrent1.Location = new System.Drawing.Point(286, 211);
            this.buttonSetCurrent1.Name = "buttonSetCurrent1";
            this.buttonSetCurrent1.Size = new System.Drawing.Size(75, 33);
            this.buttonSetCurrent1.TabIndex = 12;
            this.buttonSetCurrent1.Text = "Set";
            this.buttonSetCurrent1.UseVisualStyleBackColor = true;
            this.buttonSetCurrent1.Click += new System.EventHandler(this.buttonSetCurrent1_Click);
            // 
            // textBoxSetCurrent1
            // 
            this.textBoxSetCurrent1.Location = new System.Drawing.Point(227, 183);
            this.textBoxSetCurrent1.Name = "textBoxSetCurrent1";
            this.textBoxSetCurrent1.Size = new System.Drawing.Size(181, 27);
            this.textBoxSetCurrent1.TabIndex = 11;
            this.textBoxSetCurrent1.TextChanged += new System.EventHandler(this.textBoxSetCurrent1_TextChanged);
            this.textBoxSetCurrent1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoltageSet_KeyPress);
            // 
            // buttonOutput1
            // 
            this.buttonOutput1.Location = new System.Drawing.Point(127, 403);
            this.buttonOutput1.Name = "buttonOutput1";
            this.buttonOutput1.Size = new System.Drawing.Size(181, 31);
            this.buttonOutput1.TabIndex = 19;
            this.buttonOutput1.Text = "OUTPUT";
            this.buttonOutput1.UseVisualStyleBackColor = true;
            this.buttonOutput1.Click += new System.EventHandler(this.buttonOutput1_Click);
            // 
            // comboBoxPorts2
            // 
            this.comboBoxPorts2.FormattingEnabled = true;
            this.comboBoxPorts2.Location = new System.Drawing.Point(111, 54);
            this.comboBoxPorts2.Name = "comboBoxPorts2";
            this.comboBoxPorts2.Size = new System.Drawing.Size(181, 28);
            this.comboBoxPorts2.TabIndex = 20;
            this.comboBoxPorts2.Click += new System.EventHandler(this.comboBoxPorts2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.multimeterConnect_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(199, 95);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(99, 29);
            this.connectButton.TabIndex = 22;
            this.connectButton.Text = "Disconnect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Power Supply";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Multimeter";
            // 
            // AcDc
            // 
            this.AcDc.FormattingEnabled = true;
            this.AcDc.Location = new System.Drawing.Point(135, 178);
            this.AcDc.Name = "AcDc";
            this.AcDc.Size = new System.Drawing.Size(121, 28);
            this.AcDc.TabIndex = 25;
            this.AcDc.SelectedIndexChanged += new System.EventHandler(this.AcDc_SelectedIndexChanged);
            // 
            // meters
            // 
            this.meters.FormattingEnabled = true;
            this.meters.Location = new System.Drawing.Point(135, 252);
            this.meters.Name = "meters";
            this.meters.Size = new System.Drawing.Size(121, 28);
            this.meters.TabIndex = 26;
            this.meters.SelectedIndexChanged += new System.EventHandler(this.meters_SelectedIndexChanged);
            // 
            // values
            // 
            this.values.FormattingEnabled = true;
            this.values.Location = new System.Drawing.Point(135, 322);
            this.values.Name = "values";
            this.values.Size = new System.Drawing.Size(121, 28);
            this.values.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "AC/DC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Meter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Value";
            // 
            // readValue
            // 
            this.readValue.Location = new System.Drawing.Point(226, 405);
            this.readValue.Name = "readValue";
            this.readValue.Size = new System.Drawing.Size(105, 38);
            this.readValue.TabIndex = 32;
            this.readValue.Text = "READ";
            this.readValue.UseVisualStyleBackColor = true;
            this.readValue.Click += new System.EventHandler(this.readValue_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.autoRange);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxPorts2);
            this.panel1.Controls.Add(this.readValue);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.AcDc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.meters);
            this.panel1.Controls.Add(this.values);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 522);
            this.panel1.TabIndex = 34;
            // 
            // autoRange
            // 
            this.autoRange.Location = new System.Drawing.Point(262, 322);
            this.autoRange.Name = "autoRange";
            this.autoRange.Size = new System.Drawing.Size(50, 26);
            this.autoRange.TabIndex = 35;
            this.autoRange.Text = "Auto";
            this.autoRange.UseVisualStyleBackColor = true;
            this.autoRange.Click += new System.EventHandler(this.autoRange_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 38);
            this.button4.TabIndex = 34;
            this.button4.Text = "SET";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxPorts);
            this.panel2.Controls.Add(this.buttonConnect);
            this.panel2.Controls.Add(this.buttonOutput1);
            this.panel2.Controls.Add(this.buttonDisconnect);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxSetVoltage1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonSetVoltage1);
            this.panel2.Controls.Add(this.buttonSetCurrent2);
            this.panel2.Controls.Add(this.textBoxSetVoltage2);
            this.panel2.Controls.Add(this.textBoxSetCurrent2);
            this.panel2.Controls.Add(this.buttonSetVoltage2);
            this.panel2.Controls.Add(this.buttonSetCurrent1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxSetCurrent1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 482);
            this.panel2.TabIndex = 35;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(30, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 502);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "multimeter control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "power supply controller";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(512, 81);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(567, 473);
            this.zedGraphControl1.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(787, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 38;
            this.button2.Text = "CREATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.graphButton_Click_1);
            // 
            // miliseconds
            // 
            this.miliseconds.Location = new System.Drawing.Point(668, 574);
            this.miliseconds.Name = "miliseconds";
            this.miliseconds.Size = new System.Drawing.Size(104, 22);
            this.miliseconds.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 625);
            this.Controls.Add(this.miliseconds);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxSetVoltage1;
        private System.Windows.Forms.Button buttonSetVoltage1;
        private System.Windows.Forms.Button buttonSetVoltage2;
        private System.Windows.Forms.TextBox textBoxSetVoltage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSetCurrent2;
        private System.Windows.Forms.TextBox textBoxSetCurrent2;
        private System.Windows.Forms.Button buttonSetCurrent1;
        private System.Windows.Forms.TextBox textBoxSetCurrent1;
        private System.Windows.Forms.Button buttonOutput1;
        private System.Windows.Forms.ComboBox comboBoxPorts2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AcDc;
        private System.Windows.Forms.ComboBox meters;
        private System.Windows.Forms.ComboBox values;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button readValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button autoRange;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox miliseconds;
    }
}

