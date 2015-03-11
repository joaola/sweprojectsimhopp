using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
        public event DelegateSetTavling EventSetTavling = null;
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
            this.drawTable();                       
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Read();
        } // read

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Save();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            List<int> indexList = new List<int>();
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && !indexList.Contains(item.RowIndex))
                {
                    indexList.Add(item.RowIndex);
                    List<Hopplist> persons = this.EventGetHopplistor();
                    Hopplist person = persons[item.RowIndex];
                    NyttHopp nyh = new NyttHopp(person);
                    nyh.ShowDialog();
                }
            }
            this.EventSort();
            this.drawTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> indexList = new List<int>();
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && !indexList.Contains(item.RowIndex))
                {
                    indexList.Add(item.RowIndex);
                    List<Hopplist> persons = this.EventGetHopplistor();
                    Hopplist person = persons[item.RowIndex];
                    Redigera reggie = new Redigera(person);
                    reggie.ShowDialog();
                }   
              
            }
            this.drawTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> indexList = new List<int>();
            foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                if (item.Selected && !indexList.Contains(item.RowIndex))
                {
                    indexList.Add(item.RowIndex);
                    List<Hopplist> persons = this.EventGetHopplistor();
                    Hopplist person = persons[item.RowIndex];
                    ListHopp lh = new ListHopp(person);
                    lh.ShowDialog();
                }        
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
        private void nyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(() => threadNewTavling(new TavlingsClass()));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
        }
        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Read();
        }
        private void innehallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string caption = "Programinformation";
            MessageBox.Show("Tryck och håll in ALT-tangenten för att komma åt kortkommandon för tangentbordet. Ta bort personer och hopp med Delete-knappen.", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string caption = "Om";
            MessageBox.Show("Gjort av Patrik, Mikael, Joakim och Hampus.", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PDFtoolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.ExportPDF();
                const string caption = "Klart!";
                MessageBox.Show("Exportering lyckades!", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.ExportPDF();
                const string caption = "Klart!";
                MessageBox.Show("Exportering lyckades!", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                const string caption = "Error";
                MessageBox.Show(ex.ToString(), caption);
            }
        }
        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        public static void threadNewTavling(TavlingsClass t1)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();

            PresenterForm1 presenter = new PresenterForm1(form1, t1);
            Application.Run(form1);
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

        private void Read()
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
                            #region read
                            // Insert code to read the stream here.
                            StreamReader file = new StreamReader(myStream);
                            List<Hopplist> templist = new List<Hopplist>();
                            List<Hopp> templisthopp = new List<Hopp>();
                            string temp=null;
                            string readDatum = file.ReadLine();

                            string readTavling = file.ReadLine();

                            //int i = 0;
                            if(!file.EndOfStream)
                                temp = file.ReadLine();

                            while(!file.EndOfStream)
                            {                               
                                if(temp == ":")
                                {
                                    string readNamn = file.ReadLine();
                                    int readID = Convert.ToInt32(file.ReadLine());
                                    string readForening = file.ReadLine();
                                    int readFodelse = Convert.ToInt32(file.ReadLine());
                                    string readKon = file.ReadLine();
                                    string readOrt = file.ReadLine();

                                    Hopplist tempPerson = new Hopplist(readID, readNamn, readForening, readFodelse, readKon, readOrt);

                                    temp = file.ReadLine();
                                    if(temp == "-")
                                    {
                                        while(temp != ":" && temp!=null)
                                        {
                                            int readHoppNr = Convert.ToInt32(file.ReadLine());
                                            string readStil = file.ReadLine();
                                            float readSvarighet = Convert.ToSingle(file.ReadLine());
                                            int readHojd = Convert.ToInt32(file.ReadLine());
                                            int readDomare = Convert.ToInt32(file.ReadLine());
                                            List<float> tempbetyg = new List<float>();
                                            for (int i = 0; i < readDomare; i++ )
                                            {
                                                tempbetyg.Add(Convert.ToSingle(file.ReadLine()));
                                            }

                                            Hopp temphopp = new Hopp(readHoppNr, readStil, readSvarighet,readHojd, tempbetyg);
                                            tempPerson.AddHopp(temphopp);

                                            temp = file.ReadLine();
                                        }
                                        
                                    }
                                    templist.Add(tempPerson); 
                                }
                            }
                            TavlingsClass temptavling = new TavlingsClass(readTavling, readDatum, templist);

                            if (EventGetHopplistor().Count != 0)
                            {
                                System.Threading.Thread t = new System.Threading.Thread(() => threadNewTavling(temptavling));
                                t.SetApartmentState(System.Threading.ApartmentState.STA);
                                t.Start();
                            }

                            else
                            {
                                EventSetTavling(temptavling);
                                this.drawDate();
                                this.drawTable();
                                this.drawTavling();
                            }
                            #endregion
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void ExportPDF()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(EventGetTavlingsnamn() + ".pdf", FileMode.Create));
            TavlingsClass temptavling = EventGetTavling();
            doc.Open();

            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.DottedLineSeparator()));
            Paragraph line2 = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

            Paragraph tnamn = new Paragraph("               Tävling: " + EventGetTavlingsnamn(), times);
            Paragraph tdatum = new Paragraph("               Datum: " + EventGetDatum(), times);
            doc.Add(tnamn);
            doc.Add(tdatum);
            doc.Add(new Paragraph("\n \n"));

            doc.Add(new Paragraph("               Översikt", times));
            doc.Add(new Paragraph("\n"));
            PdfPTable t1 = new PdfPTable(4);
            t1.AddCell("Placering");
            t1.AddCell("Namn");
            t1.AddCell("Antal Hopp");
            t1.AddCell("Poäng");
            for (int i = 0; i < temptavling.AntalTavlande(); i++)
            {
                t1.AddCell((i + 1).ToString());
                t1.AddCell(temptavling.getHopplistor()[i].getNamn());
                t1.AddCell(temptavling.getHopplistor()[i].getHopplista().Count.ToString());
                t1.AddCell(temptavling.getHopplistor()[i].UtraknadPoangSumma().ToString());
            }
            doc.Add(t1);
            doc.Add(new Paragraph("\n"));
            doc.Add(line2);
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("          Simhoppare", times));

            for (int i = 0; i < temptavling.AntalTavlande(); i++)
            {
                PdfPTable t2 = new PdfPTable(6);
                List list = new List(List.UNORDERED, 40f);

                list.Add("Namn: " + temptavling.getHopplistor()[i].getNamn());
                list.Add("ID: " + temptavling.getHopplistor()[i].getID().ToString());
                list.Add("Förening: " + temptavling.getHopplistor()[i].getForening());
                list.Add("Födelseår: " + temptavling.getHopplistor()[i].getFodelsear().ToString());
                list.Add("Kön: " + temptavling.getHopplistor()[i].getKon());
                list.Add("Ort: " + temptavling.getHopplistor()[i].getOrt());

                t2.AddCell("Hoppkod");
                t2.AddCell("Höjd");
                t2.AddCell("Stil");
                t2.AddCell("Svårighetsgrad");
                t2.AddCell("Betyg");
                t2.AddCell("Poäng");
                for (int j = 0; j < EventGetHopplistor()[i].getHopplista().Count; j++)
                {
                    t2.AddCell(EventGetHopplistor()[i].getHopplista()[j].getHoppNr().ToString());
                    t2.AddCell(EventGetHopplistor()[i].getHopplista()[j].getHojd().ToString());
                    t2.AddCell(EventGetHopplistor()[i].getHopplista()[j].getStil());
                    t2.AddCell(EventGetHopplistor()[i].getHopplista()[j].getSvarighet().ToString());
                    string tempstring = "";
                    for (int k = 0; k < EventGetHopplistor()[i].getHopplista()[j].getBetyg().Count; k++)
                    {
                        if (k == EventGetHopplistor()[i].getHopplista()[j].getBetyg().Count - 1)
                        {
                            tempstring += EventGetTavling().getHopplistor()[i].getHopplista()[j].getBetyg()[k].ToString();
                        }
                        else
                            tempstring += EventGetTavling().getHopplistor()[i].getHopplista()[j].getBetyg()[k].ToString() + " | ";
                    }
                    t2.AddCell(tempstring);
                    t2.AddCell(EventGetHopplistor()[i].getHopplista()[j].getPoang().utraknadpoang.ToString());
                }
                doc.Add(new Paragraph("\n"));
                doc.Add(list);
                doc.Add(new Paragraph("\n"));
                doc.Add(t2);
                doc.Add(new Paragraph("\n"));
                doc.Add(line);
                doc.Add(new Paragraph("\n"));
            }

            doc.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Tavlingsnamn.ContainsFocus == false && e.KeyCode == Keys.Delete)
            {
                button3_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                sparaToolStripMenuItem_Click(sender, e);
            }

            else if (e.Control && e.KeyCode == Keys.O)
            {
                openToolStripMenuItem_Click(sender, e);
            }

            else if (e.Control && e.KeyCode == Keys.N)
            {
                nyToolStripMenuItem_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Är du säker på att du vill stänga ner?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        

    }
}
