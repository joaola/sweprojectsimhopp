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
    public partial class Form1 : Form, IForm1
    {
        #region events
        public event DelegateNewPers EventNewPers = null;
        public event DelegateGetTavling EventGetTavling = null;
        public event DelegateDeletePers EventDeletePers = null;
        public event DelegateGetHopplistor EventGetHopplistor = null;
        public event DelegateGetTavlingsnamn EventGetTavlingsnamn = null;
        public event DelegateGetDatum EventGetDatum = null;
        public event DelegateSetDatum EventSetDatum = null;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawTable();
            drawDate();
            textBox1.Text = this.EventGetTavlingsnamn();
        }


        #region draws
        private void drawTable()
        {
            List<Hopplist> persons = this.EventGetHopplistor();

            if (persons.Count == 0)
                dataGridView1.Rows.Clear();

            while (dataGridView1.Rows.Count != 1)
                dataGridView1.Rows.RemoveAt(0);

            for (int i = 0; i < persons.Count - 1; i++)
            {
                dataGridView1.Rows.Add();
            }


            for (int i = 0; i < persons.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = persons[i].getNamn();
                dataGridView1.Rows[i].Cells[2].Value = persons[i].getHopplista().Count;
                dataGridView1.Rows[i].Cells[3].Value = persons[i].UtraknadPoangSumma();
            }
        }

        private void drawDate()
        {
            this.datum.Text = this.EventGetDatum();
        }

        #endregion

        #region clicks
        private void button1_Click(object sender, EventArgs e)
        {

            NyPers np = new NyPers(this.EventGetTavling());
            np.ShowDialog();
            //this.EventNewPers();
            this.drawTable();                       
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
            NyttHopp ny = new NyttHopp();
            ny.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Redigera reggie = new Redigera();
            reggie.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && this.EventGetHopplistor().Count!=0)
                {
                    List<Hopplist>persons = this.EventGetHopplistor();
                    Hopplist person = persons[item.RowIndex];
                    PersonInfo info = new PersonInfo(person);
                    info.ShowDialog();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && this.EventGetHopplistor().Count != 0)
                {
                    List<Hopplist> persons = this.EventGetHopplistor();
                    Hopplist person = persons[item.RowIndex];
                    ListHopp lh = new ListHopp(person);
                    lh.ShowDialog();
                }
            }
            
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells) 
            {
                if (item.Selected)
                {
                    this.EventDeletePers(item.RowIndex);
                    this.Form1_Load(sender, e); 
                }
            }

        }

        #endregion

        private void datum_ValueChanged(object sender, EventArgs e)
        {
            //string tempdatum = this.datum.Text;
            this.EventSetDatum(this.datum.Text);
            this.drawDate();
        }

    }
}
