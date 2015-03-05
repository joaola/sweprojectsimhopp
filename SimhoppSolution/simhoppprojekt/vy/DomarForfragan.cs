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
    public partial class DomarForfragan : Form
    {
        private int domare;
        private List<string> domIp = new List<string>();
        public Thread t;
        private const int listenPort = 9058;
        public DomarForfragan()
        {
            InitializeComponent();
        }

        public DomarForfragan(int antalDomare,List<string> domIp)
        {
            domare = antalDomare;
            this.domIp = domIp;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<TextBox> lt = new List<TextBox>();
            #region add
            lt.Add(domarebox1);
            lt.Add(domarebox2);
            lt.Add(domarebox3);
            lt.Add(domarebox4);
            lt.Add(domarebox5);
            lt.Add(domarebox6);
            lt.Add(domarebox7);
            #endregion
            for (int i = 0; i < this.domare; i++)
            {
                if (lt[i].Text != "")
                    this.domIp.Add(lt[i].Text);
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DomarForfragan_Load(object sender, EventArgs e)
        {
            List<TextBox> lt = new List<TextBox>();
            #region add
            lt.Add(domarebox1);
            lt.Add(domarebox2);
            lt.Add(domarebox3);
            lt.Add(domarebox4);
            lt.Add(domarebox5);
            lt.Add(domarebox6);
            lt.Add(domarebox7);
            #endregion
            List<TextBox> lt2 = new List<TextBox>();
            #region add
            lt2.Add(domare1);
            lt2.Add(domare2);
            lt2.Add(domare3);
            lt2.Add(domare4);
            lt2.Add(domare5);
            lt2.Add(domare6);
            lt2.Add(domare7);
            #endregion
            for(int i = 0; i < lt.Count; i++)
            {
                if (i < domare)
                {
                    lt[i].Enabled = true;
                    lt[i].Visible = true;
                    lt2[i].Visible = true;
                }
                else
                {
                    lt[i].Enabled = false;
                    lt[i].Visible = false;
                    lt2[i].Visible = false;
                }
            }
        }

    }
}
