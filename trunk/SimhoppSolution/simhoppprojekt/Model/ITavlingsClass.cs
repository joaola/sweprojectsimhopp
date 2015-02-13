using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public interface ITavlingsClass
    {
        void AddPerson(Hopplist hl1);
        
        void NewPerson(Hopplist h);
        void DeletePerson(int index);

        List<Hopplist> GetPersons();

    }
}
