/*
 * Created by SharpDevelop.
 * User: Worker
 * Date: 11/16/2018
 * Time: 11:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Counter
{
    public partial class MainForm : Form
    {
        private ArrayList cards = new ArrayList();
        private Module[] modules = {new Module(), new Module()};

        public MainForm()
        {
            InitializeComponent();
            modules[0].led = led1;
            modules[0].portBox = portsBox1;
            modules[0].port = serialPort1;
            modules[0].connect = connect1;

            modules[1].led = led2;
            modules[1].portBox = portsBox2;
            modules[1].port = serialPort2;
            modules[1].connect = connect2;

            foreach (var module in modules)
            {
                foreach (var port in SerialPort.GetPortNames())
                {
                    module.portBox.Items.Add(port);
                    module.portBox.Text = port;
                }

                module.port.DataReceived += port_DataReceived;
                module.led.BackColor = Color.FromArgb(0, 0, 255, 0);
            }
        }


        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            foreach (var module in modules)
            {
                if (!module.port.IsOpen) continue;
                while (module.port.BytesToRead > 0)
                {
                    var command = module.port.ReadTo("=");
                    var value = module.port.ReadTo(";");
                    Print("Receive: " + command + "=" + value);
                    if (command.Equals("card"))
                    {
                        module.CurrentCard = value;
                    }
                    else if (command.Equals("detect"))
                    {
                        if (value.Equals("0"))
                        {
                            SetButtonColor(module.led, Color.Red);
                            if (module.CurrentCard.Length > 0)
                            {
                                module.IsWaiting = true;
                            }
                        }
                        else
                        {
                            SetButtonColor(module.led, Color.Green);
                            if (module.IsWaiting)
                            {
                                if (cards.Contains(module.CurrentCard))
                                {
                                    cards.Remove(module.CurrentCard);
                                }
                                else
                                {
                                    cards.Add(module.CurrentCard);
                                }

                                SetText(counter, "Số người trong phòng: " + cards.Count);
                                SetText(logger, String.Join("\n", cards.ToArray()));
                                SendToArduino(module.port, "echo=No of people: " + cards.Count);
                                module.CurrentCard = "";
                                module.IsWaiting = false;
                            }
                        }
                    }
                }
            }
        }


        private static void Print(string s)
        {
            Debug.WriteLine(s);
        }

        private static void SetText(Control label, string text)
        {
            label.Invoke((MethodInvoker) delegate { label.Text = text; });
        }


        private static void SetButtonColor(Control button, Color color)
        {
            button.Invoke((MethodInvoker) delegate { button.BackColor = color; });
        }

        void Connect1Click(object sender, EventArgs e)
        {
            ConnectClick(modules[0]);
        }

        private void ConnectClick(Module module)
        {
            if (module.port.IsOpen)
            {
                module.port.Close();
                module.connect.Text = @"Kết nối";
            }
            else
            {
                module.port.PortName = module.portBox.Text;
                module.port.Open();
                module.connect.Text = @"Ngắt kết nối";
                SendToArduino(module.port, "poll=0;");
            }
        }

        private void SendToArduino(SerialPort port, string text)
        {
            if (port.IsOpen)
            {
                port.Write(text);
                Print("Sent command: " + text);
            }
            else
            {
                Print("Serial is not opened yet");
            }
        }


        void Connect2Click(object sender, EventArgs e)
        {
            ConnectClick(modules[1]);
        }
    }

    class Module
    {
        public Button led, connect;
        public ComboBox portBox;
        public SerialPort port;
        public string CurrentCard = "";
        public bool IsWaiting = false;
    }
}