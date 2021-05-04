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
    public partial class OpdaterKunde : Form
    {
        public OpdaterKunde()
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

            Kunde kundeData = new Kunde();

            kundeData.Navn = KundeNavnTextBox.Text;
            kundeData.Telnr = Convert.ToInt32(KundeTelnrTextBox.Text);
            kundeData.Mail = KundeMailTextBox.Text;
            kundeData.Adresse = KundeAdresseTextBox.Text;

            kundeData.Køber = KøberCB.Checked ? 1 : 0;
            kundeData.Sælger = SælgerCB.Checked ? 1 : 0;

            Update update = new Update();
            update.UpdateBolig(kundeData);
        }

        
    }
}
