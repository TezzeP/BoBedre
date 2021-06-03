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
        public double GrundM2  { get; set; }
        public double HusM2 { get; set; }
        public double Pris { get; set; }
        public string EjendomsType { get; set; }
        public int Have { get; set; }
        public string Alder { get; set; }
        public int Etager { get; set; }
        public string KøkkenAlder { get; set; }
        public string BadeværelsesAlder { get; set; }
        public string  SalgsDato { get; set; }
        public string OprettelsesDato { get; set; }
        public string OmbygningsÅr { get; set; }
        public int StandSkala { get; set; }
        public int KundeID { get; set; }
        public int MedarbejderID { get; set; }
        
    }
}
