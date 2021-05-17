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
            Update update = new Update();

            string temp = BoligSalgsdatoTextBox.Text;
            StringBuilder sb = new StringBuilder();

            sb.Append(temp.Substring(6, 4));
            sb.Append(temp.Substring(3, 2));
            sb.Append(temp.Substring(0, 2));

            MessageBox.Show(sb.ToString().Replace(" ", "0"));

            boligData.BoligID = Convert.ToInt32(BoligIdTextBox.Text);
            boligData.Adresse = Convert.ToString(BoligAdresseTextBox.Text);
            boligData.PostNr = Convert.ToInt32(BoligPostNrTextBox.Text);
            boligData.GrundM2 = Convert.ToDouble(BoligGrundM2TextBox.Text);
            boligData.HusM2 = Convert.ToDouble(BoigHusM2TextBox.Text);
            boligData.Pris = Convert.ToDouble(BoligPrisTextBox.Text);
            boligData.EjendomsType = Convert.ToString(EjendomsTypeTextBox.Text);
            boligData.Have = HaveCheckBox.Checked ? 0 : 1;
            boligData.Alder = Convert.ToString(AlderTextBox.Text);
            boligData.KøkkenAlder = Convert.ToString(KøkkenAlderTextBox.Text);
            boligData.BadeværelsesAlder = Convert.ToString(BadAlderTextBox1.Text);
            boligData.SalgsDato = Convert.ToInt32(sb.ToString().Replace(" ", "0"));
            boligData.OprettelsesDato = Convert.ToString(BoligOprettelsesTextBox.Text);
            boligData.OmbygningsÅr = Convert.ToString(OmbygningsÅrTextBox.Text);
            boligData.StandSkala = Convert.ToInt32(StandSkalaTextBox.Text);
            boligData.KundeID = Convert.ToInt32(KundeIdFKTextBox.Text);
            boligData.MedarbejderID = Convert.ToInt32(MedarbejderIdTextBox.Text);



            MessageBox.Show(update.UpdateBolig(boligData));


        }

        private void LæsBoligData_Click(object sender, EventArgs e)
        {

            Read readOne = Read.Instance();
            Bolig boligData = readOne.ReadAllBoligWithBoligId("BoligId", Convert.ToInt32(BoligIdTextBox.Text));

            BoligIdTextBox.Text = Convert.ToString(boligData.BoligID);
            BoligAdresseTextBox.Text = Convert.ToString(boligData.Adresse);
            BoligPostNrTextBox.Text = Convert.ToString(boligData.PostNr);
            BoligGrundM2TextBox.Text = Convert.ToString(boligData.GrundM2);
            BoigHusM2TextBox.Text = Convert.ToString(boligData.HusM2);
            BoligPrisTextBox.Text = Convert.ToString(boligData.Pris);
            EjendomsTypeTextBox.Text = Convert.ToString(boligData.EjendomsType);
            HaveCheckBox.Checked = Convert.ToBoolean(boligData.Have);
            AlderTextBox.Text = Convert.ToString(boligData.Alder);
            EtagerTextBox.Text = Convert.ToString(boligData.Etager);
            KøkkenAlderTextBox.Text = Convert.ToString(boligData.KøkkenAlder);
            BadAlderTextBox1.Text = Convert.ToString(boligData.BadeværelsesAlder);
            BoligSalgsdatoTextBox.Text = Convert.ToString(boligData.SalgsDato);
            BoligOprettelsesTextBox.Text = Convert.ToString(boligData.OprettelsesDato);
            OmbygningsÅrTextBox.Text = Convert.ToString(boligData.OmbygningsÅr);
            StandSkalaTextBox.Text = Convert.ToString(boligData.StandSkala);

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

        }


    }
}
