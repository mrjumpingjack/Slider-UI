using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slieder_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool isconnected = false;

        SerialPort serialport= new SerialPort();

        private bool dc = false;

        private void Form1_Load(object sender, EventArgs e)
        {

            serialport.DtrEnable = true;
            cb_serialport.Items.Clear();

            foreach (String sp in SerialPort.GetPortNames())
            {

                cb_serialport.Items.Add(sp);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialport.Write("1,min");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialport.Write("1,max");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isconnected == false)
            {
                serialport = new SerialPort(cb_serialport.Text, 9600);
                try
                {
                    serialport.DtrEnable = true;
                    serialport.Open();
                    Thread.Sleep(1000);
                    serialport.DtrEnable = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Serialport could not be opend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (serialport.IsOpen)
                {
                    serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    isconnected = true;
                    btn_serialconnect.Text = "Disconnect";

                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                }
            }
            else
            {
                serialport.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
                serialport.Close();
                btn_serialconnect.Text = "Connect";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();


            UpdateMessages(indata);
        }

      
        private void UpdateMessages(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(this.UpdateMessages), message);
            }
            else
            {

                this.tb_serial.Text = this.tb_serial.Text + Environment.NewLine + message;

                if (message.StartsWith("minX:"))
                {

                }

                if (message.StartsWith("maxX:"))
                {

                }

                if (message.StartsWith("Gesammtlänge X:"))
                {

                }
                tb_serial.SelectionStart = tb_serial.Text.Length;
                tb_serial.ScrollToCaret();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //serialport.Write("8:0:" + Convert.ToString(trackBar1.Value) + ":" + Convert.ToString(trackBar1.Value));
            //Thread.Sleep(1000);
            serialport.Write("1:0:" + tb_message.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialport.Write("0");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (textBox2.Text.Length > 0)
            //{
            //    if (Convert.ToInt32(textBox2.Text) <= trackBar1.Maximum && Convert.ToInt32(textBox2.Text) >= trackBar1.Minimum)
            //    {
            //trackBar1.Value = Convert.ToInt32(textBox2.Text);
            //    }
            //}
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_speed.Text = trbar_speed.Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialport.Write("8:0:" + tb_speed.Text);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            tb_break.Text = trbar_break.Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialport.Write("8:0:" + 100000 + ":" + tb_speed.Text + ":" + "mil");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arg2;
            if (chebo_manuel.Checked)
            {
                arg2 = "m";
            }
            else
            {
                arg2 = "a";
            }

            serialport.Write("9:0:" + nud_delay.Value + ":" + arg2 + ":" + nud_steps.Value + ":" + tb_start.Text + ":" + tb_stop.Text);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            cb_serialport.Items.Clear();

            foreach (String sp in SerialPort.GetPortNames())
            {
                cb_serialport.Items.Add(sp);
            }
        }

        private void btn__Click(object sender, EventArgs e)
        {
            tb_start.Text = "min";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tb_start.Text = "max";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tb_stop.Text = "max";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_stop.Text = "min";
        }

        private void btn_pendel_Click(object sender, EventArgs e)
        {
            serialport.Write("4:0:" + nud_pendel_delay.Value + ":" + nud_laps.Value);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            serialport.Write("1:0:min");
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            serialport.Write("1:0:max");
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            serialport.Write(tb_message.Text);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            serialport.Write("11:0:" + nud_wc.Value);
        }

        private void trbar_speed_Scroll(object sender, EventArgs e)
        {
            tb_speed.Text = trbar_speed.Value.ToString();
        }

        private void btn_setspeed_Click(object sender, EventArgs e)
        {
            serialport.Write("8:0:" + tb_speed.Text);
        }

        private void btn_setbreak_Click(object sender, EventArgs e)
        {
            serialport.Write("7:0:" + tb_break.Text);
        }

        private void trbar_break_Scroll(object sender, EventArgs e)
        {
            tb_break.Text = trbar_break.Value.ToString();
        }

        private void tb_speed_TextChanged(object sender, EventArgs e)
        {
            trbar_speed.Value = Convert.ToInt32(tb_speed.Text);
        }

        private void tb_break_TextChanged(object sender, EventArgs e)
        {
            trbar_break.Value = Convert.ToInt32(tb_break.Text);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            serialport.Write("next");
        }

        private void chebo_manuel_CheckedChanged(object sender, EventArgs e)
        {
            if (chebo_manuel.Checked)
            {
                btn_next.Enabled = true;
            }
            else
            {
                btn_next.Enabled = false;
            }
        }


        public double Maping(double value, double fromSource, double toSource, double fromTarget, double toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }

        private void btn_start_dc_Click(object sender, EventArgs e)
        {
            if (dc)
            {
                dc = false;
                serialport.WriteLine("Exit");
            }
            else
            {
                serialport.WriteLine("12");

                var myController = BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault(); 

                string old_msg = "0";
                string new_msg="0";

                double newtsp = Maping(myController.ThumbRightX, 0, 100, -100, 100);
               

                while (!myController.ButtonBackPressed)
                {
                    newtsp = Maping(myController.ThumbRightX, 0, 100, -100, 100);

                    if (newtsp == 0)
                    {
                        new_msg = "0";
                    }
                    else
                    {
                        if (newtsp <= 0)
                        {
                            new_msg = "-1000";
                        }
                        else if (newtsp >= 0)
                        {
                            new_msg = "1000";
                        }
                    }


                    if (old_msg != new_msg)
                    {
                        serialport.WriteLine(new_msg);
                        old_msg = new_msg;
                    }

                    Application.DoEvents();
                    Refresh();
                    //Thread.Sleep(100);
                }
                serialport.Write("Exit");
                dc = true;
            }
        }

        private void btn_go_home_Click(object sender, EventArgs e)
        {
            serialport.Write("1:0:home");
        }

        private void btn_set_home_Click(object sender, EventArgs e)
        {
            serialport.Write("3:0");
        }

       

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                serialport.Write("14:1:" + nud_turns.Value.ToString() + ":" + nud_Tspeed.Value.ToString()+":l");
            }
            else
            {
                serialport.Write("14:1:" + nud_turns.Value.ToString() + ":" + nud_Tspeed.Value.ToString() + ":r");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_2(object sender, EventArgs e)
        {

        }

        private void button8_Click_2(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar1_MouseUp_1(object sender, MouseEventArgs e)
        {

        }

        private void cb_serialport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
