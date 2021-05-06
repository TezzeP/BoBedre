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

        public Kunde ReadOneCoustomer(int KundeId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadBoligForSale = new SqlCommand
            {
                Connection = conn,
                CommandText = ("select * from Kunde where KundeId = @kundeId")
            };

            ReadBoligForSale.Parameters.AddWithValue("@kundeId", Convert.ToInt32(KundeId));

            SqlDataReader reader = ReadBoligForSale.ExecuteReader();
            while (reader.Read())
            {
                Kunde tempKunde = new Kunde
                {
                    KundeId = Convert.ToInt32(reader[0]),
                    Navn = Convert.ToString(reader[1]),
                    Telnr = Convert.ToInt32(reader[2]),
                    Mail = Convert.ToString(reader[3]),
                    Adresse = Convert.ToString(reader[4]),
                    Køber = Convert.ToInt32(reader[5]),
                    Sælger = Convert.ToInt32(reader[6]),
                    
                };

                return tempKunde;
            }

            return default;
        }

        public Bolig ReadOneBolig(int BoligId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadOneBoligcmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ("select * from Bolig where BoligId = @BoligId")
            };

            ReadOneBoligcmd.Parameters.AddWithValue("@BoligId", Convert.ToInt32(BoligId));

            SqlDataReader reader = ReadOneBoligcmd.ExecuteReader();
            while (reader.Read())
            {
                Bolig tempMælger = new Bolig
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

                return tempMælger;
            }

            return default;
        }

        public Ejendomsmælger ReadOneMælger(int MedarbejderId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadOneMæglercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ("select * from Ejendomsmælger where MedarbejderId = @MedarbejderId")
            };

            ReadOneMæglercmd.Parameters.AddWithValue("@MedarbejderId", Convert.ToInt32(MedarbejderId));

            SqlDataReader reader = ReadOneMæglercmd.ExecuteReader();
            while (reader.Read())
            {
                Ejendomsmælger tempMælger = new Ejendomsmælger
                {
                    MedarbejderId = Convert.ToInt32(reader[0]),
                    Navn = Convert.ToString(reader[1]),
                    Tlf = Convert.ToInt32(reader[2]),
                    Mail = Convert.ToString(reader[3]),
                    Stilling = Convert.ToString(reader[4]),
                   
                };

                return tempMælger;
            }

            return default;
        }





    }
}
