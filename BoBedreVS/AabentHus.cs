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
    public partial class AabentHus : Form
    {
        public AabentHus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = Globals.strconn;

            string cmd = "select * from Bolig where SalgsDato IS NULL AND GrundM2 >= 145";
            
            var da = new SqlDataAdapter(cmd, Globals.strconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            List<DataTable> BoligTilSalg = new List<DataTable>();
            BoligTilSalg = BoligTilSalg.OrderBy(x => x.TableName).ToList();
            BoligTilSalg = BoligTilSalg.Where(x=>x.)

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
