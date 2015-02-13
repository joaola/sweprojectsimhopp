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
    public partial class ListHopp : Form
    {
        public ListHopp()
        {
            InitializeComponent();
        }

        #region clicks
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }
        #endregion
    }
}
