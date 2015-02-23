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
    class Hopplisttest
    {
        private Hopplist hl1 = null;
        [SetUp]
        public void setup()
        {
            
            List<float> tempbetyg = new List<float>();
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            tempbetyg.Add(5f);
            tempbetyg.Add(5);
            tempbetyg.Add(5);
            tempbetyg.Add(7);
            tempbetyg.Add(7);
            Hopp temphopp1 = new Hopp(101,"A",1.5f,3,tempbetyg);
            this.hl1 = new Hopplist(1, "Kurt", "gyttorp sf", 1990, "man", "gyttorp");
            this.hl1.AddHopp(temphopp1);

            tempbetyg.Clear();

            tempbetyg.Add(3);
            tempbetyg.Add(5.5f);
            tempbetyg.Add(6);
            tempbetyg.Add(8);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(5.5f);
            Hopp temphopp2 = new Hopp(302, "B", 2f, 3, tempbetyg);
            this.hl1.AddHopp(temphopp2);
        }

        [Test]
        public void AntalHoppSumma()
        {
            Assert.AreEqual(2, hl1.AntalHopp());
        }
        [Test]
        public void svarighetsgradSumma()
        {
            Assert.AreEqual(3.5f, hl1.SvarighetsSumma());
        }
        [Test]
        public void poangSumma()
        {
            Assert.AreEqual(32.5f, hl1.PoangSumma());
        }
        [Test]
        public void utraknadPoangSumma()
        {
            Assert.AreEqual(57.5f, hl1.UtraknadPoangSumma());
        }

    }
}
