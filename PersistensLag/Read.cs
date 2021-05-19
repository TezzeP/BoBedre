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
    public class Read
    {
        private static Read instance;

        protected Read()
        {

        }

        public static Read Instance()
        {
            if (instance == null)
            {
                instance = new Read();
            }

            return instance;
        }

        public static string IntToStringDate(int dato)
        {
            StringBuilder sb = new StringBuilder();
            string s = dato.ToString();

            if (s.Length == 8)
            {
                sb.Append(s.Substring(6));
                sb.Append("/");
                sb.Append(s.Substring(4, 2));
                sb.Append("/");
                sb.Append(s.Substring(0, 4));
            }
            else
            {
                sb.Append("Invalid Date");
            }

            return sb.ToString();
        }

        public static List<Bolig> ReadAllBolig()
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadBoligForSale = new SqlCommand
            {
                Connection = conn,
                CommandText = (" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN " +
                               "select * from Bolig " +
                               "COMMIT TRAN")
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
                    EjendomsType = Convert.ToString(reader[6]),
                    Have = Convert.ToInt32(reader[7]),
                    Alder = Convert.ToString(reader[8]),
                    Etager = Convert.ToInt32(reader[9]),
                    KøkkenAlder = Convert.ToString(reader[10]),
                    BadeværelsesAlder = Convert.ToString(reader[11]),
                    SalgsDato = IntToStringDate(Convert.ToInt32(reader[12])),
                    OprettelsesDato = Convert.ToString(reader[13]),
                    OmbygningsÅr = Convert.ToString(reader[14]),
                    StandSkala = Convert.ToInt32(reader[15]),
                    KundeID = Convert.ToInt32(reader[16]),
                    MedarbejderID = Convert.ToInt32(reader[17])

                };

                returnList.Add(tempProduct);
            }

            conn.Close();

            return returnList;
        }


        public static List<Kunde> ReadAllCoustomer()
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadBoligForSale = new SqlCommand
            {
                Connection = conn,
                CommandText = (" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN " +
                               "select * from Kunde " +
                               "COMMIT TRAN")
            };

            SqlDataReader reader = ReadBoligForSale.ExecuteReader();
            List<Kunde> returnList = new List<Kunde>();
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
                returnList.Add(tempKunde);
            }

            conn.Close();

            return returnList;
        }


        public static List<Ejendomsmælger> ReadAllMægler()
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadBoligForSale = new SqlCommand
            {
                Connection = conn,
                CommandText = (" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN " +
                               "select * from Ejendomsmægler " +
                               "COMMIT TRAN")
            };

            SqlDataReader reader = ReadBoligForSale.ExecuteReader();

            List<Ejendomsmælger> returnList = new List<Ejendomsmælger>();
            while (reader.Read())
            {
                Ejendomsmælger tempKunde = new Ejendomsmælger
                {
                    MedarbejderId = Convert.ToInt32(reader[0]),
                    Navn = Convert.ToString(reader[1]),
                    Tlf = Convert.ToInt32(reader[2]),
                    Mail = Convert.ToString(reader[3]),
                    Stilling = Convert.ToString(reader[4]),

                };
                returnList.Add(tempKunde);
            }

            conn.Close();

            return returnList;
        }


        public Kunde ReadAllCoustomerWithKundeId(int KundeId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadBoligForSale = new SqlCommand
            {
                Connection = conn,
                CommandText = ("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN " +
                               "select * from Kunde where KundeId = @kundeId " +
                               "COMMIT TRAN")
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

        public Bolig ReadAllBoligWithBoligId(string boligAttribut, int boligAttributVærdi)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadOneBoligcmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ($"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN " +
                               $"select * from Bolig where {boligAttribut} = {boligAttributVærdi} " +
                               $"COMMIT TRAN")
            };

            ReadOneBoligcmd.Parameters.AddWithValue($"{boligAttribut}", Convert.ToInt32(boligAttributVærdi));

            SqlDataReader reader = ReadOneBoligcmd.ExecuteReader();

            while (reader.Read())
            {

                Bolig tempBolig = new Bolig
                {
                    BoligID = Convert.ToInt32(reader[0]),
                    Adresse = Convert.ToString(reader[1]),
                    PostNr = Convert.ToInt32(reader[2]),
                    GrundM2 = Convert.ToInt32(reader[3]),
                    HusM2 = Convert.ToInt32(reader[4]),
                    Pris = Convert.ToInt32(reader[5]),
                    EjendomsType = Convert.ToString(reader[6]),
                    Have = Convert.ToInt32(reader[7]),
                    Alder = Convert.ToString(reader[8]),
                    Etager = Convert.ToInt32(reader[9]),
                    KøkkenAlder = Convert.ToString(reader[10]),
                    BadeværelsesAlder = Convert.ToString(reader[11]),
                    SalgsDato = IntToStringDate(Convert.ToInt32(reader[12])),
                    OprettelsesDato = Convert.ToString(reader[13]),
                    OmbygningsÅr = Convert.ToString(reader[14]),
                    StandSkala = Convert.ToInt32(reader[15]),
                    KundeID = Convert.ToInt32(reader[16]),
                    MedarbejderID = Convert.ToInt32(reader[17])
                };

                return tempBolig;
            }

            return default;
        }

        public List<Bolig> ReadAllBoligWithAttributeInt(string boligAttribut, int boligAttributVærdi)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadBoligForSale = new SqlCommand
            {
                Connection = conn,
                CommandText = $"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN" +
                              $" SELECT * FROM dbo.Bolig WHERE {boligAttribut} = '{boligAttributVærdi}' " +
                              $"COMMIT TRAN"
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
                    EjendomsType = Convert.ToString(reader[6]),
                    Have = Convert.ToInt32(reader[7]),
                    Alder = Convert.ToString(reader[8]),
                    Etager = Convert.ToInt32(reader[9]),
                    KøkkenAlder = Convert.ToString(reader[10]),
                    BadeværelsesAlder = Convert.ToString(reader[11]),
                    SalgsDato = IntToStringDate(Convert.ToInt32(reader[12])),
                    OprettelsesDato = Convert.ToString(reader[13]),
                    OmbygningsÅr = Convert.ToString(reader[14]),
                    StandSkala = Convert.ToInt32(reader[15]),
                    KundeID = Convert.ToInt32(reader[16]),
                    MedarbejderID = Convert.ToInt32(reader[17])
                };

                returnList.Add(tempProduct);
            }

            conn.Close();

            return returnList;
        }

        public List<Bolig> ReadAllBoligWithWithQuery(string SqlQuery)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadBoligForSale = new SqlCommand
            {
                Connection = conn,
                CommandText = SqlQuery
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
                    EjendomsType = Convert.ToString(reader[6]),
                    Have = Convert.ToInt32(reader[7]),
                    Alder = Convert.ToString(reader[8]),
                    Etager = Convert.ToInt32(reader[9]),
                    KøkkenAlder = Convert.ToString(reader[10]),
                    BadeværelsesAlder = Convert.ToString(reader[11]),
                    SalgsDato = IntToStringDate(Convert.ToInt32(reader[12])),
                    OprettelsesDato = Convert.ToString(reader[13]),
                    OmbygningsÅr = Convert.ToString(reader[14]),
                    StandSkala = Convert.ToInt32(reader[15]),
                    KundeID = Convert.ToInt32(reader[16]),
                    MedarbejderID = Convert.ToInt32(reader[17])
                };

                returnList.Add(tempProduct);
            }

            conn.Close();

            return returnList;
        }

        public Ejendomsmælger ReadAllMælgerWithMedarbejderId(int MedarbejderId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadOneMæglercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = (" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN" +
                               "select * from Ejendomsmægler where MedarbejderId = @MedarbejderId " +
                               "COMMIT TRAN")
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

        public Ejendomsmælger ReadOneMedarbejder()
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadOneMedarbejdercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = (" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN " +
                               "select Navn, Stilling from Ejendomsmægler " +
                               "COMMIT TRAN")
            };



            SqlDataReader reader = ReadOneMedarbejdercmd.ExecuteReader();
            while (reader.Read())
            {
                Ejendomsmælger tempMælger = new Ejendomsmælger
                {

                    Navn = Convert.ToString(reader[0]),
                    Stilling = Convert.ToString(reader[1])

                };

                return tempMælger;
            }

            return default;
        }


        public static List<Ejendomsmælger> ReadOneMedarbejder2()
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            //var readAllProducts = new SqlCommand // dette er det samme 
            SqlCommand ReadOneMedarbejdercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = (" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN " +
                               "select Navn, Stilling from Ejendomsmægler " +
                               "COMMIT TRAN")
            };

            //ReadOneMedarbejdercmd.Parameters.AddWithValue("@MedarbejderId", mægler.MedarbejderId);

            SqlDataReader reader = ReadOneMedarbejdercmd.ExecuteReader();

            List<Ejendomsmælger> returnList = new List<Ejendomsmælger>();
            while (reader.Read())
            {
                Ejendomsmælger tempMedarbejder = new Ejendomsmælger
                {
                    Navn = Convert.ToString(reader[0]),
                    Stilling = Convert.ToString(reader[1])
                };

                returnList.Add(tempMedarbejder);
            }

            conn.Close();

            return returnList;
        }
    }
}
