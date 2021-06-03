using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Models;
using PersistensLag;

namespace BusinessLogic
{
     public  class Sorting
     {
        public List<Bolig>  SortByAdresseFirstLetterAndM2Over145()
        {
            return Read.ReadAllBolig()
                .Where(x => x.GrundM2 >= 145 && x.SalgsDato != null)
                .OrderBy(x => x.Adresse)
                .ThenBy(x => x.Pris)
                .ToList();
        }

        public List<Bolig> SerchByLetterInverval(string firstLetter, string secondLetter)
        {
            List<Bolig> indput = Read.ReadAllBolig();
            List<Bolig> output = new List<Bolig>();
            char startTal = Convert.ToChar(firstLetter.ToLower());
            char slutTal = Convert.ToChar(secondLetter.ToLower());

            foreach (Bolig b in indput)
            {
                char firstLetterInAdresse = Convert.ToChar(b.Adresse.
                    Substring(0,1).ToLower());
                if (firstLetterInAdresse >= startTal && firstLetterInAdresse <= slutTal ) 
                {
                    output.Add(b);
                }
            }

            return output;
        }


        public List<Bolig> SerchByLetterInverval2(char firstLetter, char secondLetter)
        {
            return SerchByLetterInverval3(firstLetter, secondLetter, Read.ReadAllBolig());

        }

        public List<Bolig> SerchByLetterInverval3(char firstLetter, char secondLetter, List<Bolig> boligerList)
        {
            return boligerList.Where
            (x => Char.ToLower(x.Adresse[0])
                  >= Char.ToLower(firstLetter) &&
                  Char.ToLower(x.Adresse[0]) <=
                  Char.ToLower(secondLetter)).ToList();

        }
     }
}
