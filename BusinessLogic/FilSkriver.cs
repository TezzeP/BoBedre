﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.IO;

namespace BusinessLogic
{
    public class FilSkriver
    {

        public void WriteBoligToFile(List<Bolig> boligList, string filePath)
        {
            StreamWriter sw;
            if (filePath.Contains("Salgsoversigt.txt"))
            {
                sw = new StreamWriter(filePath);
            }
            else
            {
                sw = new StreamWriter($"{filePath}\\Salgsoversigt.txt");
            }


            sw.WriteLine();
            sw.WriteLine($"Boliger solgt med givne parametre: {boligList.Count}");
            sw.WriteLine();

            foreach (Bolig b in boligList)
            {
                sw.WriteLine($" ---- Bolig {b.BoligID} ---- ");
                sw.WriteLine($"  Salgsdato: {b.SalgsDato}");
                sw.WriteLine($"  Salgspris: {b.Pris}");
                sw.WriteLine($"  Mægler: {b.MedarbejderID}");
                sw.WriteLine(" ------------------ ");
                sw.WriteLine();
                sw.WriteLine();
            }

            sw.Close();
        }
    }
}
