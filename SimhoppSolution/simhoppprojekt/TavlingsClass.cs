using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    public class TavlingsClass
    {
        #region data
        private string namn;
        private List<Hopplist> Hopplistor;
        #endregion

        #region constr

        public TavlingsClass()
        {
            this.namn = "";
            this.Hopplistor = new List<Hopplist>();
        }
        public TavlingsClass(string namn, List<Hopplist> hopplistor)
        {
            this.namn = "";
            this.Hopplistor = hopplistor;
        }

        #endregion

    }
}
