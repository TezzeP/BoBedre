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
        double standFaktor = 0.15;
        double grundFaktor = 0.1;
        double husFaktor = 0.1;

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
                    dataGridView1[3, i].Value = dt.Rows[i].Field<int>("GrundM2");
                    dataGridView1[4, i].Value = dt.Rows[i].Field<int>("HusM2");
                    dataGridView1[5, i].Value = dt.Rows[i].Field<int>("Pris");
                    dataGridView1[6, i].Value = dt.Rows[i].Field<DateTime>("SalgsDato");
                    dataGridView1[7, i].Value = dt.Rows[i].Field<DateTime>("OprettelsesDato");
                    dataGridView1[8, i].Value = dt.Rows[i].Field<int>("StandSkala");
                    dataGridView1[9, i].Value = dt.Rows[i].Field<int>("KundeId");
                }

                refresh();

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
            double stand = Convert.ToDouble(StandBox.Text);
            if (stand <= 10)
            {
                double grund = Convert.ToDouble(GrundBox.Text);
                double hus = Convert.ToDouble(HusBox.Text);
                UdbudsprisBox.Text = ((10000 * stand * standFaktor) * (grund * grundFaktor) * (hus * husFaktor)).ToString();
            }
            else
            {
                MessageBox.Show("Stand skal være mellem 0 og 10");
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
    }
}
