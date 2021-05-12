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
        public void UpdateKunde(Kunde kunde)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            SqlCommand UpdateKunde = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    (" Update Kunde set " +
                     " Navn=@navn,      " +
                     " TlfNr=@TlfNr,    " +
                     " Mail=@mail,      " +
                     " Adresse=@adresse," +
                     " Køber=@Køber,    " +
                     " Sælger= @Sælger  " +
                     " where KundeId= @kundeId"
                     )
            };

            UpdateKunde.Parameters.AddWithValue("@navn", kunde.Navn);
            UpdateKunde.Parameters.AddWithValue("@Tlfnr", kunde.Telnr);
            UpdateKunde.Parameters.AddWithValue("@Mail", kunde.Mail);
            UpdateKunde.Parameters.AddWithValue("@Adresse", kunde.Adresse);
            UpdateKunde.Parameters.AddWithValue("@Køber", kunde.Køber);
            UpdateKunde.Parameters.AddWithValue("@Sælger", kunde.Sælger);
            UpdateKunde.Parameters.AddWithValue("@kundeId", kunde.KundeId);
            UpdateKunde.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateBolig(Bolig bolig)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            SqlCommand UpdateBolig = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    (" Update Bolig set " +
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
                     "StandSkala = @StandSkala" +
                     "where BoligId= @BoligId")
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
            UpdateBolig.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateMægler(Ejendomsmælger mægler)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            SqlCommand UpdateMægler = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    (" Update Ejendomsmælger set " +
                     " Navn=@Navn," +
                     " TlfNr=@TlfNr,  " +
                     " Mail=@Mail," +
                     " Stilling= @Stilling" +
                     " where MedarbejderId= @MedarbejderId")


            };

            UpdateMægler.Parameters.AddWithValue("@MedarbejderId", mægler.MedarbejderId);
            UpdateMægler.Parameters.AddWithValue("@Navn", mægler.Navn);
            UpdateMægler.Parameters.AddWithValue("@TlfNr", mægler.Tlf);
            UpdateMægler.Parameters.AddWithValue("@Mail", mægler.Mail);
            UpdateMægler.Parameters.AddWithValue("@Stilling", mægler.Stilling);

            UpdateMægler.ExecuteNonQuery();
            conn.Close();
        }






    }
}
