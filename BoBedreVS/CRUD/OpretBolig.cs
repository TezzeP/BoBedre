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

        private void OpretBolig_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Bolig sendBolig = new Bolig();
                sendBolig.Adresse = AdresseTextBox.Text;
                sendBolig.PostNr = Convert.ToInt32(PostNrTextBox.Text);
                sendBolig.GrundM2 = Convert.ToInt32(GrundM2TextBox.Text);
                sendBolig.HusM2 = Convert.ToInt32(HusM2TextBox.Text);
                sendBolig.Pris = Convert.ToInt32(PrisTextBox.Text);
                sendBolig.SalgsDato = SalgsDatoTextBox.Text;
                sendBolig.OprettelsesDato = OprettelsesdatoTextBox.Text;
                sendBolig.StandSkala = Convert.ToInt32(StandSkalaTextBox.Text);
                sendBolig.KundeID = Convert.ToInt32(KundeIdTextBox.Text);

                Create create = new Create();
                MessageBox.Show(create.OpretBolig(sendBolig));
                
            }
            catch (Exception)
            {
                MessageBox.Show("mangler input (tror jeg) :)");
                
            }
            
            
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
