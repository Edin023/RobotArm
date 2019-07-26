using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        SerialPort Arduino;
        bool Connected = false;
        int BaudRate = 9600;
        int BaseAngle = 0;
        int ForearmAngle = 0;
        int GripperAngle = 0;

        public Form1()
        {
            InitializeComponent();
            SendTimer.Start();
            BaseRadio.Checked = true;
        }
        //Button for connecting Arduino with the program
        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            if (ConnectionButton.Text == "Connect")
            {
                if (comboBox1.Items.Count == 0)
                    MessageBox.Show("There are no devices connected" + '\n' + "Please refresh and than try again");
                else
                {
                    if (comboBox1.SelectedIndex != -1)
                    {
                        SerialInfo.Text = "Connected to " + comboBox1.Items[comboBox1.SelectedIndex].ToString();
                        Arduino = new SerialPort(comboBox1.Items[comboBox1.SelectedIndex].ToString(), BaudRate);
                        Arduino.Handshake = Handshake.RequestToSend;
                        Arduino.Open();
                        //Arduino.Write("Hello World!");
                        Connected = true;
                        ConnectionButton.Text = "Dissconnect";
                        BaseBar.Value = 0;
                        ForearmBar.Value = 0;
                        GripperBar.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("There is no selected serial" + '\n' + "Please select a device from the combobox");
                    }
                }
            }
            else
            {
                Arduino.Close();
                ConnectionButton.Text = "Connect";
                SerialInfo.Text=("Dissconected");
                Connected = false;

                BaseBar.Value = 0;
                ForearmBar.Value = 0;
                GripperBar.Value = 0;
            }
        }

        //Button for listing all the ports
        private void button1_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach(string port in ports)   // Adds new ports
            {
                bool exists = false;
                for(int i=0;i<comboBox1.Items.Count;i++)
                {
                    if(comboBox1.Items[i]==ports)
                    {
                        exists = true;
                    }
                }
                if(!exists)
                    comboBox1.Items.Add(port);
            }
            
            for (int i = 0; i < comboBox1.Items.Count; i++)     // Removes ports left behind
            {
                bool exists = false;
                foreach(string port in ports)
                {
                    if(comboBox1.Items[i]==port)
                    {
                        exists = true;
                        break;
                    }
                }
                if(!exists)
                {
                    comboBox1.Items.RemoveAt(i);
                    i--;
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void SendTimer_Tick(object sender, EventArgs e)
        {
            if(Connected)
            {
                BaseLabel.Text = "Base angle is " + BaseAngle;
                ForearmLabel.Text = "Forearm angle is " + ForearmAngle;
                GripperLabel.Text = "Gripper closure is at " + GripperAngle + "%";
                Arduino.WriteLine("B" + BaseAngle + "F" + ForearmAngle + "G" + GripperAngle+".");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 'b') // for the letter b
                BaseRadio.Checked = true;
            if (e.KeyChar == 'f') // for the letter f         
                ForearmRadio.Checked = true;
            if (e.KeyChar == 'g') // for the letter g
                GripperRadio.Checked = true;
            if(e.KeyChar == '1')
            {
                if(BaseRadio.Checked)
                {
                    BaseBar.Value += 1;
                }
                if(ForearmRadio.Checked)
                {
                    ForearmBar.Value += 1;
                }
                if(GripperRadio.Checked)
                {
                    GripperBar.Value += 1;
                }
            }
            if (e.KeyChar == '4')
            {
                if (BaseRadio.Checked)
                {
                    if (BaseBar.Value > 1)
                        BaseBar.Value -= 1;
                    else
                        BaseBar.Value = 0;
                }
                if (ForearmRadio.Checked)
                {
                    if (ForearmBar.Value > 1)
                        ForearmBar.Value -= 1;
                    else
                        ForearmBar.Value = 0;
                }
                if (GripperRadio.Checked)
                {
                    if (GripperBar.Value > 1)
                        GripperBar.Value -= 1;
                    else
                        GripperBar.Value = 0;
                }
            }
            if (e.KeyChar == '2')
            {
                if (BaseRadio.Checked)
                {
                    BaseBar.Value += 5;
                }
                if (ForearmRadio.Checked)
                {
                    ForearmBar.Value += 5;
                }
                if (GripperRadio.Checked)
                {
                    GripperBar.Value += 5;
                }
            }
            if (e.KeyChar == '5')
            {
                if (BaseRadio.Checked)
                {
                    if (BaseBar.Value > 5)
                        BaseBar.Value -= 5;
                    else
                        BaseBar.Value = 0;
                }
                if (ForearmRadio.Checked)
                {
                    if (ForearmBar.Value > 5)
                        ForearmBar.Value -= 5;
                    else
                        ForearmBar.Value = 0;
                }
                if (GripperRadio.Checked)
                {
                    if (GripperBar.Value > 5)
                        GripperBar.Value -= 5;
                    else
                        GripperBar.Value = 0;
                }
            }
            if (e.KeyChar == '3')
            {
                if (BaseRadio.Checked)
                {
                    BaseBar.Value += 10;
                }
                if (ForearmRadio.Checked)
                {
                    ForearmBar.Value += 10;
                }
                if (GripperRadio.Checked)
                {
                    GripperBar.Value += 10;
                }
            }
            if (e.KeyChar == '6')
            {
                if (BaseRadio.Checked)
                {
                    if (BaseBar.Value > 10)
                        BaseBar.Value -= 10;
                    else
                        BaseBar.Value = 0;
                }
                if (ForearmRadio.Checked)
                {
                    if (ForearmBar.Value > 10)
                        ForearmBar.Value -= 10;
                    else
                        ForearmBar.Value = 0;
                }
                if (GripperRadio.Checked)
                {
                    if (GripperBar.Value > 10)
                        GripperBar.Value -= 10;
                    else
                        GripperBar.Value = 0;
                }
            }
        }

        private void BaseBar_ValueChanged(object sender, EventArgs e)
        {
            BaseAngle = BaseBar.Value;
            ForearmAngle = ForearmBar.Value;
            GripperAngle = GripperBar.Value;
            if(Connected)
                EventsBox.Items.Add(DateTime.UtcNow.TimeOfDay.Hours + ":"+DateTime.UtcNow.TimeOfDay.Minutes + " B:" + BaseAngle + "F:" + ForearmAngle + "G:" + GripperAngle);
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To start the controls, first you need to connect the Arduino" + '\n' + "To do that go to refresh and then pick desired port." + '\n' + "After that click on Connect and you are all set." + '\n' + "Keyboard shortcuts are B for Base, F for forarm and G for Gripper." + '\n' + "Numbers 1,2,3 are for incresse with different corose, and 4,5,6 are for decresse.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
