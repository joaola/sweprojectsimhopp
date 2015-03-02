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
    public partial class Redigera : Form
    {
        private Hopplist person;

        #region constr
        public Redigera()
        {
            InitializeComponent();
        }
        public Redigera(Hopplist person)
        {
            this.person = person;
            InitializeComponent();
        }
        #endregion

        #region clicks
        private void OkReg_Click(object sender, EventArgs e)
        {
            #region read
            string namn = this.NamnReg.Text;
            int id;
            int.TryParse(this.IDreg.Text, out id);
            string forening = this.ForeningReg.Text;
            int fodelsear;
            int.TryParse(this.BirthReg.Text, out fodelsear);
            string kon = this.GenderReg.Text;
            string ort = this.OrtReg.Text;
            #endregion

            #region setstuff
            this.person.setNamn(namn);
            this.person.setID(id);
            this.person.setForening(forening);
            this.person.setFodelsear(fodelsear);
            this.person.setKon(kon);
            this.person.setOrt(ort);
            #endregion

            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void Redigera_Load(object sender, EventArgs e)
        {
            this.NamnReg.Text = this.person.getNamn();
            this.IDreg.Text = this.person.getID().ToString();
            this.ForeningReg.Text = this.person.getForening();
            this.BirthReg.Text = this.person.getFodelsear().ToString();
            this.GenderReg.Text = this.person.getKon();
            this.OrtReg.Text = this.person.getOrt();
        }
    }
}
