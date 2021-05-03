﻿using System;
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
            SqlConnection conn = new SqlConnection(PersistensLag.Globals.strconn);
            conn.Open();
            int sælgerbit = 1;
            int køberbit = 1;
            if (KøberCheckBox.Checked == true)
            {
                køberbit = 1;
            }
            else if (KøberCheckBox.Checked == false)
            {
                køberbit = 0;
            }
            if (SælgerCheckBox.Checked == true)
            {
                sælgerbit = 1;
            }
            else if (SælgerCheckBox.Checked == false)
            {
                sælgerbit = 0;
            }
            string sSQL = $"INSERT INTO Kunde VALUES ('{KundeNavnTextBox.Text}', {KundeTelefonNrTextBox.Text}, '{KundeMailTextBox.Text}', '{KundeAdresseTextBox.Text}', {køberbit}, {sælgerbit});";
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
