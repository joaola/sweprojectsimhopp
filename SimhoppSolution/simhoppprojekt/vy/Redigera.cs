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
        public Redigera()
        {
            InitializeComponent();
        }

        private static Redigera inst;
        public static Redigera GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Redigera();
                return inst;
            }
        }

        private void OkReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
