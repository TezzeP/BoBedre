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
            Hide(); // minimere forsiden
            OpretKunde goTo = new OpretKunde();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            OpdaterKunde goTo = new OpdaterKunde();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            SeSletKunde goTo = new SeSletKunde();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            SeSletMægler goTo = new SeSletMægler();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            OpdaterMægler goTo = new OpdaterMægler();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            SeSletBolig goTo = new SeSletBolig();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            OpretBolig goTo = new OpretBolig();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            OpdaterBolig goTo = new OpdaterBolig();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            OpretMægler goTo = new OpretMægler();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }
    }
}
