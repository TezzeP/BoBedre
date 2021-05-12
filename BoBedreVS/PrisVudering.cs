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

namespace BoBedreVS
{
    public partial class PrisVudering : Form
    {
        double standStartFaktor = -0.75;
        double standFaktor = 0.15;
        double grundFaktor = 0.01;
        double husFaktor = 0.02;
        double etagerFaktorPositiv = 0.15;
        double etagerFaktorNul = -0.1;
        double køkkenalderStartFaktor = 0.5;
        double køkkenalderPerMånedFaktor = 0.015;
        double badeværelseStartFaktor = 0.4;
        double badeværelsePerMånedFaktor = 0.01;
        double haveFaktor = 0.1;

        Dictionary<int, double> postNrVaerdier = new Dictionary<int, double>()
        {
            {2000, 0.2 },
            {2605, -0.075 },
            {2990, -0.2 },
            {3000, 0.1 },
            {4000, -0.05 },
            {4900, 0.075 },
            {5000, 0.125 },
            {5500, 0.025 },
            {6000, 0.05 },
            {7000, 0.1 },
            {7100, 0.1 },
            {8000, -0.175 },
            {8200, 0.15 },
            {9000, 0.1 }
        };

        Dictionary<string, double> ejendomstypeVaerdier = new Dictionary<string, double>()
        {
            {"villa", 0.1 },
            {"hus", 0.05 },
            {"lejlighed", -0.1 },
            {"andet", 0.0 }
        };

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
            SqlConnection conn = new SqlConnection(PersistensLag.Globals.strconn);
            try
            {
                conn.Open();
                string sSQL = $"SELECT * FROM dbo.Bolig WHERE PostNr = '{PostNrBox.Text}'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1[0, i].Value = dt.Rows[i].Field<int>("BoligId");
                    dataGridView1[1, i].Value = dt.Rows[i].Field<string>("Adresse");
                    dataGridView1[2, i].Value = dt.Rows[i].Field<int>("PostNr");
                    dataGridView1[3, i].Value = dt.Rows[i].Field<double>("GrundM2");
                    dataGridView1[4, i].Value = dt.Rows[i].Field<double>("HusM2");
                    dataGridView1[5, i].Value = dt.Rows[i].Field<double>("Pris");
                    dataGridView1[6, i].Value = dt.Rows[i].Field<DateTime>("SalgsDato");
                    dataGridView1[7, i].Value = dt.Rows[i].Field<DateTime>("OprettelsesDato");
                    dataGridView1[8, i].Value = dt.Rows[i].Field<int>("StandSkala");
                    dataGridView1[9, i].Value = dt.Rows[i].Field<int>("KundeId");
                }

                refresh();

                if (dataGridView1[0, 0].Value == null)
                {
                    MessageBox.Show("Kunne ikke finde en bolig med det givne postnummer");
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void UdregnButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(StandardPrisBox.Text) && Double.TryParse(StandardPrisBox.Text, out double pris))
            {
                Double.TryParse(GrundBox.Text, out double grund);
                Double.TryParse(HusBox.Text, out double hus);
                double stand = -1;
                double totalFaktor = 1;
                Int32.TryParse(EtagerBox.Text, out int etager);

                if (!String.IsNullOrEmpty(StandBox.Text))
                {
                    stand = Convert.ToDouble(StandBox.Text);
                }
                if (stand <= 10 && stand > 0)
                {
                    totalFaktor += (standStartFaktor + (stand * standFaktor));
                }
                else
                {
                    MessageBox.Show("Stand skal være mellem 1 og 10");
                }


                if (grund > 0)
                {
                    totalFaktor += (grund * grundFaktor);
                }
                else if (grund < 0)
                {
                    MessageBox.Show("En grund kan ikke have et negativt grundareal");
                }


                if (hus > 0)
                {
                    totalFaktor += (hus * husFaktor);
                }
                else if (hus < 0)
                {
                    MessageBox.Show("Et hus kan ikke have et negativt grundareal");
                }


                if (!String.IsNullOrEmpty(PostBox.Text))
                {
                    if (postNrVaerdier.ContainsKey(Convert.ToInt32(PostBox.Text)))
                    {
                        totalFaktor += postNrVaerdier[Convert.ToInt32(PostBox.Text)];
                    }
                }


                if (!String.IsNullOrEmpty(EjendomstypeBox.Text))
                {
                    if (ejendomstypeVaerdier.ContainsKey(EjendomstypeBox.Text.ToLower()))
                    {
                        totalFaktor += ejendomstypeVaerdier[EjendomstypeBox.Text.ToLower()];
                    }
                }


                if (etager == 0 || String.IsNullOrEmpty(EtagerBox.Text))
                {
                    totalFaktor += etagerFaktorNul;
                }
                else
                {
                    totalFaktor += (etager * etagerFaktorPositiv);
                }


                if (!String.IsNullOrEmpty(KøkkenalderBox.Text))
                {
                    double køkkenAlder = Convert.ToInt32(KøkkenalderBox.Text);
                    totalFaktor += (køkkenalderStartFaktor - (køkkenalderPerMånedFaktor * køkkenAlder));
                }


                if (!String.IsNullOrEmpty(BadeværelseBox.Text))
                {
                    double badeværelsesAlder = Convert.ToInt32(BadeværelseBox.Text);
                    totalFaktor += (badeværelseStartFaktor - (badeværelsePerMånedFaktor * badeværelsesAlder));
                }


                if (HaveCheckBox.Checked)
                {
                    totalFaktor += haveFaktor;
                }


                pris *= totalFaktor;
                pris = Math.Round(pris, 2);
                UdbudsprisBox.Text = pris.ToString();
            }
            else
            {
                MessageBox.Show("Angiv et tal som standardpris");
            }
        }

        private void StandBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private void UdbudsprisBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void HaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PostBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_2(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
