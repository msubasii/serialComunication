using System.Drawing;
using System.IO.Ports;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace serialPortDeneme2
{
    class multimeter
    {
        public void valuesFiller(ComboBox AcDc, ComboBox meters,ComboBox values)
        {
            if (AcDc.SelectedItem == "AC")
            {
                if (meters.SelectedItem == "Voltage")
                {
                    values.Items.Add("300mV");
                    values.Items.Add("3V");
                    values.Items.Add("30V");
                    values.Items.Add("300V");
                    values.Items.Add("750V");
                }
                if (meters.SelectedItem == "Ohms")
                {
                    values.Items.Add("300 Ω");
                    values.Items.Add("3 kΩ");
                    values.Items.Add("30 kΩ");
                    values.Items.Add("300 kΩ");
                    values.Items.Add("300 kΩ");
                    values.Items.Add("3 MΩ");
                    values.Items.Add("30 MΩ");
                    values.Items.Add("300 MΩ");
                }
                if (meters.SelectedItem == "Current")
                {
                    values.Items.Add("30 mA");
                    values.Items.Add("100 mA");
                    values.Items.Add("10 A");
                }
                if (meters.SelectedItem == "Frequency")
                {
                    values.Items.Add("1000 Hz");
                    values.Items.Add("10 kHz");
                    values.Items.Add("100 kHz");
                    values.Items.Add("1000 kHz");
                    values.Items.Add("1 MHz");
                }
            }
            if (AcDc.SelectedItem == "DC")
            {
                if (meters.SelectedItem == "Voltage")
                {
                    values.Items.Add("300mV");
                    values.Items.Add("3V");
                    values.Items.Add("30V");
                    values.Items.Add("300V");
                    values.Items.Add("1000V");
                }
                if (meters.SelectedItem == "Ohms")
                {
                    values.Items.Add("300 Ω");
                    values.Items.Add("3 kΩ");
                    values.Items.Add("30 kΩ");
                    values.Items.Add("300 kΩ");
                    values.Items.Add("300 kΩ");
                    values.Items.Add("3 MΩ");
                    values.Items.Add("30 MΩ");
                    values.Items.Add("300 MΩ");
                }
                if (meters.SelectedItem == "Current")
                {
                    values.Items.Add("30 mA");
                    values.Items.Add("100 mA");
                    values.Items.Add("10 A");
                }
                if (meters.SelectedItem == "Frequency")
                {
                    values.Items.Add("1000 Hz");
                    values.Items.Add("10 kHz");
                    values.Items.Add("100 kHz");
                    values.Items.Add("1000 kHz");
                    values.Items.Add("1 MHz");
                }
            }
        }
        public void meterFiller(ComboBox meters)
        {
            meters.Items.Add("Voltage");
            meters.Items.Add("Ohms");
            meters.Items.Add("Current");
            meters.Items.Add("Frequency");
        }
        public void setter(ComboBox comboBoxPorts2,ComboBox meters, ComboBox values,SerialPort multimeter)
        {
            //AC
            if (comboBoxPorts2.SelectedIndex == 1)
            {

                //voltage
                if (meters.SelectedIndex == 0)
                {
                    multimeter.WriteLine("VAC");
                }
                //ohm
                if (meters.SelectedIndex == 1)
                {
                    multimeter.WriteLine("OHMS");
                }
                //current
                if (meters.SelectedIndex == 2)
                {
                    multimeter.WriteLine("AAC");
                }
                //frequency
                if (meters.SelectedIndex == 3)
                {
                    multimeter.WriteLine("FREQ");

                }
            }
            //DC
            if (comboBoxPorts2.SelectedIndex == 0)
            {
                //voltage
                if (meters.SelectedIndex == 0)
                {
                    multimeter.WriteLine("VDC");
                }
                //ohm
                if (meters.SelectedIndex == 1)
                {
                    multimeter.WriteLine("OHMS");
                }
                //current
                if (meters.SelectedIndex == 2)
                {
                    multimeter.WriteLine("ADC");
                }
                //frequency
                if (meters.SelectedIndex == 3)
                {
                    multimeter.WriteLine("FREQ");

                }
            }


            multimeter.WriteLine("RANGE " + (values.SelectedIndex + 1).ToString());
        }
    }
}





