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
    public partial class PersonInfo : Form
    {
        #region data
        Hopplist person;
        #endregion

        #region constr
        public PersonInfo()
        {
            InitializeComponent();
            //this.index =index;
        }
        public PersonInfo(Hopplist h1)
        {
            this.person = h1;
            InitializeComponent();
        }
        #endregion

        #region clicks
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void PersonInfo_Load(object sender, EventArgs e)
        {
            this.namnruta.Text = person.getNamn();
            this.IDruta.Text = person.getID().ToString();
            this.foreningruta.Text = person.getForening();
            this.fodeseruta.Text = person.getFodelsear().ToString();
            this.konruta.Text = person.getKon();
            this.ortruta.Text = person.getOrt();
        }
        

    }
}
