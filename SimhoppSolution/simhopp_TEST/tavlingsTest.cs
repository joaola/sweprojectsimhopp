using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using simhoppprojekt;

namespace simhopp_TEST
{
    [TestFixture]
    class tavlingsTest
    {
        private TavlingsClass T1 = new TavlingsClass();
        [SetUp]
        public void setup()
        {
            List<Hopplist> Hopplistor = new List<Hopplist>();
            Hopplist hl1 = null;
            List<float> tempbetyg = new List<float>();
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            tempbetyg.Add(5f);
            tempbetyg.Add(5);
            tempbetyg.Add(5);
            tempbetyg.Add(7);
            tempbetyg.Add(7);
            Hopp temphopp1 = new Hopp(1, 101, "A", 1.5f, 3, tempbetyg);
            hl1 = new Hopplist(1, 1, "Kurt", "gyttorp sf", 1990, "man", "gyttorp", "3m", "2015-02-02");
            hl1.AddHopp(temphopp1);

            tempbetyg.Clear();

            tempbetyg.Add(3);
            tempbetyg.Add(5.5f);
            tempbetyg.Add(6);
            tempbetyg.Add(8);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(5.5f);
            Hopp temphopp2 = new Hopp(2, 302, "B", 2f, 3, tempbetyg);
            hl1.AddHopp(temphopp2);
        }

        [Test]
        public void AntalTavlande()
        {
            
        }
    }
}
