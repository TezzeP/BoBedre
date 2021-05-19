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
        public string UpdateKunde(Kunde kunde)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            

            SqlCommand UpdateKunde = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    ("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE BEGIN TRAN " +
                     "Update Kunde set  " +
                     " Navn=@navn,      " +
                     " TlfNr=@TlfNr,    " +
                     " Mail=@mail,      " +
                     " Adresse=@adresse," +
                     " Køber=@Køber,    " +
                     " Sælger= @Sælger  " +
                     " where KundeId= @kundeId " +
                     "COMMIT TRAN"
                     )
            };

            UpdateKunde.Parameters.AddWithValue("@navn", kunde.Navn);
            UpdateKunde.Parameters.AddWithValue("@Tlfnr", kunde.Telnr);
            UpdateKunde.Parameters.AddWithValue("@Mail", kunde.Mail);
            UpdateKunde.Parameters.AddWithValue("@Adresse", kunde.Adresse);
            UpdateKunde.Parameters.AddWithValue("@Køber", kunde.Køber);
            UpdateKunde.Parameters.AddWithValue("@Sælger", kunde.Sælger);
            UpdateKunde.Parameters.AddWithValue("@kundeId", kunde.KundeId);
            int checkSucces = UpdateKunde.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("fejl i update af Kunde");
            }
            else
            {
                conn.Close();
                return ("Kunde er opdateret");
            }
            
           
        }

        public string UpdateBolig(Bolig bolig)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            SqlCommand UpdateBolig = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    ("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE BEGIN TRAN" +
                     " Update Bolig set " +
                     "Adresse=@Adresse, " +
                     "PostNr=@PostNr,   " +
                     "GrundM2=@GrundM2, " +
                     "HusM2=@HusM2, " +
                     "Pris=@Pris, " +
                     "EjendomsType= @EjendomsType," +
                     "Have= @Have," +
                     "Alder=@Alder," +
                     "KøkkenAlder=@KøkkenAlder," +
                     "BadeværelsesAlder=@BadeværelsesAlder," +
                     "SalgsDato= @SalgsDato," +
                     "OprettelsesDato= @OprettelsesDato," +
                     "OmbygningsÅr=@OmbygningsÅr,"+
                     "StandSkala = @StandSkala, " +
                     "KundeId = @KundeId,"+
                     "MedarbejderId = @MedarbejderId " +
                     "where BoligId= @BoligId " +
                     "COMMIT TRAN")
            };

            UpdateBolig.Parameters.AddWithValue("@Adresse", bolig.Adresse);
            UpdateBolig.Parameters.AddWithValue("@PostNr", bolig.PostNr);
            UpdateBolig.Parameters.AddWithValue("@GrundM2", bolig.GrundM2);
            UpdateBolig.Parameters.AddWithValue("@HusM2", bolig.HusM2);
            UpdateBolig.Parameters.AddWithValue("@Pris", bolig.Pris);
            UpdateBolig.Parameters.AddWithValue("@EjendomsType", bolig.EjendomsType);
            UpdateBolig.Parameters.AddWithValue("@Have", bolig.Have);
            UpdateBolig.Parameters.AddWithValue("@Alder", bolig.Alder);
            UpdateBolig.Parameters.AddWithValue("@KøkkenAlder", bolig.KøkkenAlder);
            UpdateBolig.Parameters.AddWithValue("@BadeværelsesAlder", bolig.BadeværelsesAlder);
            UpdateBolig.Parameters.AddWithValue("@SalgsDato", bolig.SalgsDato);
            UpdateBolig.Parameters.AddWithValue("@OprettelsesDato", bolig.OprettelsesDato);
            UpdateBolig.Parameters.AddWithValue("@OmbygningsÅr", bolig.OmbygningsÅr);
            UpdateBolig.Parameters.AddWithValue("@StandSkala", bolig.StandSkala);
            UpdateBolig.Parameters.AddWithValue("@BoligId", bolig.BoligID);
            UpdateBolig.Parameters.AddWithValue("@KundeId", bolig.KundeID);
            UpdateBolig.Parameters.AddWithValue("@MedarbejderId", bolig.MedarbejderID);

            int checkSucces = UpdateBolig.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Der er fejl i update blig");
            }
            else
            {
                conn.Close();
                return ("Boligen er Opdateret");
            }
        }

        public string UpdateMægler(Ejendomsmælger mægler)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            SqlCommand UpdateMægler = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    (" SET TRANSACTION ISOLATION LEVEL SERIALIZABLE BEGIN TRAN " +
                     " Update Ejendomsmægler set " +
                     " Navn=@Navn," +
                     " TlfNr=@TlfNr,  " +
                     " Mail=@Mail," +
                     " Stilling= @Stilling" +
                     " where MedarbejderId= @MedarbejderId " +
                     "COMMIT TRAN")


            };

            UpdateMægler.Parameters.AddWithValue("@MedarbejderId", mægler.MedarbejderId);
            UpdateMægler.Parameters.AddWithValue("@Navn", mægler.Navn);
            UpdateMægler.Parameters.AddWithValue("@TlfNr", mægler.Tlf);
            UpdateMægler.Parameters.AddWithValue("@Mail", mægler.Mail);
            UpdateMægler.Parameters.AddWithValue("@Stilling", mægler.Stilling);

            int checkSucces = UpdateMægler.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Fejl i Update af Mægler");
            }
            else
            {
                conn.Close();
                return ("Mælger er opdateret");
            }
        }






    }
}
