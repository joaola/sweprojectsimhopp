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
    public class Hopptest
    {
        private Hopp h = null;
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
            h = new Hopp();
            h.setSvarighet(3.5f);
            h.setBetyg(tempbetyg);
        }

        [Test]
        public void PoangSummor()
        {
            Assert.AreEqual(15,h.raknaPoang().poang);
            Assert.AreEqual(52.5,h.raknaPoang().utraknadpoang);
            Assert.AreEqual(31.5,h.raknaTotal());
        }
        [Test]
        public void Hopplistor()
        {
            Assert.AreEqual(1,1);
        }
    }
}
