using System.Collections.Generic;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

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






    }
}
