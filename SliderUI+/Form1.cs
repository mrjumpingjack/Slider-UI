using Slider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliderUI_
{
    public partial class Form1 : Form
    {
        Slider.Slider slider = new Slider.Slider();

        public Form1()
        {
            InitializeComponent();

            slider.dataRecived += Slider_dataRecived;
        }

        private void Slider_dataRecived(object sender, string e)
        {
            tb_serial.Invoke((MethodInvoker)delegate
            {
                tb_serial.Text += e + Environment.NewLine;

            });
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            slider.Init();
            foreach (var item in slider.AvailablePorts)
            {
                cb_serialport.Items.Add(item);
            }
            try
            {
                cb_serialport.Text = slider.AvailablePorts.First(port => port.Contains("ACM"));
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            slider.GoToMin(tb_speed.Text, tb_break.Text);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            slider.GoToMax(tb_speed.Text, tb_break.Text);
        }

        private void btn_serialconnect_Click(object sender, EventArgs e)
        {
            if (slider.SerialConnected == false)
            {
                
                if (!String.IsNullOrEmpty(cb_serialport.Text))
                    slider.connect(cb_serialport.Text, 9600);

                slider.SerialConnected = true;
                btn_serialconnect.Text = "Disconnect";
            }
            else
            {
                slider.SerialConnected = false;
                slider.disconnect();
                btn_serialconnect.Text = "Conncet";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slider.Pendeln(numericUpDown1.Value.ToString(), tb_speed.Text, tb_break.Text);
        }
    }
}
