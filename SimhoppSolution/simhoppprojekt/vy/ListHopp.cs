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
        #region data
        Hopplist person;
        #endregion

        #region constr
        public ListHopp()
        {
            InitializeComponent();
        }
        public ListHopp(Hopplist h1)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            int lastitem = -1;
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && item.RowIndex != lastitem)
                {
                    List<Hopp> persHopp = this.person.getHopplista();
                    Hopp Olikahopp = persHopp[item.RowIndex];
                    
                    RedigeraHopp redig = new RedigeraHopp(Olikahopp);
                    redig.ShowDialog();
                }
                lastitem = item.RowIndex;
            }
            this.drawTable();
        }
        private void remove_Click(object sender, EventArgs e)
        {
            List<int> indexList = new List<int>();
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && !indexList.Contains(item.RowIndex))
                {
                    //this.EventDeletePers(item.RowIndex);
                    indexList.Add(item.RowIndex);
                }

            }
            indexList.Sort();
            for (int i = indexList.Count - 1; i >= 0; i--)
            {
                this.person.RemoveHopp(indexList[i]);
            }
            this.drawTable();
        }
        #endregion


        private void ListHopp_Load(object sender, EventArgs e)
        {
            this.drawNamn();
            this.drawTable();
        }

        #region draws
        private void drawNamn()
        {
            this.simnamn1.Text = person.getNamn();
        }
        private void drawTable()
        {
            this.poangsumbox.Text = this.person.UtraknadPoangSumma().ToString();
            List<Hopp> tempHopplista =  person.getHopplista();

            if(tempHopplista.Count == 0)
            {
                dataGridView1.Rows.Clear();
            }
            while (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows.RemoveAt(0);

            for (int i = 0; i < tempHopplista.Count ; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i <tempHopplista.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = tempHopplista[i].getHoppNr();
                this.dataGridView1.Rows[i].Cells[1].Value = tempHopplista[i].getHojd();
                this.dataGridView1.Rows[i].Cells[2].Value = tempHopplista[i].getStil();
                this.dataGridView1.Rows[i].Cells[3].Value = tempHopplista[i].getSvarighet();
                List<float> tempbetyg =  tempHopplista[i].getBetyg();
                string stringbetyg = "";
                for(int j = 0; j <tempbetyg.Count; j++)
                {
                    stringbetyg += tempbetyg[j];
                    if(j!=tempbetyg.Count-1)
                        stringbetyg += " | ";
                    
                }
                this.dataGridView1.Rows[i].Cells[4].Value = stringbetyg;
                this.dataGridView1.Rows[i].Cells[5].Value = tempHopplista[i].getPoang().utraknadpoang;
            }
        }

        #endregion


    }
}
