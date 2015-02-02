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
    public class Class1
    {
        [Test]
        public void PoangSummor()
        {
            List<float> tempbetyg = new List<float>();
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            tempbetyg.Add(5f);
            tempbetyg.Add(5);
            tempbetyg.Add(5);
            tempbetyg.Add(7);
            tempbetyg.Add(7);
            Hopp h = new Hopp();
            h.setSvarighet(3.5f);
            h.setBetyg(tempbetyg);
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
