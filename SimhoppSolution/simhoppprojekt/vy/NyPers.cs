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
    public partial class NyPers : Form
    {

        #region data
        TavlingsClass t1;
        #endregion

        #region constr
        public NyPers()
        {
            InitializeComponent();
        }
        
        public NyPers(TavlingsClass t1)
        {
            this.t1 = t1;
            InitializeComponent();
        } 
        #endregion

        #region clicks
        private void OkButton_Click(object sender, EventArgs e)
        {
            string namn = this.Namnbox.Text;
            int id =-1;
            if (this.IDbox.Text!="")
                id = Convert.ToInt32(this.IDbox.Text);
            string forening = this.ForeningBox.Text;
            int fodelsear = -1;
            if (this.BirthBox.Text!="")
                fodelsear = Convert.ToInt32(this.BirthBox.Text);
            string kon = this.GenderBox.Text;
            string ort = this.OrtBox.Text;
            string gren = this.GrenBox.Text;
            Hopplist tempKurt = new Hopplist(id, namn, forening, fodelsear, kon, ort, gren);
            this.t1.AddPerson(tempKurt);
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

    }
}
