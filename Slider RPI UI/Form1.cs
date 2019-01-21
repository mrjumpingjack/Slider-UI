using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Slider_RPI_UI
{
    public partial class Form1 : Form
    {
        SerialPort comport = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            comport.DtrEnable = true;
            comport.RtsEnable = true;
            try
            {
                comport.PortName = "/dev/ttyUSB0";
                comport.BaudRate = Convert.ToInt32(115200);
                comport.Open();
                if (comport.IsOpen)
                {
                    l_connstat.Text = "CONNECTED";
                }
            }
            catch (Exception c)
            {
                Console.WriteLine(c);
                return;
            }

        }

        private void l_connstat_Click(object sender, EventArgs e)
        {
            comport.DtrEnable = true;
            comport.RtsEnable = true;
            try
            {
                comport.PortName = "/dev/ttyUSB0";
                comport.BaudRate = Convert.ToInt32(115200);
                comport.Open();
                if (comport.IsOpen)
                {
                    l_connstat.Text = "CONNECTED";
                }
            }
            catch (Exception c)
            {
                Console.WriteLine(c);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comport.WriteLine("1:0:" + tb_goto.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comport.WriteLine("1:0:min:" + Convert.ToString(trackBar1.Value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comport.WriteLine("1:0:max:" + Convert.ToString(trackBar1.Value)); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comport.WriteLine("9:0:" + tb_delaytime.Text + ":" + cb_manuel.Checked.ToString() + ":" + trackBar2.Value + ":" + tbstart.Text + ":" + tbstop.Text);
        }
    }
}
