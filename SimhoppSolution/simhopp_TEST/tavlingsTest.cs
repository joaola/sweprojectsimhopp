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
        private TavlingsClass T1 = null;
        [SetUp]
        public void setup()
        {
            List<Hopplist> Hopplistor1 = new List<Hopplist>();

            #region Kurt
            List<float> tempbetyg = new List<float>();
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            tempbetyg.Add(5f);
            tempbetyg.Add(5);
            tempbetyg.Add(5);
            tempbetyg.Add(7);
            tempbetyg.Add(7);
            Hopp temphopp1 = new Hopp(1, 101, "A", 1.5f, 3, tempbetyg);

            Hopplist hl1 = new Hopplist(1, "Kurt", "gyttorp sf", 1990, "man", "gyttorp", "3m", "2015-02-02");
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

            tempbetyg.Clear();

            tempbetyg.Add(2);
            tempbetyg.Add(4.5f);
            tempbetyg.Add(5);
            tempbetyg.Add(8);
            tempbetyg.Add(3);
            tempbetyg.Add(2);
            tempbetyg.Add(2.5f);
            Hopp temphopp3 = new Hopp(3, 201, "C", 3f, 3, tempbetyg);

            hl1.AddHopp(temphopp2);
            Hopplistor1.Add(hl1);
            #endregion

            #region Sven

            tempbetyg.Clear();
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            tempbetyg.Add(1f);
            tempbetyg.Add(1);
            tempbetyg.Add(1);
            tempbetyg.Add(2);
            tempbetyg.Add(2);
            Hopp temphopp4 = new Hopp(1, 101, "A", 1.5f, 3, tempbetyg);

            Hopplist hl2 = new Hopplist(1, "Sven", "gyttorp sf", 1990, "man", "gyttorp", "3m", "2015-02-02");
            hl2.AddHopp(temphopp4);

            tempbetyg.Clear();

            tempbetyg.Add(1);
            tempbetyg.Add(2.5f);
            tempbetyg.Add(2);
            tempbetyg.Add(3);
            tempbetyg.Add(3);
            tempbetyg.Add(4);
            tempbetyg.Add(4.5f);
            Hopp temphopp5 = new Hopp(2, 302, "B", 2f, 3, tempbetyg);

            hl2.AddHopp(temphopp5);

            tempbetyg.Clear();

            tempbetyg.Add(1);
            tempbetyg.Add(3.5f);
            tempbetyg.Add(1);
            tempbetyg.Add(5);
            tempbetyg.Add(3);
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            Hopp temphopp6 = new Hopp(3, 201, "C", 3f, 3, tempbetyg);

            hl2.AddHopp(temphopp6);
            Hopplistor1.Add(hl2);
            #endregion

            #region Bert
            tempbetyg.Clear();

            tempbetyg.Add(8);
            tempbetyg.Add(7.5f);
            tempbetyg.Add(8.5f);
            tempbetyg.Add(7.5f);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(8);
            Hopp temphopp7 = new Hopp(1, 101, "A", 1.5f, 3, tempbetyg);

            Hopplist hl3 = new Hopplist(1, "Bert", "gyttorp sf", 1990, "man", "gyttorp", "3m", "2015-02-02");
            hl3.AddHopp(temphopp7);

            tempbetyg.Clear();

            tempbetyg.Add(3);
            tempbetyg.Add(5.5f);
            tempbetyg.Add(6);
            tempbetyg.Add(8);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(5.5f);
            Hopp temphopp8 = new Hopp(2, 302, "B", 2f, 3, tempbetyg);

            hl3.AddHopp(temphopp8);

            tempbetyg.Clear();

            tempbetyg.Add(2);
            tempbetyg.Add(4.5f);
            tempbetyg.Add(5);
            tempbetyg.Add(8);
            tempbetyg.Add(3);
            tempbetyg.Add(2);
            tempbetyg.Add(2.5f);
            Hopp temphopp9 = new Hopp(3, 201, "C", 3f, 3, tempbetyg);

            hl3.AddHopp(temphopp9);
            Hopplistor1.Add(hl3);
            #endregion

            this.T1 = new TavlingsClass("gyttorp simtävling", Hopplistor1);

        }

        [Test]
        public void AntalTavlande()
        {
            Assert.AreEqual(3, T1.AntalTavlande());
        }

        [Test]
        public void sortTavlande()
        {
            T1.PlaceringSort();
            Assert.AreEqual("Sven", T1.GetFirstContestant());
            Assert.AreEqual(38.75f, T1.getHopplistor()[0].UtraknadPoangSumma());
                        
        }
    }
}
