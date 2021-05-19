using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Models;
using PersistensLag;

namespace BoBedreVS
{
    public partial class MedarbejderInfo : Form
    {
        public MedarbejderInfo()
        {
            InitializeComponent();

            Thread backgroundThread = new Thread(() =>
            {
                while (true)
                {
                    ReadAndShow readAndShow = new ReadAndShow();
                    var alleMedarbejder = readAndShow.ReadAndShowMedarbejder();

                    foreach (var medarbejder in alleMedarbejder)
                    {

                        this.Invoke(new MethodInvoker(delegate()
                        {
                           
                            NameLabel.Text = Convert.ToString(medarbejder.Navn);
                            StillingLable.Text = Convert.ToString(medarbejder.Stilling);
                        }));

                        Thread.Sleep(60000);
                    }
                }

            });

            backgroundThread.Start();

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

        private void PrisVudering_Click(object sender, EventArgs e)
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
