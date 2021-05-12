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
using BusinessLogic;
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
            Kunde kundeData = new Kunde();
            HandleCRUD createKunde = new HandleCRUD();

            kundeData.Navn = KundeNavnTextBox.Text;
            kundeData.Telnr = Convert.ToInt32(KundeTelefonNrTextBox.Text);
            kundeData.Mail = KundeMailTextBox.Text;
            kundeData.Adresse = KundeAdresseTextBox.Text;

            kundeData.Køber = KøberCheckBox.Checked ? 1 : 0;
            kundeData.Sælger = SælgerCheckBox.Checked ? 1 : 0;


            MessageBox.Show(createKunde.HandleOpretKunde(kundeData));
            
            // Kommenteret ud da koden oven over gør præsis det samme 
            /*
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
                MessageBox.Show("Mangler input (tror jeg) :)");

            }
            */
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
