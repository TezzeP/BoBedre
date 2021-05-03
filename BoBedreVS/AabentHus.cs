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
using System.Runtime.InteropServices;


namespace BoBedreVS
{
    public partial class AabentHus : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftReact,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWitdhEllipse,
            int nHightEllipse);
        public AabentHus()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Hide(); // minimere forsiden
            Forside goTo = new Forside();
            goTo.ShowDialog(); // viser forms af kundeoplsyninger
            Close(); // lukker forsiden
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            Sorting SearchByLetter = new Sorting();

            dataGridView1.DataSource = 
                SearchByLetter.SerchByLetterInverval2(
                Convert.ToChar(FirstLetterBox.Text),
                Convert.ToChar(SecondLetterBox.Text));

        }

        private void udSKRIV_Click(object sender, EventArgs e)
        {

        }
    }
}
