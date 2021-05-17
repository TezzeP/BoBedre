using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PrisVurderer
    {
        double standStartFaktor = -0.75;
        double standFaktor = 0.15;
        double grundFaktor = 0.01;
        double husFaktor = 0.02;
        double etagerStartFaktor = -0.10;
        double etagerPerEtageFaktor = 0.15;
        double køkkenalderStartFaktor = 0.5;
        double køkkenalderPerMånedFaktor = 0.015;
        double badeværelseStartFaktor = 0.4;
        double badeværelsePerMånedFaktor = 0.01;
        double haveFaktor = 0.1;

        Dictionary<int, double> postNrVaerdier = new Dictionary<int, double>()
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

        Dictionary<string, double> ejendomstypeVaerdier = new Dictionary<string, double>()
        {
            {"villa", 0.1 },
            {"hus", 0.05 },
            {"lejlighed", -0.1 },
            {"andet", 0.0 }
        };

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

            totalFaktor += standStartFaktor + (stand * standFaktor);
            totalFaktor += grund * grundFaktor;
            totalFaktor += hus * husFaktor;

            if (postNrVaerdier.ContainsKey(postNr))
            {
                totalFaktor += postNrVaerdier[postNr];
            }

            if (ejendomstypeVaerdier.ContainsKey(ejendomstype))
            {
                totalFaktor += ejendomstypeVaerdier[ejendomstype];
            }

            totalFaktor += etagerStartFaktor + (etagerPerEtageFaktor * etager);
            totalFaktor += køkkenalderStartFaktor - (køkkenalderPerMånedFaktor * køkkenAlder);
            totalFaktor += badeværelseStartFaktor - (badeværelsePerMånedFaktor * badeværelsesAlder);

            if (have)
            {
                totalFaktor += haveFaktor;
            }

            pris *= totalFaktor;
            pris = Math.Round(pris, 2);

            return pris;
        }
    }
}
