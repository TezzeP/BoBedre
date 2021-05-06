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
using BusinessLogic;


namespace BoBedreVS
{
    public partial class SeSletKunde : Form
    {
        
        public SeSletKunde()
        {
            InitializeComponent();
        }

        private void SeSletKunde_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            CRUD goTo = new CRUD();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void ReadAndShowKunde_Click(object sender, EventArgs e)
        {
            ReadAndShow readAndShowBolig = new ReadAndShow();

            dataGridView1.DataSource = readAndShowBolig.ReadAndShowKunde();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            HandleCRUD deleteKunde = new HandleCRUD();
            deleteKunde.HandleDeleteKunde(Convert.ToInt32(KundeIdTextBox.Text));
        }
    }
}
