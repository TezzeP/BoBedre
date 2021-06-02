using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PrisVurderer
    {
        public double StandStartFaktor { get; set; }
        public double StandFaktor { get; set; }
        public double GrundFaktor { get; set; }
        public double HusFaktor { get; set; }
        public double EtagerStartFaktor { get; set; }
        public double EtagerPerEtageFaktor { get; set; }
        public double KøkkenalderStartFaktor { get; set; }
        public double KøkkenalderPerMånedFaktor { get; set; }
        public double BadeværelseStartFaktor { get; set; }
        public double BadeværelsePerMånedFaktor { get; set; }
        public double HaveFaktor { get; set; }
        public Dictionary<int, double> PostNrVaerdier { get; set; }

        public Dictionary<string, double> EjendomstypeVaerdier { get; set; }


        public PrisVurderer()
        {
            StandStartFaktor = -0.75;
            StandFaktor = 0.15;
            GrundFaktor = 0.01;
            HusFaktor = 0.02;
            EtagerStartFaktor = -0.10;
            EtagerPerEtageFaktor = 0.15;
            KøkkenalderStartFaktor = 0.5;
            KøkkenalderPerMånedFaktor = 0.015;
            BadeværelseStartFaktor = 0.4;
            BadeværelsePerMånedFaktor = 0.01;
            HaveFaktor = 0.1;
            PostNrVaerdier = new Dictionary<int, double>()
        {
            {2000, 0.2 },
            {2605, -0.075 },
            {2990, -0.2 },
            {3000, 0.1 },
            {4000, -0.05 },
            {4900, 0.075 },
            {5000, 0.125 },
            {5500, 0.025 },
            {6000, 0.05 },
            {7000, 0.1 },
            {7100, 0.1 },
            {8000, -0.175 },
            {8200, 0.15 },
            {9000, 0.1 }
        };
            EjendomstypeVaerdier = new Dictionary<string, double>()
        {
            {"villa", 0.15 },
            {"hus", 0.05 },
            {"lejlighed", -0.1 },
            {"andet", 0.0 }
        };

        }




        public double Calculate(double pris, int stand, double grund, double hus, int postNr, string ejendomstype, int etager, int køkkenAlder, int badeværelsesAlder, Boolean have)
        {
            if (stand < 0)
            {
                stand = 0;
            }
            else if (stand > 10)
            {
                stand = 10;
            }

            double totalFaktor = 1;

            totalFaktor += StandStartFaktor + (stand * StandFaktor);
            totalFaktor += grund * GrundFaktor;
            totalFaktor += hus * HusFaktor;

            if (PostNrVaerdier.ContainsKey(postNr))
            {
                totalFaktor += PostNrVaerdier[postNr];
            }

            if (EjendomstypeVaerdier.ContainsKey(ejendomstype))
            {
                totalFaktor += EjendomstypeVaerdier[ejendomstype];
            }

            totalFaktor += EtagerStartFaktor + (EtagerPerEtageFaktor * etager);
            totalFaktor += KøkkenalderStartFaktor - (KøkkenalderPerMånedFaktor * køkkenAlder);
            totalFaktor += BadeværelseStartFaktor - (BadeværelsePerMånedFaktor * badeværelsesAlder);

            if (have)
            {
                totalFaktor += HaveFaktor;
            }

            pris *= totalFaktor;
            pris = Math.Round(pris, 2);

            return pris;
        }
    }
}
