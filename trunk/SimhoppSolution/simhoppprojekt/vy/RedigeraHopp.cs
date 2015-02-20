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
    public partial class RedigeraHopp : Form
    {
        #region data
        Hopp person;
        #endregion

        #region constr
        public RedigeraHopp()
        {
            InitializeComponent();
        }

        public RedigeraHopp(Hopp h1)
        {
            this.person = h1;
            InitializeComponent();
        }
        #endregion

        private void RedigeraHopp_Load(object sender, EventArgs e)
        {
            HoppkodBox.Text = person.getHoppNr().ToString();
            svarighetsbox.Text = person.getSvarighet().ToString();
            hojddrop.SelectedItem = person.getHojd().ToString();
            stilDrop.SelectedItem = person.getStil();
            antaldomdrop.SelectedItem = person.getBetyg().Count.ToString();
            #region betyg
            if(person.getBetyg().Count == 3)
            {
                UpDown1.Visible = true;
                UpDown2.Visible = true;
                UpDown3.Visible = true;
                domare1.Visible = true;
                domare2.Visible = true;
                domare3.Visible = true;

                UpDown1.Value = (decimal)person.getBetyg()[0];
                UpDown2.Value = (decimal)person.getBetyg()[1];
                UpDown3.Value = (decimal)person.getBetyg()[2];
            }
            else if(person.getBetyg().Count == 5)
            {
                UpDown1.Visible = true;
                UpDown2.Visible = true;
                UpDown3.Visible = true;
                UpDown4.Visible = true;
                UpDown5.Visible = true;
                domare1.Visible = true;
                domare2.Visible = true;
                domare3.Visible = true;
                domare4.Visible = true;
                domare5.Visible = true;

                UpDown1.Value = (decimal)person.getBetyg()[0];
                UpDown2.Value = (decimal)person.getBetyg()[1];
                UpDown3.Value = (decimal)person.getBetyg()[2];
                UpDown4.Value = (decimal)person.getBetyg()[3];
                UpDown5.Value = (decimal)person.getBetyg()[4];
            }
            else
            {
                UpDown1.Visible = true;
                UpDown2.Visible = true;
                UpDown3.Visible = true;
                UpDown4.Visible = true;
                UpDown5.Visible = true;
                UpDown6.Visible = true;
                UpDown7.Visible = true;
                domare1.Visible = true;
                domare2.Visible = true;
                domare3.Visible = true;
                domare4.Visible = true;
                domare5.Visible = true;
                domare6.Visible = true;
                domare7.Visible = true;

                UpDown1.Value = (decimal)person.getBetyg()[0];
                UpDown2.Value = (decimal)person.getBetyg()[1];
                UpDown3.Value = (decimal)person.getBetyg()[2];
                UpDown4.Value = (decimal)person.getBetyg()[3];
                UpDown5.Value = (decimal)person.getBetyg()[4];
                UpDown6.Value = (decimal)person.getBetyg()[5];
                UpDown7.Value = (decimal)person.getBetyg()[6];
            }
            #endregion
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region read
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
            #endregion

            #region set
            this.person.setHoppNr(hoppkod);
            this.person.setSvarighet(svarighet);
            this.person.setHojd(hojd);
            this.person.setStil(stil);
            this.person.setBetyg(tempbetyg);
            this.person.setPoang();
            this.person.setTotal();
            #endregion

            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void antaldomdrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region domare
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
            #endregion
        }
    }
}
