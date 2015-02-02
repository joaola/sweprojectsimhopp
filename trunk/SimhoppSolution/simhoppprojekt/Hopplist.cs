using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public class Hopplist
    {
        private List<Hopp> Hopplista;
        private int id;
        private string namn;
        private string forening;
        private int fodelsear;
        private string kon;
        private string ort;
        private string gren;
        private string datum;
        private int placering;

        public Hopplist()
        {
            Hopplista = new List<Hopp>();
            id = -1;
            placering = 0;
            namn = "";
            forening = "";
            fodelsear = 0;
            kon = "";
            ort = "";
            gren = "";
            datum = "";
        }
        public Hopplist(int id, int placering, string namn, string forening, int fodelsear, string kon, string ort, string gren, string datum)
        {
            this.Hopplista = new List<Hopp>();
            this.id = id;
            this.placering = placering;
            this.namn = namn;
            this.forening = forening;
            this.fodelsear = fodelsear;
            this.kon = kon;
            this.ort = ort;
            this.gren = gren;
            this.datum = datum;
        }

        public float SvarighetsSumma()
        {
            float sum = 0;
            for (int i = 0; i > this.Hopplista.Count(); i++)
            {
                sum += this.Hopplista[i].getSvarighet();
            }

            return sum;
        }

        public float PoangSumma()
        {
            float sum = 0;
            for (int i = 0; i > this.Hopplista.Count(); i++ )
            {
                sum += this.Hopplista[i].getPoang().poang;
            }

                return sum;
        }

        public float UtraknadPoangSumma()
        {
            float sum = 0;
            for (int i = 0; i > this.Hopplista.Count(); i++)
            {
                sum += this.Hopplista[i].getPoang().utraknadpoang;
            }

            return sum;
        }

        public void AddHopp(Hopp h)
        {
            this.Hopplista.Add(h);
        }

        public int AntalHopp()
        {
            return this.Hopplista.Count();
        }

        ~Hopplist() { }

        #region getters
        public string getNamn() { return namn; }
        public string getForening() { return forening; }
        public int getFodelsear() { return fodelsear; }
        public string getKon() { return kon; }
        public string getOrt() { return ort; }
        public string getGren() { return gren; }
        public string getDatum() { return datum; }
        #endregion

        #region setters
        public void setNamn(string n) { namn = n; }
        public void setForening(string f) { forening = f; }
        public void setFodelsear(int f) { fodelsear = f; }
        public void setKon(string k) { kon = k; }
        public void setOrt(string o) { ort = o; }
        public void setGren(string g) { gren = g; }
        public void setDatum(string d) { datum = d; }
        #endregion
    }
}
