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
            SqlConnection conn = new SqlConnection(PersistensLag.Globals.strconn);
            conn.Open();
            string sSQL = $"INSERT INTO mægler VALUES ('{NavnTextBox.Text}', {TelefonNrTextBox.Text}, '{MailTextBox.Text}', '{StillingTextBox.Text}');"; 
        }
    }
}
