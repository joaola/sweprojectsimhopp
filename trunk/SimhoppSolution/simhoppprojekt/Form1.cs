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
    public partial class Form1 : Form
    {
        private TavlingsClass t1 = new TavlingsClass("tävling1");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string namn = this.t1.getNamn();
            textBox1.Text = namn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NyPers np = new NyPers();
            //np.Show();
            NyPers.GetForm.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //NyttHopp ny = new NyttHopp();
            //ny.Show();
            NyttHopp.GetForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Redigera reggie = new Redigera();
            //reggie.Show();
            Redigera.GetForm.Show();
        }



    }
}
