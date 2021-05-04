using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kunde
    {
        public int KundeId { get; set; }
        public string Navn { get; set; }
        public int Telnr { get; set; }
        public string Mail { get; set; }
        public string Adresse { get; set; }
        public int Køber { get; set; }
        public int Sælger { get; set; }

    }
}
