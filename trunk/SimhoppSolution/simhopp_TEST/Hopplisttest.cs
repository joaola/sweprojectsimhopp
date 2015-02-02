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
        private Hopplist h = null;
        [SetUp]
        public void setup()
        {
            Hopp temp = new Hopp();
            List<float> tempbetyg = new List<float>();
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            tempbetyg.Add(5f);
            tempbetyg.Add(5);
            tempbetyg.Add(5);
            tempbetyg.Add(7);
            tempbetyg.Add(7);
            temp.setSvarighet(3.5f);
            temp.setBetyg(tempbetyg);
        }
    }
}
