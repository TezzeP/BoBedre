using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PersistensLag;
using Models;

namespace PersistensLag
{
    public class Create
    {
        public string OpretBoligGustav(Bolig bolig)
        {
            SqlConnection conn = new SqlConnection(PersistensLag.Globals.strconn);
            conn.Open();
            string sSQL = $"INSERT INTO Bolig(Adresse, PostNr, GrundM2, HusM2, Pris, EjendomsType, Have, Alder, Etager, KøkkenAlder, BadeværelsesAlder, " +
                          $"SalgsDato, OprettelsesDato, OmbygningsÅr, StandSkala, KundeId) VALUES ('{bolig.Adresse}', {bolig.PostNr}, {bolig.GrundM2}, " +
                          $"{bolig.HusM2}, {bolig.Pris}, '{bolig.EjendomsType}', {bolig.Have}, {bolig.Alder}, {bolig.Etager}, '{bolig.KøkkenAlder}', '{bolig.BadeværelsesAlder}', '{bolig.SalgsDato}'," +
                          $"'{bolig.OprettelsesDato}', {bolig.OmbygningsÅr}, {bolig.StandSkala}, {bolig.KundeID});";

            SqlCommand command = new SqlCommand(sSQL, conn);

            int checkSucces = command.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Input påkrævet i alle felter udover salgsdato");
            }
            else 
            {
                conn.Close();
                return ("Boligen er blevet tilføjet til databasen");
            }
        }

        public string OpretBoligNowak(Bolig bolig)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);
            conn.Open();
            SqlCommand createBolig = new SqlCommand
            {
                Connection = conn,
                CommandText = 
                    ("INSERT INTO Bolig values" + 
                     "(@Adresse, @PostNr, @GrundM2, @HusM2, @Pris," +
                     "@EjendomsType,@Have,@Alder,@Etager,@KøkkenAlder," +
                     "@BadeværelsesAlder,@SalgsDato, @OprettelsesDato, " +
                     "@OmbygningsÅr, @StandSkala, @KundeId)")

                
            };
            createBolig.Parameters.AddWithValue("@Adresse", bolig.Adresse);
            createBolig.Parameters.AddWithValue("@PostNr", bolig.PostNr);
            createBolig.Parameters.AddWithValue("@GrundM2", bolig.GrundM2);
            createBolig.Parameters.AddWithValue("@HusM2", bolig.HusM2);
            createBolig.Parameters.AddWithValue("@Pris", bolig.Pris);
            createBolig.Parameters.AddWithValue("@EjendomsType", bolig.EjendomsType);
            createBolig.Parameters.AddWithValue("@Have", bolig.Have);
            createBolig.Parameters.AddWithValue("@Alder", bolig.Alder);
            createBolig.Parameters.AddWithValue("@Etager", bolig.Etager);
            createBolig.Parameters.AddWithValue("@KøkkenAlder", bolig.KøkkenAlder);
            createBolig.Parameters.AddWithValue("@BadeværelsesAlder", bolig.BadeværelsesAlder);
            createBolig.Parameters.AddWithValue("@SalgsDato", bolig.SalgsDato);
            createBolig.Parameters.AddWithValue("@OprettelsesDato", bolig.OprettelsesDato);
            createBolig.Parameters.AddWithValue("@OmbygningsÅr", bolig.OmbygningsÅr);
            createBolig.Parameters.AddWithValue("@StandSkala", bolig.StandSkala);
            createBolig.Parameters.AddWithValue("@KundeId", bolig.KundeID);
            int checkSucces = createBolig.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Input påkrævet i alle felter udover salgsdato");
            }
            else
            {
                conn.Close();
                return ("Boligen er blevet tilføjet til databasen");
            }
        }


        public string OpretKunde(Kunde kunde)
        {
            SqlConnection conn = new SqlConnection(PersistensLag.Globals.strconn);
            conn.Open();
            string sSQL = $"INSERT INTO Kunde VALUES ('{kunde.Navn}', {kunde.Telnr}, '{kunde.Mail}', '{kunde.Adresse}', {kunde.Køber}, {kunde.Sælger});";

            SqlCommand command = new SqlCommand(sSQL, conn);

            int checkSucces = command.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Input fejl");
            }
            else
            {
                conn.Close();
                return ("Kunden er blevet tilføjet til databasen");
            }
        }
        public string OpretEjendomsmælger(Ejendomsmælger ejendomsmælger)
        {
            SqlConnection conn = new SqlConnection(PersistensLag.Globals.strconn);
            conn.Open();
            string sSQL = $"INSERT INTO Ejendomsmægler(Navn, TlfNr, Mail, Stilling) VALUES ('{ejendomsmælger.Navn}', {ejendomsmælger.Tlf}, '{ejendomsmælger.Mail}', '{ejendomsmælger.Stilling}');";

            SqlCommand command = new SqlCommand(sSQL, conn);

            int checkSucces = command.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Input fejl");
            }
            else
            {
                conn.Close();
                return ("Ejendomsmælger er blevet tilføjet til databasen");
            }


        }

    }
    

    
}
