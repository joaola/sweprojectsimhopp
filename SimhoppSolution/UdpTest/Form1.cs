using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UdpSend
{
    public partial class Form1 : Form
    {
        private const int listenPort = 9059;
        private Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean exception_thrown = false;
            Socket sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress send_to_address = IPAddress.Parse("10.22.8.68");
            IPEndPoint sending_end_point = new IPEndPoint(send_to_address, 9058);

            textBox1.Text = "Skriv in och skicka domarpoäng.";
            string text_to_send = this.UpDown1.Value.ToString();
            
          
            byte[] send_buffer = Encoding.ASCII.GetBytes(text_to_send);
            try
            {
                sending_socket.SendTo(send_buffer, sending_end_point);
            }
            catch (Exception send_exception)
            {
                exception_thrown = true;
                textBox1.Text = " Exception " + send_exception.Message;
            }
            if (exception_thrown == false)
            {
                textBox1.Text = "Message has been sent to the broadcast address";
            }
            else
            {
                exception_thrown = false;
                textBox1.Text = "The exception indicates the message was not sent.";
            }
        }

        public void UdpReceive()
        {
            bool done = false;
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            string received_data = "";
            byte[] receive_byte_array;
            try
            {
                while (!done)
                {
                    if (listener.Available > 0)
                    {
                        receive_byte_array = listener.Receive(ref groupEP);
                        received_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);
                        
                        AppendTextBox(received_data);
                          
                    }
                    //else
                    //{
                    //    Thread.Sleep(100);
                    //}
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                listener.Close();
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    if(value == "Judging open." || value == "Judging closed.")
                        judgebox.Text = value;
                    else
                        textBox1.Text = value;
                });
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(UdpReceive);
            t.IsBackground = true;
            t.Start();
        }
    }
}

