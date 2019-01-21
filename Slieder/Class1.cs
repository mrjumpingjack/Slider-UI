using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Slider
{
    /// <summary>
    /// 1:0:0
    /// 1:Aktion
    /// 2:Achse
    /// 3...:Parameter
    /// </summary>

    public class Slider
    {

        public int min = 0;
        public int max = 65000;

       

        public event EventHandler<string> dataRecived;
        public bool SerialConnected = false;

        SerialPort serialport;
        public void Init()
        {
            AvailablePorts = GetPorts();
        }

        public List<String> AvailablePorts = new List<string>();

        public List<string> GetPorts()
        {
            List<String> serialports = new List<string>();
            foreach (String sp in SerialPort.GetPortNames())
            {

                serialports.Add(sp);
            }
            return serialports;

        }




        public bool connect(string adress, int baut)
        {
            if (SerialConnected == false)
            {
                serialport = new SerialPort(adress, baut);
                try
                {
                    serialport.DtrEnable = true;
                    serialport.Open();
                    Thread.Sleep(1000);
                    serialport.DtrEnable = false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Serialport could not be opend", ex);
                }

                if (serialport.IsOpen)
                {
                    serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    SerialConnected = true;

                }
            }
            return SerialConnected;
        }

        public void disconnect()
        {
            serialport.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialport.Close();
            SerialConnected = false;
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();

            dataRecived?.Invoke(this, indata);
        }


        public void sendData(string data)
        {
            serialport.Write(data);
        }


        public void Pendeln(string laps, string speed, string acc)
        {
            serialport.Write("2:" + min + ":" + max + ":" + laps + ":" + speed + ":" + acc);
        }


        public void GoToMin(string speed, string acc)
        {
            serialport.Write("1:" + min + ":" + speed + ":" + acc);
        }

        public void GoToMax(string speed, string acc)
        {
            serialport.Write("1:" + max + ":" + speed + ":" + acc);
        }
    }
}
