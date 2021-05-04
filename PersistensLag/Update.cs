using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistensLag
{
    class Update
    {
        private void UpdateBolig()
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            SqlCommand UpdateBolig = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    ("Update Kunde set Navn=@navn, Tlfnr=@tlfNr,  Mail=@mail, Adresse=@adresse, Køber=1, Sælger= 0")

            };




            

        }
           
        
    }
}
