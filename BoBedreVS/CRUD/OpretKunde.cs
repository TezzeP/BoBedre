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
using Models;
using PersistensLag;

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
            int Sælgerbit = 1;
            int Køberbit = 1;
            if (KøberCheckBox.Checked == true)
            {
                Køberbit = 1;
            }
            else if (KøberCheckBox.Checked == false)
            {
                Køberbit = 0;
            }
            if (SælgerCheckBox.Checked == true)
            {
                Sælgerbit = 1;
            }
            else if (SælgerCheckBox.Checked == false)
            {
                Sælgerbit = 0;
            }
            try
            {
                Kunde sendKunde = new Kunde();
                sendKunde.Navn = KundeNavnTextBox.Text;
                sendKunde.Telnr = Convert.ToInt32(KundeTelefonNrTextBox.Text);
                sendKunde.Mail = KundeMailTextBox.Text;
                sendKunde.Adresse = KundeAdresseTextBox.Text;
                sendKunde.Køber = Køberbit;
                sendKunde.Sælger = Sælgerbit;
                

                Create create = new Create();
                MessageBox.Show(create.OpretKunde(sendKunde));

            }
            catch (Exception)
            {
                MessageBox.Show("mangler input (tror jeg) :)");

            }
            /*SqlConnection conn = new SqlConnection(PersistensLag.Globals.strconn);
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
            }*/

        }

        private void CRUD_Click(object sender, EventArgs e)
        {
            Hide();
            CRUD goTo = new CRUD();
            goTo.ShowDialog();
            Close();
        }

        private void Statistik_Click(object sender, EventArgs e)
        {
            Hide();
            Statistik goTo = new Statistik();
            goTo.ShowDialog();
            Close();
        }

        private void PrisVudering_Click(object sender, EventArgs e)
        {
            Hide();
            PrisVudering goTo = new PrisVudering();
            goTo.ShowDialog();
            Close();
        }

        private void MedarbejderPortal_Click(object sender, EventArgs e)
        {
            Hide();
            MedarbejderInfo goTo = new MedarbejderInfo();
            goTo.ShowDialog();
            Close();
        }

        private void AabentHus_Click(object sender, EventArgs e)
        {
            Hide();
            AabentHus goTo = new AabentHus();
            goTo.ShowDialog();
            Close();
        }
    }
}
