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
    }
}
