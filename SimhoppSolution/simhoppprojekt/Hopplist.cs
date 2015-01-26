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
        private string namn;
        private string forening;
        private int fodelsear;
        private string kon;
        private string tavling;
        private string ort;
        private string gren;
        private string datum;
        private int placering;

        public Hopplist(int placering, string namn, string forening, int fodelsear, string kon, string tavling, string ort, string gren, string datum)
        {
            this.placering = placering;
            this.namn = namn;
            this.forening = forening;
            this.fodelsear = fodelsear;
            this.kon = kon;
            this.tavling = tavling;
            this.ort = ort;
            this.gren = gren;
            this.datum = datum;
        }

        public float SvarighetsSumma()
        {
            float sum = 0;


            return sum;
        }

        public float PoangSumma()
        {
            float sum = 0;

            return sum;
        }

        public int Placering()
        {

            return ;
        }


        ~Hopplist() { }

        #region getters
        public string getNamn() { return namn; }
        public string getForening() { return forening; }
        public int getFodelsear() { return fodelsear; }
        public string getKon() { return kon; }
        public string getTavling() { return tavling; }
        public string getOrt() { return ort; }
        public string getGren() { return gren; }
        public string getDatum() { return datum; }
        #endregion

        #region setters
        public void setNamn(string n) { namn = n; }
        public void setForening(string f) { forening = f; }
        public void setFodelsear(int f) { fodelsear = f; }
        public void setKon(string k) { kon = k; }
        public void setTavling(string t) { tavling = t; }
        public void setOrt(string o) { ort = o; }
        public void setGren(string g) { gren = g; }
        public void setDatum(string d) { datum = d; }
        #endregion
    }
}
