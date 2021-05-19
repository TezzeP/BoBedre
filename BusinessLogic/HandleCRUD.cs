using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using PersistensLag;

namespace BusinessLogic
{
    public class HandleCRUD
    {
        public string HandleOpretBolig(Bolig bolig)
        {
            Create create = new Create();
            return create.OpretBoligNowak(bolig);
        }


        public string HandleOpretKunde(Kunde kunde)
        {
            Create create = new Create();
            return create.OpretKunde(kunde);
        }


        public string HandleOpretEjendomsmælger(Ejendomsmælger ejendomsmælger)
        {
            Create create = new Create();
            return create.OpretEjendomsmælger(ejendomsmælger);
        }


        public string HandleDeleteMægler(int mægler)
        {
            Delete deleteMægler = new Delete();
            return deleteMægler.DeleteMægler(mægler);
        }


        public string HandleDeleteBolig(int bolig)
        {
            Delete deleteBolig = new Delete();
            return deleteBolig.DeleteBolig(bolig);

        }


        public string HandleDeleteKunde(int kunde)
        {
            Delete deleteKunde = new Delete();
            return deleteKunde.DeleteKunde(kunde);
        }
    }
}
