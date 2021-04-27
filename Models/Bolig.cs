using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bolig
    {
        public int BoligID { get; set; }
        public string Adresse  { get; set; }
        public int PostNr  { get; set; }
        public int GrundM2  { get; set; }
        public int HusM2 { get; set; }
        public int Pris { get; set; }
        public string  SalgsDato { get; set; }
        public string OprettelsesDato { get; set; }
        public int StandSkala { get; set; }
    }
}
