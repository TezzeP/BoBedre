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
        public string OpretBolig(Bolig bolig)
        {
            SqlConnection conn = new SqlConnection(PersistensLag.Globals.strconn);
            conn.Open();
            string sSQL = $"INSERT INTO Bolig(Adresse, PostNr, GrundM2, HusM2, Pris, SalgsDato, OprettelsesDato, StandSkala, KundeId) VALUES ('{bolig.Adresse}', {bolig.PostNr}, {bolig.GrundM2}, {bolig.HusM2}, {bolig.Pris}, '{bolig.SalgsDato}'," +
                $"'{bolig.OprettelsesDato}', {bolig.StandSkala}, {bolig.KundeID});";
            
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
            string sSQL = $"INSERT INTO Ejendomsmælger(Navn, TlfNr, Mail, Stilling) VALUES ('{ejendomsmælger.Navn}', {ejendomsmælger.Tlf}, '{ejendomsmælger.Mail}', '{ejendomsmælger.Stilling}');";

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
