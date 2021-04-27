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
            Hide(); // minimere forsiden
            MedarbejderInfo goTo = new MedarbejderInfo();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            AabentHus goTo = new AabentHus();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void CRUD_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            CRUD goTo = new CRUD();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden

        }

        private void Statistik_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            Statistik goTo = new Statistik();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden

        }

        private void PrisVudering_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            PrisVudering goTo = new PrisVudering();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }
        private void MedarbejderPortal_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            MedarbejderInfo goTo = new MedarbejderInfo();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden

        }

        private void AabentHus_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            AabentHus goTo = new AabentHus();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden

        }

        
    }
}
