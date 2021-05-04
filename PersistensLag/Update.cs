using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistensLag
{
    class Update
    {
        private void UpdateBolig()
        {
            SqlConnection conn = new SqlConnection(Globals.strconn);

            conn.Open();

            SqlCommand UpdateBolig = new SqlCommand
            {
                Connection = conn,
                CommandText =
                    ("Update Kunde set Navn=@navn, Tlfnr=@tlfNr,  Mail=@mail, Adresse=@adresse, Køber=1, Sælger= 0")

            };




            UpdateBolig.Parameters.AddWithValue("navn", int.Parse(BoligNavnTextBox.Text));
                cmd.Parameters.AddWithValue("@navn", textBox13.Text);
                cmd.Parameters.AddWithValue("@adresse", textBox10.Text);
                cmd.Parameters.AddWithValue("@mail", textBox11.Text);
                cmd.Parameters.AddWithValue("@tlfNr", int.Parse(textBox12.Text));
                cmd.Parameters.AddWithValue("@city", textBox5.Text);
                cmd.Parameters.AddWithValue("@postNr", int.Parse(textBox9.Text));

        }
           
        
    }
}
