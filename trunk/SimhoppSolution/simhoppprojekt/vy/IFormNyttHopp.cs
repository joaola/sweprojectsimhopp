using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public delegate void DelegateNewHopp(Hopp h);
    interface IFormNyttHopp
    {
        event DelegateNewHopp EventNewHopp;
    }
}
