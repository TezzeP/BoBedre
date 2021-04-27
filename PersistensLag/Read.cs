using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;


namespace PersistensLag 
{
    public  class Read
    {

        public static List<Bolig> ReadAllBolig()
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadBoligForSale = new SqlCommand
            {
                Connection = conn,
                CommandText = ("select * from Bolig")
            };

            SqlDataReader reader = ReadBoligForSale.ExecuteReader();

            List<Bolig> returnList = new List<Bolig>();

            while (reader.Read())
            {
                Bolig tempProduct = new Bolig
                {
                    BoligID = Convert.ToInt32(reader[0]),
                    Adresse = Convert.ToString(reader[1]),
                    PostNr = Convert.ToInt32(reader[2]),
                    GrundM2 = Convert.ToInt32(reader[3]),
                    HusM2 = Convert.ToInt32(reader[4]),
                    Pris = Convert.ToInt32(reader[5]),
                    SalgsDato = Convert.ToString(reader[6]),
                    OprettelsesDato = Convert.ToString(reader[7]),
                    StandSkala = Convert.ToInt32(reader[8])
                };

                returnList.Add(tempProduct);
            }

            conn.Close();

            return returnList;
        }  

        

    }
}
