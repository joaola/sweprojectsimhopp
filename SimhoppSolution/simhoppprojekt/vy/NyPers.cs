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
    /// <summary>
    ///  Formen NyPers används för att lägga till en ny person, med information om simhopparen.
    /// </summary>
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
            int id;
            int.TryParse(this.IDbox.Text, out id);
            string forening = this.ForeningBox.Text;
            int fodelsear;
            int.TryParse(this.BirthBox.Text, out fodelsear);
            string kon = this.GenderBox.Text;
            string ort = this.OrtBox.Text;
            Hopplist tempKurt = new Hopplist(id, namn, forening, fodelsear, kon, ort);
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
