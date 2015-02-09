using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public interface IHopplist
    {
        void AddHopp(Hopp h);
        void Remove(int index);
    }
}
