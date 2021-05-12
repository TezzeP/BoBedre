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
        public void DeleteMægler(int MedarbejderId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);
            conn.Open();
            SqlCommand ReadOneMæglercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ($"DELETE FROM Ejendomsmælger WHERE MedarbejderId = @MedarbejderId")
                
            };

            ReadOneMæglercmd.Parameters.AddWithValue("@MedarbejderId", Convert.ToInt32(MedarbejderId));
            ReadOneMæglercmd.ExecuteReader();
        }

        public void DeleteBolig(int BoligId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);
            conn.Open();
            SqlCommand ReadOneMæglercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ($"DELETE FROM Bolig WHERE BoligId = @BoligId")

            };

            ReadOneMæglercmd.Parameters.AddWithValue("@BoligId", Convert.ToInt32(BoligId));
            ReadOneMæglercmd.ExecuteReader();
        }

        public void DeleteKunde(int KundeId)
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);
            conn.Open();
            SqlCommand ReadOneMæglercmd = new SqlCommand
            {
                Connection = conn,
                CommandText = ($"DELETE FROM Kunde WHERE KundeId = @KundeId")

            };

            ReadOneMæglercmd.Parameters.AddWithValue("@KundeId", Convert.ToInt32(KundeId));
            ReadOneMæglercmd.ExecuteReader();
        }




    }
}
