using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using PersistensLag;

namespace BoBedreVS
{
    public partial class SeSletBolig : Form
    {
        public SeSletBolig()
        {
            InitializeComponent();
        }

        private void SeSletBolig_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            CRUD goTo = new CRUD();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        private void ReadAllMægler_Click(object sender, EventArgs e)
        {
            ReadAndShow readAndShowBolig = new ReadAndShow();

            dataGridView1.DataSource = readAndShowBolig.ReadAndShowBolig();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            HandleCRUD deleteBolig = new HandleCRUD();
            deleteBolig.HandleDeleteBolig(Convert.ToInt32(BoligIdTextBox.Text));
        }
    }
}
