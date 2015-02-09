using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public interface ITavlingsClass
    {
        void AddPerson(Hopplist h);
        void RemovePerson(int index);

        List<Hopplist> GetHopplistor();

    }
}
