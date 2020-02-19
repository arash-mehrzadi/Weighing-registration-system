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
using System.Data.SqlClient;

namespace baskol_project
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#projects\baskol_project\baskol_project\databasbaskol.mdf;Integrated Security=True";
            conn.Open();
            fillgrid();
            txttitle.Enabled = false;
            txtyear.Enabled = false;
            txtmonth.Enabled = false;
            txtday.Enabled = false;
            txtorigin.Enabled = false;
            txtdestination.Enabled = false;
            txtcode.Enabled = false;
            serialPort1.PortName = "COM7";
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Parity = Parity.None;
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
                //btnconnection.ButtonText = "disconnected";
                //MessageBox.Show("please check your connection");
            }
            else
            {
                btnconnection.IdleFillColor = Color.Red;
                btnconnection.ActiveFillColor = Color.Pink;
                btnset.Enabled = false;
                btnoffon.Enabled = false;
            }
            //dataresiver();
        }
        public void dataresiver()
        {
            string x;
            if (serialPort1.IsOpen == false)
                serialPort1.Open();
            else
                return;
            x = serialPort1.ReadLine();
            txtshowdata.Text = x;
        }
        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            //txttitle.Enabled = true;
            //txtyear.Enabled = true;
            //txtmonth.Enabled = true;
            //txtday.Enabled = true;
            //txtorigin.Enabled = true;
            //txtdestination.Enabled = true;
            //txtcode.Enabled = true;
            string xr;
            serialPort1.DiscardInBuffer();
            xr = serialPort1.ReadLine();
            txtsetwiegh.Text = xr;
        }

        private void btnoffon_Click(object sender, EventArgs e)
        {
            string xem;
            if (btnoffon.ButtonText == "ON")
                btnoffon.ButtonText = "OFF";
            else if (btnoffon.ButtonText == "OFF")
            {
                btnoffon.ButtonText = "ON";
                while (btnoffon.ButtonText == "ON")
                {
                    serialPort1.DiscardInBuffer();
                    xem = serialPort1.ReadLine();
                    txtshowdata.Text = xem;
                }
            }
        }
        void fillgrid(string s= "select * from tblbaskool")
        {
            cmd.CommandText = s;
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds, "t1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "t1");
            cr = (CurrencyManager)this.BindingContext[ds, "t1"];
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "insert into tblbaskool values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            c1.Parameters.AddWithValue("p1", txtsetwiegh.Text);
            c1.Parameters.AddWithValue("p2", txttitle.Text);
            c1.Parameters.AddWithValue("p3", txtyear.Text);
            c1.Parameters.AddWithValue("p4", txtmonth.Text);
            c1.Parameters.AddWithValue("p5", txtday.Text);
            c1.Parameters.AddWithValue("p6", txtorigin.Text);
            c1.Parameters.AddWithValue("p7", txtdestination.Text);
            c1.Parameters.AddWithValue("p8", txtcode.Text);
            c1.Connection = conn;
            c1.ExecuteNonQuery();
            txtsetwiegh.Text = "";
            txttitle.Text = "";
            txtyear.Text = "";
            txtmonth.Text = "";
            txtday.Text = "";
            txtorigin.Text = "";
            txtdestination.Text = "";
            txtcode.Text = "";
            fillgrid();
        }

        private void txtsetwiegh_TextChanged(object sender, EventArgs e)
        {
            if (txtsetwiegh.Text == "")
            {
                txttitle.Enabled = false;
                txtyear.Enabled = false;
                txtmonth.Enabled = false;
                txtday.Enabled = false;
                txtorigin.Enabled = false;
                txtdestination.Enabled = false;
                txtcode.Enabled = false;
            }
            else
            {
                txttitle.Enabled = true;
                txtyear.Enabled = true;
                txtmonth.Enabled = true;
                txtday.Enabled = true;
                txtorigin.Enabled = true;
                txtdestination.Enabled = true;
                txtcode.Enabled = true;
                int yy, mm, dd;
                yy = DateTime.Now.Year;
                mm = DateTime.Now.Month;
                dd = DateTime.Now.Day;
                txtyear.Text = "";
                txtmonth.Text = "";
                txtday.Text = "";
                txtyear.Text = yy.ToString();
                txtmonth.Text = mm.ToString();
                txtday.Text = dd.ToString();           }
        }

        private void btntare_Click(object sender, EventArgs e)
        {
            serialPort1.Write("T");
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Z");
        }

        private void btnsetoption_Click(object sender, EventArgs e)
        {
            serialPort1.Write("p1=1");
        }

        private void btnconnection_Click(object sender, EventArgs e)
        {
            if(btnconnection.ButtonText== "Connected")
            {
                serialPort1.Close();
                btnconnection.ButtonText = "disconnected";
                btnconnection.IdleFillColor = Color.Red;
                btnconnection.ActiveFillColor = Color.Pink;
                btnset.Enabled = false;
                btnoffon.Enabled = false;
            }
            else
            {
                serialPort1.Open();
                btnconnection.ButtonText = "Connected";
                btnconnection.IdleFillColor = Color.FromArgb(128, 255, 128);
                btnconnection.ActiveFillColor = Color.SeaGreen;
                btnset.Enabled = true;
                btnoffon.Enabled = true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
