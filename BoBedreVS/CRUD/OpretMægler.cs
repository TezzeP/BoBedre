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
    public partial class OpretMægler : Form
    {
        public OpretMægler()
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

        private void OpretMæglerKnap_Click(object sender, EventArgs e)
        {
            
            
                Ejendomsmælger sendEjendomsmælger = new Ejendomsmælger();
                sendEjendomsmælger.Navn = NavnTextBox.Text;
                sendEjendomsmælger.Tlf = Convert.ToInt32(TelefonNrTextBox.Text);
                sendEjendomsmælger.Mail = MailTextBox.Text;
                sendEjendomsmælger.Stilling = StillingTextBox.Text;
                


                Create create = new Create();
                MessageBox.Show(create.OpretEjendomsmælger(sendEjendomsmælger));

            
            /*catch (Exception)
            {
                MessageBox.Show("mangler input (tror jeg) :)");

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
