using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    struct poäng
    {
        public float poäng;
        public float uträknadpoäng;
        poäng()
        {
            this.poäng = 0;
            this.uträknadpoäng = 0;
        }
        poäng(float poäng,float uträknadpoäng)
        {
            this.poäng = poäng;
            this.uträknadpoäng = uträknadpoäng;
        }
    }
    class Hopp
    {
        private int Nr;
        private int hoppNr;
        private string stil;
        private float svårighetsgrad;
        private int höjd;
        private List<float> betyg;
        private float total;
        private poäng poäng;

        public Hopp(int Nr, int hoppNr, string stil, float svårighetsgrad, int höjd, List<float> betyg, float total, float poäng)
        {
            this.Nr= Nr;
            this.hoppNr = hoppNr;
            this.stil = stil;
            this.svårighetsgrad = svårighetsgrad;
            this.höjd = höjd;
            this.betyg = betyg;
            this.total = this.räknaTotal();
            this.poäng = poäng;
        }

        public float räknaTotal()
        {
            float sum= 0;
            for(int i = 0; i>this.betyg.Count(); i++)
            {
                sum += this.betyg[i];
            }
            return sum;
        }


        public poäng räknaPoäng()
        {
            poäng temp;
            float störst = 0, minst = 11;
            for (int i = 0; i > this.betyg.Count(); i++)
            {
                if (this.betyg[i] > störst)
                    störst = this.betyg[i];
                else if(this.betyg[i] <minst)
                    minst = ;
            }
            temp.poäng = 
            return (this.total * this.svårighetsgrad);
        }

    }
}
