using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using PersistensLag;

namespace BoBedreVS
{
    public partial class OpdaterKunde : Form
    {
        public OpdaterKunde()
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

        
        private void Update_Click(object sender, EventArgs e)
        {
            Read readOne = Read.Instance();
            Kunde kundeData = new Kunde();
            Update update = new Update();

            kundeData.KundeId = Convert.ToInt32(KundeIdTextBox.Text);
            kundeData.Navn = KundeNavnTextBox.Text;
            kundeData.Telnr = Convert.ToInt32(KundeTelnrTextBox.Text);
            kundeData.Mail = KundeMailTextBox.Text;
            kundeData.Adresse = KundeAdresseTextBox.Text;

            kundeData.Køber = KøberCB.Checked ? 1 : 0;
            kundeData.Sælger = SælgerCB.Checked ? 1 : 0;

            
            MessageBox.Show(update.UpdateKunde(kundeData));
        }

        private void LæsKundeData_Click(object sender, EventArgs e)
        {
            
            Read readOne = Read.Instance();
            Kunde kundeData = readOne.ReadAllCoustomerWithKundeId(Convert.ToInt32(KundeIdTextBox.Text));
            
            KundeNavnTextBox.Text = kundeData.Navn;
            KundeTelnrTextBox.Text = Convert.ToString(kundeData.Telnr);
            KundeMailTextBox.Text = kundeData.Mail;
            KundeAdresseTextBox.Text = kundeData.Adresse;
            


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
