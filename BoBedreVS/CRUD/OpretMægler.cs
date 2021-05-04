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
    }
}
