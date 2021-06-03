using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using PersistensLag;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethodSortingIntervalChar()
        {
            //arange  
            Sorting sorting = new Sorting();

            List<Bolig> boligList = new List<Bolig>();

            List<Bolig> testBoliger = new List<Bolig>();
            Bolig b1 = new Bolig();
            b1.BoligID = 1;
            b1.Adresse = "avej";

            Bolig b2 = new Bolig();
            b2.BoligID = 2;
            b2.Adresse = "gvej";

            Bolig b3 = new Bolig();
            b3.BoligID = 3;
            b3.Adresse = "xvej";

            testBoliger.Add(b1);
            testBoliger.Add(b2);
            testBoliger.Add(b3);

            char char1 = 'a';
            char char2 = 'g';

            // act 
            boligList = sorting.SerchByLetterInverval3(char1, char2, testBoliger);
   
            // assert
            Assert.IsTrue(boligList.Contains(b1) && boligList.Contains(b2) && !boligList.Contains(b3));
        }

        [TestMethod]
        public void testMethodeUdregnPrisPÅHus()
        {
            //arrange
            PrisVurderer prisVudere = new PrisVurderer();

            //act

            var udregnetPris = prisVudere.Calculate(150000, 5, 200, 5, 8700, "andet", 12, 6, 5, true);

            //assert
            Assert.AreEqual(849000, udregnetPris);
        }

        [TestMethod]
        public void TestStatistik()
        {
            Read reader = Read.Instance();
            string s = "SELECT * FROM dbo.Bolig WHERE SalgsDato IS NOT NULL AND Adresse LIKE 'Testvej%'  AND SalgsDato >= '20100101' AND SalgsDato <= '20200101'";
            List<Bolig> boligListe = reader.ReadAllBoligWithWithQuery(s);

            foreach (Bolig b in boligListe)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(b.SalgsDato.Substring(6));
                sb.Append(b.SalgsDato.Substring(3, 2));
                sb.Append(b.SalgsDato.Substring(0, 2));
                StringAssert.Contains(b.Adresse, "Testvej");
                Assert.IsTrue(Convert.ToInt32(sb.ToString()) >= 20100101);
                Assert.IsTrue(Convert.ToInt32(sb.ToString()) <= 20200101);
            }

        }

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
