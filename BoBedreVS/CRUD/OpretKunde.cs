using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BoBedreVS
{
    public partial class OpretKunde : Form
    {
        public static string strconn = "Server=den1.mssql8.gear.host; Database=bobedre1; User ID=bobedre1; Password=Js63Ot-_y8SE";
        public OpretKunde()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            CRUD goTo = new CRUD();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void OpretKundeKnab_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string sSQL = $"INSERT INTO Kunde VALUES ({KundeNavnTextBox.Text}, {KundeTelefonNrTextBox.Text}, {KundeMailTextBox.Text}, {KundeAdresseTextBox.Text}, '{KøberCheckBox.Checked}', {SælgerCheckBox.Checked});";
            SqlCommand command = new SqlCommand(sSQL, conn);
            bool tekstUdfyldt = KundeAdresseTextBox.Text != "" && KundeMailTextBox.Text != "" && KundeNavnTextBox.Text != "" && KundeTelefonNrTextBox.Text != ""
                && KøberCheckBox.Checked == true;
            bool enCheckBoxUdfyldt = KøberCheckBox.Checked == true || SælgerCheckBox.Checked == true;


            if (KundeAdresseTextBox.Text == "" || KundeMailTextBox.Text == "" || KundeNavnTextBox.Text == "" || KundeTelefonNrTextBox.Text == "")
            {
                MessageBox.Show("input påkrævet i navn, mail, adresse og telefon nr");
            }
            if (KøberCheckBox.Checked == false && SælgerCheckBox.Checked == false)
            {
                MessageBox.Show("kunde skal enten oprettes som køber eller sælger");
                
            }
            
            else if (tekstUdfyldt && enCheckBoxUdfyldt)
            {
                command.ExecuteNonQuery();
                MessageBox.Show($"kunden er blevet tilføjet til databasen");
                conn.Close();
            }
            
        }
    }
}
