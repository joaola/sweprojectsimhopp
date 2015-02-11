using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public delegate void DelegateNewPers();
    public delegate void DelegateDeletePers();
    public delegate List<Hopplist> DelegateGetHopplist();
    
    public interface IForm1
    {
        event DelegateNewPers EventNewPers;
        event DelegateDeletePers EventDeletePers;
        event DelegateGetHopplist EventGetHopplist;

    }

}
