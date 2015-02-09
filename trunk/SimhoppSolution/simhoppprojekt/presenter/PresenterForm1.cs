using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public class PresenterForm1
    {
        public IForm1 _view { get; set; }
        public TavlingsClass _model { get; set; }

        public PresenterForm1(IForm1 view, TavlingsClass t)
        {
            this._model = t;
            this._view = view;
            this._view.EventNewPers += NewPers;
        }

        public void NewPers()
        {
            this._model.AddPerson(new Hopplist());
        }
        public void DeletePers(int index)
        {
            this._model.RemovePerson(index);
        }

    }
}
