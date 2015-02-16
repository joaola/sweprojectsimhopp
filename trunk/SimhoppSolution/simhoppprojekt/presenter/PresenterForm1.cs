using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public class PresenterForm1
    {
        #region data
        public IForm1 _view { get; set; }
        public TavlingsClass _model { get; set; }
        #endregion

        public PresenterForm1(IForm1 view, TavlingsClass t)
        {
            this._model = t;
            this._view = view;
            this._view.EventNewPers += NewPers;
            this._view.EventDeletePers += DeletePers;
            this._view.EventGetHopplistor += GetHopplistor;
            this._view.EventGetTavling += getTavling;
            this._view.EventGetTavlingsnamn += GetTavlingsnamn;
            this._view.EventGetDatum += GetDatum;
            this._view.EventSetDatum += SetDatum;
            this._view.EventSetTavlingsnamn += setTavlingsnamn;
            this._view.EventSort += sort;
        }

        #region funcs
        public void NewPers()
        {
            this._model.AddPerson(new Hopplist());
        }

        public void DeletePers(int index)
        {
            this._model.RemovePerson(index);
        }

        public List<Hopplist> GetHopplistor()
        {
            return this._model.getHopplistor();
        }

        public string GetTavlingsnamn()
        {
            return this._model.getNamn();
        }

        public string GetDatum()
        {
            return this._model.getDatum();
        }

        public TavlingsClass getTavling()
        {
            return this._model;
        }

        public void SetDatum(string datum)
        {
            this._model.setDatum(datum);
        }

        public void setTavlingsnamn(string namn)
        {
            this._model.setNamn(namn);
        }

        public void sort()
        {
            this._model.PlaceringSort();
        }
        

        #endregion
    }
}
