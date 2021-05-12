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
    public partial class OpdaterMægler : Form
    {
        public OpdaterMægler()
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

        
        private void LæsMælgerData_Click(object sender, EventArgs e)
        {
            Read readOneMægler = new Read();
            Ejendomsmælger mælgerData = readOneMægler.ReadAllMælgerWithMedarbejderId(Convert.ToInt32(MedarbejderIdTextBox1.Text));

            MedarbejderIdTextBox1.Text = Convert.ToString(mælgerData.MedarbejderId);
            MælgerNavnTextBox.Text = Convert.ToString(mælgerData.Navn);
            MæglerTlfTextBox3.Text = Convert.ToString(mælgerData.Tlf);
            MæglerMailTextBox4.Text = Convert.ToString(mælgerData.Mail);
            MæglerStillingTextBox5.Text = Convert.ToString(mælgerData.Stilling);
        }

        private void UpdateMælger_Click(object sender, EventArgs e)
        {
            Ejendomsmælger mælgerData = new Ejendomsmælger();
            Read readOneMÆgler = new Read();
            Update update = new Update();


            mælgerData.MedarbejderId = Convert.ToInt32(MedarbejderIdTextBox1.Text);
            mælgerData.Navn = Convert.ToString(MælgerNavnTextBox.Text);
            mælgerData.Tlf = Convert.ToInt32(MæglerTlfTextBox3.Text);
            mælgerData.Mail = Convert.ToString(MæglerMailTextBox4.Text);
            mælgerData.Stilling = Convert.ToString(MæglerStillingTextBox5.Text);
           

            update.UpdateMægler(mælgerData);

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
