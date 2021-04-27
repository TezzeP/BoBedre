using System;
using System.Collections.Generic;
using System.Linq;
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
                .Where(x => x.GrundM2 >= 145)
                .OrderBy(x => x.Adresse)
                .ThenBy(x => x.Pris)
                .ToList();
        }

        
        

     }
}
