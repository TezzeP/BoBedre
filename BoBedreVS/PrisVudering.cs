using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Models;
using PersistensLag;
using BusinessLogic;

namespace BoBedreVS
{
    public partial class PrisVudering : Form
    {

        public PrisVudering()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PostNrBox.MaskCompleted) {
                try
                {
                    ReadAndShow readAndShowBolig = new ReadAndShow();

                    dataGridView1.DataSource = readAndShowBolig.ReadAndShowBoligSpecific("PostNr", Convert.ToInt32(PostNrBox.Text));

                    refresh();

                    if (dataGridView1[0, 0].Value == null)
                    {
                        MessageBox.Show("Kunne ikke finde en bolig med det givne postnummer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Indtast 4-cifret postnummer");
            }

        }

        private void refresh()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void UdregnButton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(StandardPrisBox.Text) && Double.TryParse(StandardPrisBox.Text, out double pris))
            {
                Int32.TryParse(StandBox.Text, out int stand);
                Double.TryParse(GrundBox.Text, out double grund);
                Double.TryParse(HusBox.Text, out double hus);
                int postNr = PostBox.MaskCompleted ? Convert.ToInt32(PostBox.Text) : 0;
                string ejendomstype = EjendomstypeBox.Text.ToLower();
                Int32.TryParse(EtagerBox.Text, out int etager);
                Int32.TryParse(KøkkenalderBox.Text, out int køkkenalder);
                Int32.TryParse(BadeværelseBox.Text, out int badeværelsesalder);
                Boolean have = HaveCheckBox.Checked ? true : false;

                PrisVurderer pv = new PrisVurderer();
                double resultat = pv.Calculate(pris, stand, grund, hus, postNr, ejendomstype, etager, køkkenalder, badeværelsesalder, have);

                UdbudsprisBox.Text = resultat.ToString();
            }

            else
            {
                MessageBox.Show("Angiv et tal som standardpris");
            }
        }


        private void CRUD_Click(object sender, EventArgs e)
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

        private void PrisVUUdering_Click(object sender, EventArgs e)
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
