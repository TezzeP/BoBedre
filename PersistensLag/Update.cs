using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace PersistensLag
{
    public class Update
    {
        public void UpdateBolig(Kunde kunde)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            SqlCommand UpdateBolig = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    (" Update Kunde set " +
                     " Navn=@navn,      " +
                     " Tlfnr=@tlfNr,    " +
                     " Mail=@mail,      " +
                     " Adresse=@adresse," +
                     " Køber=@Køber,    " +
                     " Sælger= @Sælger  " )
            };

            UpdateBolig.Parameters.AddWithValue("@navn", kunde.Navn);
            UpdateBolig.Parameters.AddWithValue("@Tlfnr", kunde.Telnr);
            UpdateBolig.Parameters.AddWithValue("@Mail", kunde.Mail);
            UpdateBolig.Parameters.AddWithValue("@Adresse", kunde.Adresse);
            UpdateBolig.Parameters.AddWithValue("@Køber", kunde.Køber);
            UpdateBolig.Parameters.AddWithValue("@Sælger", kunde.Sælger);
            UpdateBolig.ExecuteNonQuery();
            conn.Close();




        }
           
        
    }
}
