﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simhoppprojekt
{
    public partial class Form1 : Form, IForm1
    {
        #region events
        public event DelegateGetTavling EventGetTavling = null;
        public event DelegateDeletePers EventDeletePers = null;
        public event DelegateGetHopplistor EventGetHopplistor = null;
        public event DelegateGetTavlingsnamn EventGetTavlingsnamn = null;
        public event DelegateGetDatum EventGetDatum = null;
        public event DelegateSetDatum EventSetDatum = null;
        public event DelegateSetTavlingsnamn EventSetTavlingsnamn = null;
        public event DelegateSort EventSort = null;
        #endregion

        #region constr
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawTable();
            drawDate();
            drawTavling();
            
        }
        #endregion

        #region draws

        private void drawTavling()
        {
            this.Tavlingsnamn.Text = this.EventGetTavlingsnamn();
            this.Text = "HoppSIM - "+this.EventGetTavlingsnamn();
        }

        private void drawTable()
        {
            List<Hopplist> persons = this.EventGetHopplistor();

            if (persons.Count == 0)
                dataGridView1.Rows.Clear();

            while (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows.RemoveAt(0);

            for (int i = 0; i < persons.Count ; i++)
            {
                dataGridView1.Rows.Add();
            }

            int placeringsräknare = 1;
            for (int i = 0; i < persons.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = placeringsräknare;
                dataGridView1.Rows[i].Cells[1].Value = persons[i].getNamn();
                dataGridView1.Rows[i].Cells[2].Value = persons[i].getHopplista().Count;
                dataGridView1.Rows[i].Cells[3].Value = persons[i].UtraknadPoangSumma();
                if (persons.Count - 1 != i)
                {
                    if ((persons[i].UtraknadPoangSumma() != persons[i + 1].UtraknadPoangSumma()))
                        placeringsräknare++;
                }
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        } // read

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int lastItemIndex = -1;
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && this.EventGetHopplistor().Count != 0 && item.RowIndex != lastItemIndex)
                {
                    List<Hopplist> persons = this.EventGetHopplistor();
                    Hopplist person = persons[item.RowIndex];
                    NyttHopp nyh = new NyttHopp(person);
                    nyh.ShowDialog();
                }
                lastItemIndex = item.RowIndex;
            }
            this.EventSort();
            this.drawTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lastitem=-1;
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && item.RowIndex != lastitem)
                {
                    List<Hopplist> persons = this.EventGetHopplistor();
                    Hopplist person = persons[item.RowIndex];
                    Redigera reggie = new Redigera(person);
                    reggie.ShowDialog();
                }
                lastitem = item.RowIndex;
            }
            this.drawTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int lastItemIndex = -1;
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && this.EventGetHopplistor().Count != 0 && item.RowIndex != lastItemIndex)
                {
                    List<Hopplist> persons = this.EventGetHopplistor();
                    Hopplist person = persons[item.RowIndex];
                    ListHopp lh = new ListHopp(person);
                    lh.ShowDialog();
                }
                lastItemIndex = item.RowIndex;
            }
            this.EventSort();
            this.drawTable();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
                this.EventDeletePers(indexList[i]);
            }
            this.EventSort();
            this.drawTable();

        }

        private static void threadNewTavling()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            TavlingsClass t1 = new TavlingsClass();

            /*Hopplist kurt = new Hopplist(1, "Kurt", "slavicboyz", 1990, "?", "hallsberg", "3mmagplask");
            List<float> tempbetyg = new List<float>();
            tempbetyg.Add(10);
            tempbetyg.Add(8.5f);
            tempbetyg.Add(9f);
            tempbetyg.Add(8);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(6);
            kurt.AddHopp(new Hopp(101, "A", 1.5f, 3, tempbetyg));
            kurt.AddHopp(new Hopp(202, "A", 2f, 3, tempbetyg));
            t1.AddPerson(kurt);*/


            PresenterForm1 presenter = new PresenterForm1(form1, t1);
            Application.Run(form1);
        }
        private void nyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(threadNewTavling));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
        }
        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void innehallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("huehuehuehuehuehuehuehuehuehue");
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("huehuehuehuehuehuehuehuehuehue");
        } 
        #endregion

        private void datum_ValueChanged(object sender, EventArgs e)
        {
            //string tempdatum = this.datum.Text;
            this.EventSetDatum(this.datum.Text);
            this.drawDate();
        }

        private void Tavlingsnamn_TextChanged(object sender, EventArgs e)
        {
            this.EventSetTavlingsnamn(this.Tavlingsnamn.Text);
            this.drawTavling();
        }

        private void Save()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Can use dialog.FileName
                    using (Stream stream = dialog.OpenFile())
                    {
                        // Save data
                        #region savetävling
                        StreamWriter file = new StreamWriter(stream);
                        file.WriteLine(EventGetDatum());
                        file.WriteLine(EventGetTavlingsnamn());
                        #endregion

                        #region saveperson
                        for (int i = 0; i < EventGetTavling().getHopplistor().Count; i++)
                        {
                            file.WriteLine(":");
                            file.WriteLine(EventGetTavling().getHopplistor()[i].getNamn());
                            file.WriteLine(EventGetTavling().getHopplistor()[i].getID());
                            file.WriteLine(EventGetTavling().getHopplistor()[i].getForening());
                            file.WriteLine(EventGetTavling().getHopplistor()[i].getFodelsear());
                            file.WriteLine(EventGetTavling().getHopplistor()[i].getKon());
                            file.WriteLine(EventGetTavling().getHopplistor()[i].getOrt());
                            #endregion

                        #region savehopp
                            for (int j = 0; j < EventGetTavling().getHopplistor()[i].getHopplista().Count; j++)
                            {
                                file.WriteLine("-");
                                file.WriteLine(EventGetTavling().getHopplistor()[i].getHopplista()[j].getHoppNr());
                                file.WriteLine(EventGetTavling().getHopplistor()[i].getHopplista()[j].getStil());
                                file.WriteLine(EventGetTavling().getHopplistor()[i].getHopplista()[j].getSvarighet());
                                file.WriteLine(EventGetTavling().getHopplistor()[i].getHopplista()[j].getHojd());
                                file.WriteLine(EventGetTavling().getHopplistor()[i].getHopplista()[j].getBetyg().Count); //antal domare

                                for (int k = 0; k < EventGetHopplistor()[i].getHopplista()[j].getBetyg().Count; k++)
                                {
                                    file.WriteLine(EventGetTavling().getHopplistor()[i].getHopplista()[j].getBetyg()[k]);
                                }

                                //file.WriteLine(EventGetTavling().getHopplistor()[i].getHopplista()[j].getTotal());
                                //file.WriteLine(EventGetTavling().getHopplistor()[i].getHopplista()[j].getPoang().utraknadpoang);
                            }

                        }
                        #endregion

                        file.Close();
                        
                    }
                }
            }
        }       

    }
}