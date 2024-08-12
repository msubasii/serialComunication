using System.Drawing;
using System.IO.Ports;

using System.Windows.Forms;

namespace serialPortDeneme2
{
    class powerSupply
    {
        public void voltageSetter(SerialPort spPowerSupply, string voltage, int channel)
        {

            
            float newVoltage = float.Parse(voltage);
            if (newVoltage >= 0 && newVoltage <= 30)
            {
                spPowerSupply.WriteLine($"VSET{channel}:{newVoltage}");
            }
            else
            {
                MessageBox.Show("Voltaj değeri 0 ile 30 arasında olmalı.");
            }
        }
        public void currentSetter(SerialPort spPowerSupply, string current, int channel)
        {


            float newVoltage = float.Parse(current);
            if (newVoltage >= 0 && newVoltage <= 30)
            {
                spPowerSupply.WriteLine($"ISET{channel}:{newVoltage}");
            }
            else
            {
                MessageBox.Show("Voltaj değeri 0 ile 30 arasında olmalı.");
            }
        }
        public void voltageFiller(SerialPort spPowerSupply, TextBox textBox,int channel)
        {
            spPowerSupply.WriteLine($"VSET{channel}?");
            string voltage = spPowerSupply.ReadLine();
            textBox.Text = voltage.Substring(0, voltage.Length - 2);
        }
        public void currentFiller(SerialPort spPowerSupply, TextBox textBox,int channel)
        {
            spPowerSupply.WriteLine($"ISET{channel}?");
            string current = spPowerSupply.ReadLine();
            textBox.Text = current.Substring(0, current.Length - 2);
        }
        public void outputControl(bool controller,Button buttonOutput1, SerialPort spPowerSupply)
        {
            if (controller)
            {
                buttonOutput1.Text = ("OUTPUT MODE: OFF");
                buttonOutput1.BackColor = Color.IndianRed;
                spPowerSupply.WriteLine($"OUT0");
                controller = false;
            }
            else
            {
                buttonOutput1.Text = ("OUTPUT MODE: ON");
                buttonOutput1.BackColor = Color.GreenYellow;
                spPowerSupply.WriteLine($"OUT1");
                controller = true;
            }
        }
    }
}
