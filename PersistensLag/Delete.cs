using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace PersistensLag
{
    public class Delete
    {
        public string DeleteMægler(int MedarbejderId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);
            conn.Open();
            SqlCommand ReadOneMæglercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ($"DELETE FROM Ejendomsmægler WHERE MedarbejderId = @MedarbejderId")
            };

            ReadOneMæglercmd.Parameters.AddWithValue("@MedarbejderId", Convert.ToInt32(MedarbejderId));
            int checkSucces = ReadOneMæglercmd.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Medarbejder blev IKKE slettet");
            }
            else
            {
                conn.Close();
                return ("Medarbejder Belv slettet");
            }
        }

        public string DeleteBolig(int BoligId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);
            conn.Open();
            SqlCommand ReadOneMæglercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ($"DELETE FROM Bolig WHERE BoligId = @BoligId")

            };

            ReadOneMæglercmd.Parameters.AddWithValue("@BoligId", Convert.ToInt32(BoligId));
            int checkSucces = ReadOneMæglercmd.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Bolig blev IKKE slettet");
            }
            else
            {
                conn.Close();
                return ("Bolig blev slettet");
            }
        }

        public string DeleteKunde(int KundeId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);
            conn.Open();
            SqlCommand ReadOneMæglercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ($"DELETE FROM Kunde WHERE KundeId = @KundeId")

            };

            ReadOneMæglercmd.Parameters.AddWithValue("@KundeId", Convert.ToInt32(KundeId));
            int checkSucces = ReadOneMæglercmd.ExecuteNonQuery();
            if (checkSucces == 0)
            {
                conn.Close();
                return ("Kunde blev IKKE slettet");
            }
            else
            {
                conn.Close();
                return ("Kunde blev slettet");
            }
        }




    }
}
