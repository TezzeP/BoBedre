using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using Models;
using PersistensLag;

namespace BobedreTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrisVurderer()
        {
            PrisVurderer pv = new PrisVurderer();
            double value = 100;
            double defaultValue = value * (1 + pv.StandStartFaktor + pv.EtagerStartFaktor + pv.KøkkenalderStartFaktor + pv.BadeværelseStartFaktor);
            Assert.AreEqual(pv.Calculate(value, 0, 0, 0, 0, "", 0, 0, 0, false), defaultValue);
            int stand = 4;
            Assert.AreEqual(pv.Calculate(value, stand, 0, 0, 0, "", 0, 0, 0, false), defaultValue + value * stand * pv.StandFaktor);
            int grund = 15;
            Assert.AreEqual(pv.Calculate(value, 0, grund, 0, 0, "", 0, 0, 0, false), defaultValue + value * grund * pv.GrundFaktor);
            int hus = 25;
            Assert.AreEqual(pv.Calculate(value, 0, 0, hus, 0, "", 0, 0, 0, false), defaultValue + value * hus * pv.HusFaktor);
            int postNr = 2000;
            Assert.AreEqual(pv.Calculate(value, 0, 0, 0, postNr, "", 0, 0, 0, false), defaultValue + value * pv.PostNrVaerdier[postNr]);
            string ejendomstype = "villa";
            Assert.AreEqual(pv.Calculate(value, 0, 0, 0, 0, ejendomstype, 0, 0, 0, false), defaultValue + value * pv.EjendomstypeVaerdier[ejendomstype]);
            int etager = 3;
            Assert.AreEqual(pv.Calculate(value, 0, 0, 0, 0, "", etager, 0, 0, false), defaultValue + value * etager * pv.EtagerPerEtageFaktor);
            int kAlder = 20;
            Assert.AreEqual(pv.Calculate(value, 0, 0, 0, 0, "", 0, kAlder, 0, false), defaultValue - value * kAlder * pv.KøkkenalderPerMånedFaktor);
            int bAlder = 20;
            Assert.AreEqual(pv.Calculate(value, 0, 0, 0, 0, "", 0, 0, bAlder, false), defaultValue - value * bAlder * pv.BadeværelsePerMånedFaktor);
            bool have = true;
            Assert.AreEqual(pv.Calculate(value, 0, 0, 0, 0, "", 0, 0, 0, true), defaultValue + value * pv.HaveFaktor);
        }
    }
}
