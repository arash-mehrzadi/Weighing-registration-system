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

namespace Smart_House_App
{
    public partial class frmsystemcontrol : Form
    {
        SerialPort led = new SerialPort();
        public frmsystemcontrol()
        {
            InitializeComponent();
            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "com5";
            myport.Open();
            led = myport;
            //myport.WriteLine("aa");
            //Console.WriteLine();
            //    while (true)
            //    {
            //        //string data_rx = myport.ReadLine();
            //        Console.WriteLine('A');
            //    }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnconnecting.Enabled = false;
            controlpanel.Enabled = false;
            txtpassword.Enabled = false;
            txtusername.Enabled = false;

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (btnstart.Text == "START")
            {
                txtpassword.Enabled = true;
                txtusername.Enabled = true;
                btnstart.Text = "CONFIG";
            }
            else if (btnstart.Text == "CONFIG")
            {
                if (txtpassword.Text == "admin" && txtusername.Text == "admin")
                {
                    controlpanel.Enabled = true;
                    btnconnecting.Enabled = true;
                    btnstart.Text = "STOP";
                }
                else
                {
                    MessageBox.Show("Username or Password is inccorect !");
                    txtusername.Text = "";
                    txtpassword.Text = "";
                }
            }
            else if (btnstart.Text == "STOP") 
            {
                controlpanel.Enabled = false;
                txtpassword.Enabled = false;
                txtusername.Enabled = false;
                btnconnecting.Enabled = false;
                txtpassword.Text = "";
                txtusername.Text = "";
                btnstart.Text = "START";
            }
        }

        private void clickonoff(object sender, EventArgs e)
        {
            if(((Button)sender).Text=="off")
            {
                ((Button)sender).Text = "on";
                ((Button)sender).BackColor = Color.Yellow;
                //string s;
                //s = "btnlight1";
                //if (s==(((Button)sender).Name))
                //{
                //    led.WriteLine("aa");
                //}
                switch ((((Button)sender).Name))
                {
                    case "btnlight1":
                        led.WriteLine("aa");
                        break;
                    case "btnlight2":
                        led.WriteLine("cc");
                        break;
                    case "btnlight3":
                        led.WriteLine("ee");
                        break;
                    case "btnlight4":
                        led.WriteLine("gg");
                        break;
                    case "btnlight5":
                        led.WriteLine("ii");
                        break;
                }
            }
            else if(((Button)sender).Text=="on")
            {
                ((Button)sender).Text = "off";
                ((Button)sender).BackColor = Color.Gray;
                switch ((((Button)sender).Name))
                {
                    case "btnlight1":
                        led.WriteLine("bb");
                        break;
                    case "btnlight2":
                        led.WriteLine("dd");
                        break;
                    case "btnlight3":
                        led.WriteLine("ff");
                        break;
                    case "btnlight4":
                        led.WriteLine("hh");
                        break;
                    case "btnlight5":
                        led.WriteLine("jj");
                        break;
                }
            }
        }

        private void btnconnecting_Click(object sender, EventArgs e)
        {
            if(btnconnecting.Text== "Connect")
            {
                lblconnecting.Text = "Connect";
                lblconnecting.BackColor = Color.Green;
                btnconnecting.Text = "DISCONNECT";
            }
            else if (btnconnecting.Text=="DISCONNECT")
            {
                lblconnecting.Text = "DISCONNECT";
                lblconnecting.BackColor = Color.Red;
                btnconnecting.Text = "Connect";
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
