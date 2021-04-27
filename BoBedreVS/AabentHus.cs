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
using PersistensLag;


namespace BoBedreVS
{
    public partial class AabentHus : Form
    {
        public AabentHus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sorting sortering = new Sorting();
            
            dataGridView1.DataSource = sortering
                .SortByAdresseFirstLetterAndM2Over145();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            Forside goTo = new Forside();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }
    }
}
