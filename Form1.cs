using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.ComponentModel.Design;
using static System.Windows.Forms.LinkLabel;
using ZedGraph;


namespace serialPortDeneme2
{
    public partial class Form1 : Form
    {

        powerSupply powerSupplyClass = new powerSupply();
        multimeter multimeterClass = new multimeter();
        SerialPort spPowerSupply = new SerialPort();
        SerialPort multimeter = new SerialPort();
        GraphPane GraphPane;
        
        private bool controller = false;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var seriPort in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(seriPort);
            }
            foreach (var seriPort in SerialPort.GetPortNames())
            {
                comboBoxPorts2.Items.Add(seriPort);
            }
            buttonDisconnect.Enabled = false;
        }

        private void GetSerialPorts()
        {
            comboBoxPorts.Items.Clear();
            comboBoxPorts2.Items.Clear();
           

            foreach (var seriPorts in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(seriPorts);
            }
            foreach (var seriPort in SerialPort.GetPortNames())
            {
                comboBoxPorts2.Items.Add(seriPort);
            }
        }
        //connects the powerSupply to pc
        public void buttonConnect_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            foreach (var seriPorts in SerialPort.GetPortNames())
            {
                if (!spPowerSupply.IsOpen)
                {
                    try
                    {
                        spPowerSupply.PortName = seriPorts.ToString();
                        spPowerSupply.BaudRate = 9600;
                        spPowerSupply.Parity = Parity.None;
                        spPowerSupply.StopBits = StopBits.One;
                        spPowerSupply.DataBits = 8;
                        spPowerSupply.Handshake = Handshake.None;
                        spPowerSupply.ReadTimeout = 1000;
                        spPowerSupply.Open();
                        spPowerSupply.WriteLine("*IDN?\n");
                        string response = spPowerSupply.ReadLine();

                        if ("GW INSTEK,GPD-3303S" == response.Substring(0, 19))
                        {
                            selectedIndex = Array.IndexOf(SerialPort.GetPortNames(), seriPorts);
                            buttonConnect.Enabled = false;
                            buttonDisconnect.Enabled = true;
                            break;
                        }
                        else
                        {
                            spPowerSupply.Close();
                        }
                    }
                    catch (TimeoutException)
                    {
                        spPowerSupply.Close();
                    }
                    catch (Exception)
                    {
                        spPowerSupply.Close();
                    }
                }

            }
            if (spPowerSupply.IsOpen)
            {
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                comboBoxPorts.SelectedIndex = selectedIndex;

                //voltage1
                powerSupplyClass.voltageFiller(spPowerSupply, textBoxSetVoltage1, 1);
                //current1
                powerSupplyClass.currentFiller(spPowerSupply, textBoxSetCurrent1, 1);
                //voltage2
                powerSupplyClass.voltageFiller(spPowerSupply, textBoxSetVoltage2, 2);
                //current2
                powerSupplyClass.currentFiller(spPowerSupply, textBoxSetCurrent2, 2);

                //on-off situation checker
                spPowerSupply.WriteLine($"STATUS?");
                string statusResponse = spPowerSupply.ReadLine();

                if (statusResponse[5] == '1')
                {
                    buttonOutput1.Text = ("OUTPUT MODE: ON");
                    buttonOutput1.BackColor = Color.GreenYellow;
                    controller = true;
                }
                else
                {
                    buttonOutput1.Text = ("OUTPUT MODE: OFF");
                    buttonOutput1.BackColor = Color.IndianRed;
                    controller = false;
                }
            }
        }
        //disconnects the powerSupply from pc
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (spPowerSupply.IsOpen)
            {
                spPowerSupply.Close();
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
            }
        }
        //no letter in textBox checker
        private void txtVoltageSet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
        //Channel 1 Voltage 
        private void textBoxSetVoltage1_TextChanged(object sender, EventArgs e)
        {
        }
        private void buttonSetVoltage1_Click(object sender, EventArgs e)
        {
            string voltage1 = textBoxSetVoltage1.Text;
            powerSupplyClass.voltageSetter(spPowerSupply, voltage1, 1);
        }
        //Channel 1 Current
        private void textBoxSetCurrent1_TextChanged(object sender, EventArgs e)
        {
        }
        private void buttonSetCurrent1_Click(object sender, EventArgs e)
        {
            string Current1 = textBoxSetCurrent1.Text;
            powerSupplyClass.currentSetter(spPowerSupply, Current1, 1);
        }
        //Channel 2 Voltage 
        private void textBoxSetVoltage2_TextChanged(object sender, EventArgs e)
        {
        }
        private void buttonSetVoltage2_Click(object sender, EventArgs e)
        {
            string voltage2 = textBoxSetVoltage2.Text;
            powerSupplyClass.voltageSetter(spPowerSupply, voltage2, 2);
        }
        //Channel 2 Current
        private void textBoxSetCurrent2_TextChanged(object sender, EventArgs e)
        {
        }
        private void buttonSetCurrent2_Click(object sender, EventArgs e)
        {
            string Current2 = textBoxSetCurrent2.Text;
            powerSupplyClass.currentSetter(spPowerSupply, Current2, 2);
        }
        //output control and fill the button
        private void buttonOutput1_Click(object sender, EventArgs e)
        {
            powerSupplyClass.outputControl(controller, buttonOutput1, spPowerSupply);
        }
        //logOut checker
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (spPowerSupply.IsOpen)
            {
                spPowerSupply.WriteLine($"OUT0");
            }
            Application.Exit();
        }

        //multimeter connect button
        private void multimeterConnect_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            foreach (var seriPort in SerialPort.GetPortNames())
            {
                if (!multimeter.IsOpen)
                {
                    multimeter.PortName = seriPort.ToString();
                    multimeter.BaudRate = 9600;
                    multimeter.Parity = Parity.None;
                    try
                    {
                        multimeter.ReadTimeout = 1000;
                        multimeter.Open();
                        multimeter.WriteLine("*IDN?\n");
                        string response = multimeter.ReadLine();
                        string response1 = multimeter.ReadLine();
                        string response2 = multimeter.ReadLine();


                        if ("FLUKE, 45" == response2.Substring(0, 9))
                        {
                            selectedIndex = Array.IndexOf(SerialPort.GetPortNames(), seriPort);
                            button1.Enabled = false;
                            connectButton.Enabled = true;
                            break;
                        }
                        else
                        {
                            multimeter.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("I/O error occurred. Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir port seçin.");
                }
            }
            if (multimeter.IsOpen)
            {
                button1.Enabled = false;
                connectButton.Enabled = true;
                comboBoxPorts2.SelectedIndex = selectedIndex;
                AcDc.Items.Clear();
                AcDc.Items.Add("AC");
                AcDc.Items.Add("DC");
            }
        }
        //multimeter disconnet button
        private void button2_Click(object sender, EventArgs e)
        {
            if (multimeter.IsOpen)
            {
                multimeter.Close();
                button1.Enabled = true;
                connectButton.Enabled = false;
            }
        }
        private void comboBoxPorts2_Click(object sender, EventArgs e)
        {
            GetSerialPorts();
        }
        private void AcDc_SelectedIndexChanged(object sender, EventArgs e)
        {
            meters.Items.Clear();
            multimeterClass.meterFiller(meters);
        }

        private void meters_SelectedIndexChanged(object sender, EventArgs e)
        {
            values.Items.Clear();
            multimeterClass.valuesFiller(AcDc,meters,values);
        }

        private void readValue_Click_1(object sender, EventArgs e)
        {
            multimeter.WriteLine("MEAS1?");
            string measurement = multimeter.ReadLine();

                bool checkPoint = true;
                do
                {
                    string line = multimeter.ReadLine();
                    if (line.Substring(0, 1) == "+" || line.Substring(0, 1) == "-")
                    {
                        MessageBox.Show(line);
                        checkPoint = false;
                    }
                } while (checkPoint);
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            multimeterClass.setter(comboBoxPorts2,meters, values, multimeter);
        }
        bool control = true;
        private void autoRange_Click(object sender, EventArgs e)
        {
            multimeter.WriteLine("AUTO");
            values.Text = "AUTO";
            control = false;
        }

        private void graphButton_Click_1(object sender, EventArgs e)
        {
            
        }

        GraphPane myPane = zedGraphControl1.GraphPane;
        // style the plot
        zedGraphControl1.GraphPane.Title.Text = $"Plot";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "Per X Miliseconds";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Readen Values";
       
    }
}