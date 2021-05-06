using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BoBedreVS
{
    public partial class Forside : Form
    {
        public Forside()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide(); 
            MedarbejderInfo goTo = new MedarbejderInfo();
            goTo.ShowDialog();
            Close(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide(); 
            AabentHus goTo = new AabentHus();
            goTo.ShowDialog(); 
            Close(); 
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
