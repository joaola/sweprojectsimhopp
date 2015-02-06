﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public struct Poang
    {
        public float poang;
        public float utraknadpoang;
        

        public Poang(float poang,float utraknadpoang)
        {
            this.poang = poang;
            this.utraknadpoang = utraknadpoang;
        }
    }

   public class Hopp
    {
        #region data
        private int hoppNr;
        private string stil;
        private float svarighetsgrad;
        private int hojd;
        private List<float> betyg;
        private float total;
        private Poang poang;
        #endregion

        #region constructor

        public Hopp()
        {
            this.hoppNr = 0;
            this.stil = "";
            this.svarighetsgrad = 0;
            this.hojd = 0;
            this.betyg = new List<float>();
            this.total = 0;
            this.poang = new Poang();
        }

        public Hopp(int hoppNr, string stil, float svarighetsgrad, int hojd, List<float> betyg)
        {
            this.hoppNr = hoppNr;
            this.stil = stil;
            this.svarighetsgrad = svarighetsgrad;
            this.hojd = hojd;
            this.betyg = betyg;
            this.betyg.Sort();
            this.total = this.raknaTotal();
            this.poang = this.raknaPoang();
        } 
        #endregion

        #region uträkningar
        public float raknaTotal()
        {
            float sum= 0;
            for(int i = 0; i<this.betyg.Count(); i++)
            {
                sum += this.betyg[i];
            }
            return sum;
        }
        
        public Poang raknaPoang()
        {
            int toRemove = 0;
            if (this.betyg.Count() == 7)
                toRemove = 2;
            else if (this.betyg.Count() == 5)
                toRemove = 1;
            List<float> temp = this.betyg.ToList();
            

            for (int i = 0; i < toRemove; i++)
            {
                temp.RemoveAt(0);
                temp.RemoveAt(temp.Count - 1); 
            }
            Poang temppoang = new Poang();
            for (int i = 0; i < temp.Count(); i++)
            {
                temppoang.poang = temppoang.poang + temp[i];
            }
            temppoang.utraknadpoang = temppoang.poang * this.svarighetsgrad;
            return (temppoang);
        }

        #endregion

        #region getter
        public int getHoppNr() { return hoppNr; }
        public string getStil() { return stil; }
        public float getSvarighet() { return svarighetsgrad; }
        public int getHojd() { return hojd; }
        public float getTotal() { return total; }
        public Poang getPoang() { return poang; }
        #endregion

        #region setter
        public void setHoppNr(int hN) { this.hoppNr = hN; }
        public void setStil(string stil) { this.stil = stil; }
        public void setSvarighet(float svar) { this.svarighetsgrad = svar; }
        public void setHojd(int hojd) { this.hojd = hojd; }
        public void setBetyg(List<float> betyg) { this.betyg = betyg; }
        public void setTotal() { this.total = this.raknaTotal(); }
        public void setPoang() { this.poang = this.raknaPoang(); }
        #endregion
    }
}
