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
using Models;
using PersistensLag;

namespace BoBedreVS
{
    public partial class OpretBolig : Form
    {
        
        public OpretBolig()
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

        private void CreateBolig_Click(object sender, EventArgs e)
        {
            Bolig sendBolig = new Bolig();
            Create create = new Create();

            sendBolig.Adresse = Convert.ToString(AdresseTextBox.Text);
            sendBolig.PostNr = Convert.ToInt32(PostNrTextBox.Text);
            sendBolig.GrundM2 = Convert.ToDouble(GrundM2TextBox.Text);
            sendBolig.HusM2 = Convert.ToDouble(HusM2TextBox.Text);
            sendBolig.Pris = Convert.ToDouble(PrisTextBox.Text);
            sendBolig.EjendomsType = Convert.ToString(EjendomsTypeTextBox.Text);
            sendBolig.Have = JaCheckBox.Checked ? 1 : 0;
            sendBolig.Alder = Convert.ToString(AlderTextBox.Text);
            sendBolig.Etager = Convert.ToInt32(EtagerTextBox.Text);
            sendBolig.KøkkenAlder = Convert.ToString(KøkkenAlderTextBox.Text);
            sendBolig.BadeværelsesAlder = Convert.ToString(BadeværelsesAlderTextBox.Text);
            sendBolig.SalgsDato = Convert.ToInt32(SalgsDatoTextBox.Text);
            sendBolig.OprettelsesDato = Convert.ToString(OprettelsesdatoTextBox.Text);
            sendBolig.OmbygningsÅr = Convert.ToString(OmbygningsÅrTextBox.Text);
            sendBolig.StandSkala = Convert.ToInt32(StandSkalaTextBox.Text);
            sendBolig.KundeID = Convert.ToInt32(KundeIdTextBox.Text);
            sendBolig.MedarbejderID = Convert.ToInt32(MedarbejderIdTextBox.Text);

          
            

            MessageBox.Show(create.OpretBoligNowak(sendBolig));

            // her mangler en try catch, men den hopper altid i catch klausul
        }
    }
}
