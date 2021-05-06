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
            return create.OpretBolig(bolig);
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
        public void HandleDeleteMægler(int mægler)
        {
            Delete deleteMægler = new Delete();
            deleteMægler.DeleteMægler(mægler);
        }
        public void HandleDeleteBolig(int bolig)
        {
            Delete deleteBolig = new Delete();
            deleteBolig.DeleteBolig(bolig);
        }
        public void HandleDeleteKunde(int kunde)
        {
            Delete deleteBolig = new Delete();
            deleteBolig.DeleteKunde(kunde);
        }


    }
}
