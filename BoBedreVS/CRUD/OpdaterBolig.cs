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
    public partial class OpdaterBolig : Form
    {
        public OpdaterBolig()
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
            Bolig boligData = new Bolig();
            Read readOne = new Read();
            Update update = new Update();
            

                 boligData.BoligID = Convert.ToInt32(BoligIdTextBox.Text);
                 boligData.Adresse = Convert.ToString(BoligAdresseTextBox.Text);
                 boligData.PostNr = Convert.ToInt32(BoligPostNrTextBox.Text);
                 boligData.GrundM2 = Convert.ToInt32(BoligGrundM2TextBox.Text);
                 boligData.HusM2 = Convert.ToInt32(BoigHusM2TextBox.Text);
                 boligData.Pris = Convert.ToInt32(BoligPrisTextBox.Text);
                 boligData.SalgsDato = BoligSalgsdatoTextBox.Text;
                 boligData.OprettelsesDato = BoligOprettelsesTextBox.Text;
                 boligData.StandSkala = Convert.ToInt32(StandSkalaTextBox.Text);

                update.UpdateBolig(boligData); 

           
        }

        private void LæsBoligData_Click(object sender, EventArgs e)
        {

            Read readOne = new Read();
            Bolig boligData = readOne.ReadOneBolig(Convert.ToInt32(BoligIdTextBox.Text));

            BoligIdTextBox.Text = Convert.ToString(boligData.BoligID);
            BoligAdresseTextBox.Text = Convert.ToString(boligData.Adresse);
            BoligPostNrTextBox.Text = Convert.ToString(boligData.PostNr);
            BoligGrundM2TextBox.Text = Convert.ToString(boligData.GrundM2);
            BoigHusM2TextBox.Text = Convert.ToString(boligData.HusM2);
            BoligPrisTextBox.Text = Convert.ToString(boligData.Pris);
            BoligSalgsdatoTextBox.Text = Convert.ToString(boligData.SalgsDato);
            BoligOprettelsesTextBox.Text = Convert.ToString(boligData.OprettelsesDato);
            StandSkalaTextBox.Text = Convert.ToString(boligData.StandSkala);

        }
    }
}
