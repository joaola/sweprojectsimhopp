﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    /// <summary>
    ///  Klassen TavlingsClass håller koll på en tävlings namn, datum och listan av personer som tävlar.
    /// </summary>
    [Serializable()]
    public class TavlingsClass
    {
        #region data
        private string namn;
        private string datum;
        private List<Hopplist> Hopplistor;
        #endregion

        #region constr
        public TavlingsClass()
        {
            this.namn = "";
            this.datum = "";
            this.Hopplistor = new List<Hopplist>();
        }
        public TavlingsClass(string namn)
        {
            this.namn = namn;
            this.datum = "";
            this.Hopplistor = new List<Hopplist>();
        }
        public TavlingsClass(string namn,string datum)
        {
            this.namn = namn;
            this.datum = datum;
            this.Hopplistor = new List<Hopplist>();
        }
        public TavlingsClass(string namn, string datum, List<Hopplist> hopplistor)
        {
            this.namn = namn;
            this.datum = datum;
            this.Hopplistor = hopplistor;
        }
        #endregion

        #region funcs
        public void PlaceringSort()
        {
            this.Hopplistor.Sort(delegate(Hopplist h1, Hopplist h2) { return h1.UtraknadPoangSumma().CompareTo(h2.UtraknadPoangSumma()); });
            this.Hopplistor.Reverse();
        }

        public void AddPerson(Hopplist hl1)
        {
            this.Hopplistor.Add(hl1);
            this.PlaceringSort();
        }

        public void RemovePerson(int index)
        {
            if (this.Hopplistor.Count != 0)
            {
                this.Hopplistor.RemoveAt(index);
                //this.PlaceringSort();
            }
        }

        public int AntalTavlande()
        {
            return this.Hopplistor.Count();
        }

        public string GetFirstContestant()
        {
            return this.Hopplistor[0].getNamn();
        }

        #endregion

        #region getters
        public string getNamn() { return this.namn; }
        public string getDatum() { return this.datum; }
        public List<Hopplist> getHopplistor() { return this.Hopplistor; }
        #endregion

        #region setters
        public void setNamn(string namn) { this.namn = namn; }
        public void setDatum(string datum) { this.datum = datum; }
        public void setHopplistor(List<Hopplist> Hopplistor) { this.Hopplistor = Hopplistor; }
        #endregion

        #region ITavlingsClassMembers

        //void ITavlingsClass.NewPerson(Hopplist h)
        //{
        //    this.Hopplistor.Add(h);
        //}
        //void ITavlingsClass.DeletePerson(int index)
        //{
        //    this.Hopplistor.RemoveAt(index);
        //}
        //List<Hopplist> ITavlingsClass.GetPersons()
        //{
        //    return this.Hopplistor;
        //}

        #endregion
    }
}
