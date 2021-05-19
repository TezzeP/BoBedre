﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersistensLag;
using BusinessLogic;
using Models;

namespace BoBedreVS
{
    public partial class Statistik : Form
    {
        public Statistik()
        {
            InitializeComponent();
        }

       private void CRUD_Click(object sender, EventArgs e)
       {
            Hide();
            CRUD goTo = new CRUD();
            goTo.ShowDialog();
            Close();

       }

        private void button1_Click(object sender, EventArgs e)
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

        }

        private void StatSøgButton_Click(object sender, EventArgs e)
        {
            string filepath = StatFileBox.Text;
            if (!String.IsNullOrEmpty(filepath)) {
                try
                {
                    Read reader = Read.Instance();
                    StringBuilder sb = new StringBuilder("SELECT * FROM dbo.Bolig WHERE SalgsDato IS NOT NULL ");
                    if (!String.IsNullOrEmpty(StatVejnavnBox.Text))
                    {
                        sb.Append($"AND Adresse LIKE '{StatVejnavnBox.Text}%' ");
                    }
                    if (StatStartDatoBox.MaskCompleted)
                    {
                        StringBuilder startString = new StringBuilder();
                        string start = StatStartDatoBox.Text;

                        startString.Append(start.Substring(6));
                        startString.Append(start.Substring(3, 2));
                        startString.Append(start.Substring(0, 2));

                        sb.Append($"AND SalgsDato >= '{startString}' ");
                    }
                    if (StatSlutDatoBox.MaskCompleted)
                    {
                        StringBuilder slutString = new StringBuilder();
                        string slut = StatSlutDatoBox.Text;

                        slutString.Append(slut.Substring(6));
                        slutString.Append(slut.Substring(3, 2));
                        slutString.Append(slut.Substring(0, 2));
                        sb.Append($"AND SalgsDato <= '{slutString}' ");
                    }

                    //MessageBox.Show(sb.ToString());
                    List<Bolig> boligListe = reader.ReadAllBoligWithWithQuery(sb.ToString());
                    FilSkriver fileWriter = new FilSkriver();
                    fileWriter.WriteBoligToFile(boligListe, filepath, StatVejnavnBox.Text);

                    MessageBox.Show("Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vælg Fil");
            }
        }

        private void StatVejnavnBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string s = folderBrowserDialog1.SelectedPath;
            StatFileBox.Text = s;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
