using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Models;
using PersistensLag;

namespace BusinessLogic
{
    public class ReadAndShow
    {

        public List<Bolig> ReadAndShowBolig()
        {
            return Read.ReadAllBolig().ToList();
        }

        public List<Bolig> ReadAndShowBoligSpecific(string boligAttribut, int boligAttributVærdi)
        {
            Read reader = Read.Instance();
            return reader.ReadAllBoligWithAttributeInt(boligAttribut, boligAttributVærdi).ToList();
        }

        public List<Kunde> ReadAndShowKunde()
        {
            return Read.ReadAllCoustomer().ToList();
        }

        public List<Ejendomsmælger> ReadAndShowMægler()
        {
            return Read.ReadAllMægler().ToList();
        }

        public List<Ejendomsmælger> ReadAndShowMedarbejder()
        {
            return Read.ReadOneMedarbejder2().ToList();
        }

       
        

       
    }
}
