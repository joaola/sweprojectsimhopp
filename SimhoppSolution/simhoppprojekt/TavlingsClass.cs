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
        public TavlingsClass(string namn)
        {
            this.namn = namn;
            this.Hopplistor = new List<Hopplist>();
        }
        public TavlingsClass(string namn, List<Hopplist> hopplistor)
        {
            this.namn = "";
            this.Hopplistor = hopplistor;
        }

        #endregion

        #region getters
        public string getNamn() { return this.namn; }
        public List<Hopplist> getHopplistor() { return this.Hopplistor; }
        #endregion

        #region setters
        public void setNamn(string namn) { this.namn = namn; }
        public void setHopplistor(List<Hopplist> Hopplistor) { this.Hopplistor = Hopplistor; }
        #endregion

    }
}
