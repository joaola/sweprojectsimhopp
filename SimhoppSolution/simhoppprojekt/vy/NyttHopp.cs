using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace simhoppprojekt
{
    public partial class NyttHopp : Form
    {
        private Hopplist person;
        private const int listenPort = 9058;
        private List<string> domIp = new List<string>();
        private System.Threading.Thread t = new Thread(() => { });
        private int index = 0;
        public NyttHopp()
        {
            
            InitializeComponent();
        }
        public NyttHopp(Hopplist person)
        {
            this.person = person;
            InitializeComponent();
        }

        #region domare
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = antaldomdrop.SelectedItem;
            if (selectedItem.ToString() == "3")
            {

                domare1.Visible = true;
                domare2.Visible = true;
                domare3.Visible = true;
                domare4.Visible = false;
                domare5.Visible = false;
                domare6.Visible = false;
                domare7.Visible = false;
                UpDown1.Visible = true;
                UpDown2.Visible = true;
                UpDown3.Visible = true;
                UpDown4.Visible = false;
                UpDown5.Visible = false;
                UpDown6.Visible = false;
                UpDown7.Visible = false;

                // nollställ
                UpDown4.Value = 0;
                UpDown5.Value = 0;
                UpDown6.Value = 0;
                UpDown7.Value = 0;
            }

            else if (selectedItem.ToString() == "5")
            {

                domare1.Visible = true;
                domare2.Visible = true;
                domare3.Visible = true;
                domare4.Visible = true;
                domare5.Visible = true;
                domare6.Visible = false;
                domare7.Visible = false;
                UpDown1.Visible = true;
                UpDown2.Visible = true;
                UpDown3.Visible = true;
                UpDown4.Visible = true;
                UpDown5.Visible = true;
                UpDown6.Visible = false;
                UpDown7.Visible = false;

                // nollställ
                UpDown6.Value = 0;
                UpDown7.Value = 0;
            }

            else
            {

                domare1.Visible = true;
                domare2.Visible = true;
                domare3.Visible = true;
                domare4.Visible = true;
                domare5.Visible = true;
                domare6.Visible = true;
                domare7.Visible = true;
                UpDown1.Visible = true;
                UpDown2.Visible = true;
                UpDown3.Visible = true;
                UpDown4.Visible = true;
                UpDown5.Visible = true;
                UpDown6.Visible = true;
                UpDown7.Visible = true;
            }

        }
        #endregion

        #region clicks
        private void button3_Click(object sender, EventArgs e) // räkna
        {
            int hoppkod;
            int.TryParse(this.HoppkodBox.Text, out hoppkod);
            float svarighet;
            float.TryParse(this.svarighetsbox.Text, out svarighet);
            int hojd;
            int.TryParse(this.hojddrop.Text, out hojd);
            string stil = this.stilDrop.Text;
            int antaldom;
            int.TryParse(this.antaldomdrop.Text, out antaldom);
            List<float> tempbetyg = new List<float>();

            if (antaldom == 3)
            {
                tempbetyg.Add((float)this.UpDown1.Value);
                tempbetyg.Add((float)this.UpDown2.Value);
                tempbetyg.Add((float)this.UpDown3.Value);
            }
            else if (antaldom == 5)
            {
                tempbetyg.Add((float)this.UpDown1.Value);
                tempbetyg.Add((float)this.UpDown2.Value);
                tempbetyg.Add((float)this.UpDown3.Value);
                tempbetyg.Add((float)this.UpDown4.Value);
                tempbetyg.Add((float)this.UpDown5.Value);
            }
            else if (antaldom == 7)
            {
                tempbetyg.Add((float)this.UpDown1.Value);
                tempbetyg.Add((float)this.UpDown2.Value);
                tempbetyg.Add((float)this.UpDown3.Value);
                tempbetyg.Add((float)this.UpDown4.Value);
                tempbetyg.Add((float)this.UpDown5.Value);
                tempbetyg.Add((float)this.UpDown6.Value);
                tempbetyg.Add((float)this.UpDown7.Value);
            }



            Hopp temphopp = new Hopp(hoppkod,stil,svarighet,hojd,tempbetyg);
            this.poangbox.Text = temphopp.raknaPoang().utraknadpoang.ToString();
        }

        private void button1_Click(object sender, EventArgs e) // ok
        {

            int hoppkod;
            int.TryParse(this.HoppkodBox.Text, out hoppkod);
            float svarighet;
            float.TryParse(this.svarighetsbox.Text, out svarighet);
            int hojd;
            int.TryParse(this.hojddrop.Text, out hojd);
            string stil = this.stilDrop.Text;
            int antaldom;
            int.TryParse(this.antaldomdrop.Text, out antaldom);
            List<float> tempbetyg = new List<float>();
            #region add
            if (antaldom == 3)
            {
                tempbetyg.Add((float)this.UpDown1.Value);
                tempbetyg.Add((float)this.UpDown2.Value);
                tempbetyg.Add((float)this.UpDown3.Value);
            }
            else if (antaldom == 5)
            {
                tempbetyg.Add((float)this.UpDown1.Value);
                tempbetyg.Add((float)this.UpDown2.Value);
                tempbetyg.Add((float)this.UpDown3.Value);
                tempbetyg.Add((float)this.UpDown4.Value);
                tempbetyg.Add((float)this.UpDown5.Value);
            }
            else if (antaldom == 7)
            {
                tempbetyg.Add((float)this.UpDown1.Value);
                tempbetyg.Add((float)this.UpDown2.Value);
                tempbetyg.Add((float)this.UpDown3.Value);
                tempbetyg.Add((float)this.UpDown4.Value);
                tempbetyg.Add((float)this.UpDown5.Value);
                tempbetyg.Add((float)this.UpDown6.Value);
                tempbetyg.Add((float)this.UpDown7.Value);
            }
            #endregion


            Hopp temphopp = new Hopp(hoppkod,stil,svarighet,hojd,tempbetyg);
            this.person.AddHopp(temphopp);
            //if (this.EventNewHopp != null)
            //    this.EventNewHopp();
            this.Close();
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        #endregion

        private void NyttHopp_Load(object sender, EventArgs e)
        {
            this.simnamn.Text = this.person.getNamn();
            antaldomdrop.SelectedItem = "3";
            hojddrop.SelectedItem = "1";
            stilDrop.SelectedItem = "A";
        }

        #region udp/thread
        public void UdpReceive()
        {
            bool done = false;
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            string received_data = "";
            byte[] receive_byte_array;
            try
            {
                int i = 0;
                List<NumericUpDown> domare = new List<NumericUpDown>();
                #region addDomare
                domare.Add(this.UpDown1);
                domare.Add(this.UpDown2);
                domare.Add(this.UpDown3);
                domare.Add(this.UpDown4);
                domare.Add(this.UpDown5);
                domare.Add(this.UpDown6);
                domare.Add(this.UpDown7);
                #endregion
                int antaldomare = this.Getdomare();
                
                while (!done)
                {
                    if (listener.Available > 0)
                    {
                            
                        receive_byte_array = listener.Receive(ref groupEP);
                        received_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);
                        if (CheckIP(groupEP) == true)
                        {
                            if (received_data != "")
                            {
                                decimal domarvarde = Convert.ToDecimal(received_data);
                                if (domarvarde > 10)
                                    domarvarde = 10;
                                else if (domarvarde < 0)
                                    domarvarde = 0;
                                AppendTextBox(domarvarde, domare[index]);
                                i++;
                                received_data = "";
                                if (i >= antaldomare)
                                {
                                    this.unlockAntalDomare();
                                    done = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
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

        private bool CheckIP(IPEndPoint ipe)
        {
            for(int i = 0; i < domIp.Count; i++)
            {
                if(ipe.Address.ToString() == domIp[i])
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        private void UdpButton_Click(object sender, EventArgs e)
        {
            DomarForfragan df = new DomarForfragan(Convert.ToInt32(this.antaldomdrop.SelectedItem), domIp);
            df.ShowDialog();
            if(this.domIp.Count == Convert.ToInt32(this.antaldomdrop.SelectedItem))
            {
                UdpButton.Enabled = false;
                UdpButton.Text = "Väntar...";
                antaldomdrop.Enabled = false;
                t = new System.Threading.Thread(UdpReceive);
                t.IsBackground = true;
                t.Start();
            }
            else
                this.domIp = new List<string>();
        }

        public void unlockAntalDomare()
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    this.antaldomdrop.Enabled = true;
                    this.UdpButton.Enabled = true;
                    this.UdpButton.Text = "Begär betyg";
                    this.SendFunc("Judging closed.");
                });
            }
        }
        public void AppendTextBox(decimal value,NumericUpDown domarupd)
        {
            if (InvokeRequired)
            {
                
                //this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                this.Invoke((MethodInvoker)delegate()
                {
                    domarupd.Value = value;
                    domarupd.Enabled = false;
                });
            }
            
        }

        public int Getdomare()
        {
            int antaldomare = 0;
            if (InvokeRequired)
            {
                //this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                this.Invoke((MethodInvoker)delegate()
                {
                    antaldomare = Convert.ToInt32(this.antaldomdrop.SelectedItem);
                    
                });
                
            }
            return antaldomare;
        }

        private void NyttHopp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(t.IsAlive == true)
                t.Abort();
        }

        private void SendFunc(string s)
        {
            Boolean exception_thrown = false;
            Socket sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            for(int i = 0; i < domIp.Count; i++)
            {
                IPAddress send_to_address = IPAddress.Parse(domIp[i]);
                IPEndPoint sending_end_point = new IPEndPoint(send_to_address, 9059);
                string text_to_send = s;


                byte[] send_buffer = Encoding.ASCII.GetBytes(text_to_send);
                try
                {
                    sending_socket.SendTo(send_buffer, sending_end_point);
                }
                catch (Exception send_exception)
                {
                    exception_thrown = true;
                    //textBox1.Text = " Exception " + send_exception.Message;
                }
                if (exception_thrown == false)
                {
                    //textBox1.Text = "Message has been sent to the broadcast address";
                }
                else
                {
                    exception_thrown = false;
                    //textBox1.Text = "The exception indicates the message was not sent.";
                }
            }
            //IPAddress send_to_address = IPAddress.Parse("10.22.8.160");
        }
        #endregion
    }
}
