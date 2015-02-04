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
        private static NyttHopp inst;
        public NyttHopp()
        {
            
            InitializeComponent();
        }
        public static NyttHopp GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new NyttHopp();
                return inst;
            }
        }

        private void button3_Click(object sender, EventArgs e) // räkna
        {

        }

        private void button1_Click(object sender, EventArgs e) // ok
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // ångra
        {
           
        }
        #region domare
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
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
            comboBox1.SelectedItem = "3";
        }
    }
}
