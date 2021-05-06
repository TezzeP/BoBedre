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

namespace BoBedreVS
{
    public partial class SeSletMægler : Form
    {
        public SeSletMægler()
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

        private void ReadAndShowMægler_Click(object sender, EventArgs e)
        {
            ReadAndShow readAndShowBolig = new ReadAndShow();

            dataGridView1.DataSource = readAndShowBolig.ReadAndShowMægler();
        }

        private void DeleteMægler_Click(object sender, EventArgs e)
        {
            HandleCRUD deleteMægler = new HandleCRUD();
            deleteMægler.HandleDeleteMægler(Convert.ToInt32(MedarbejderIdTextBox.Text));
        }

        
    }
}
