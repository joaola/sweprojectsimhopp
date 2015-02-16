using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simhoppprojekt
{
    public partial class NyttHopp : Form
    {
        private Hopplist person;
        public NyttHopp()
        {
            
            InitializeComponent();
        }
        public NyttHopp(Hopplist person)
        {
            this.person = person;
            InitializeComponent();
        }
        
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
            this.person.AddHopp(temphopp);
            //if (this.EventNewHopp != null)
            //    this.EventNewHopp();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // ångra
        {
           
        }
        
        #region domare
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = antaldomdrop.SelectedItem;
            if(selectedItem.ToString() == "3")
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
            
            else if(selectedItem.ToString() == "5")
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

        private void NyttHopp_Load(object sender, EventArgs e)
        {
            this.simnamn.Text = this.person.getNamn();
            antaldomdrop.SelectedItem = "3";
            hojddrop.SelectedItem = "1";
            stilDrop.SelectedItem = "A";
        }

        private void UpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
