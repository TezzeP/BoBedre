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
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide(); 
            OpretKunde goTo = new OpretKunde();
            goTo.ShowDialog(); 
            Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide(); 
            OpdaterKunde goTo = new OpdaterKunde();
            goTo.ShowDialog(); 
            Close(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide(); 
            SeSletKunde goTo = new SeSletKunde();
            goTo.ShowDialog(); 
            Close(); 
        }
       
        private void SeSletMæglerKnap_Click(object sender, EventArgs e)
        {
            Hide(); 
            SeSletMægler goTo = new SeSletMægler();
            goTo.ShowDialog(); 
            Close();

        }

        private void OpdaterMæglerKnap_Click(object sender, EventArgs e)
        {
            Hide(); 
            OpdaterMægler goTo = new OpdaterMægler();
            goTo.ShowDialog(); 
            Close(); 
        }

        private void OpretMæglerKnap_Click(object sender, EventArgs e)
        {
            Hide(); 
            OpretMægler goTo = new OpretMægler();
            goTo.ShowDialog(); 
            Close(); 
        }

        private void OpdaterBoligKnap_Click(object sender, EventArgs e)
        {
            Hide(); 
            OpretBolig goTo = new OpretBolig();
            goTo.ShowDialog(); 
            Close(); 
        }

        private void SeSletBoligKnap_Click(object sender, EventArgs e)
        {
            Hide(); 
            SeSletBolig goTo = new SeSletBolig();
            goTo.ShowDialog(); 
            Close(); 
        }

        private void OpretBoligKnap_Click(object sender, EventArgs e)
        {
            Hide(); 
            OpdaterBolig goTo = new OpdaterBolig();
            goTo.ShowDialog(); 
            Close(); 
        }

        private void CRUDMenuknap_Click(object sender, EventArgs e)
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
