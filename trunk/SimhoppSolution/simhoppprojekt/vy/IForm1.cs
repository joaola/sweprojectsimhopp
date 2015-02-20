using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public delegate void DelegateDeletePers(int index);
    public delegate List<Hopplist> DelegateGetHopplistor();
    public delegate TavlingsClass DelegateGetTavling();
    public delegate string DelegateGetTavlingsnamn();
    public delegate string DelegateGetDatum();
    public delegate void DelegateSetDatum(string datum);
    public delegate void DelegateSetTavlingsnamn(string namn);
    public delegate void DelegateSort();
    
    public interface IForm1
    {
        event DelegateDeletePers EventDeletePers;
        event DelegateGetHopplistor EventGetHopplistor;
        event DelegateGetTavling EventGetTavling;
        event DelegateGetTavlingsnamn EventGetTavlingsnamn;
        event DelegateGetDatum EventGetDatum;
        event DelegateSetDatum EventSetDatum;
        event DelegateSetTavlingsnamn EventSetTavlingsnamn;
        event DelegateSort EventSort;

    }

}
