using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ejendomsmælger
    {
        public int MedarbejderId { get; set; }
        public string Navn { get; set; }
        public int Tlf { get; set; }
        public string Mail { get; set; }
        public string Stilling { get; set; }
    }
}
