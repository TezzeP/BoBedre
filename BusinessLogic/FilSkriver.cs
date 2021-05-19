using System;
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

        public void WriteBoligToFile(List<Bolig> boligList, string filePath, string vejNavn)
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
            sw.WriteLine($"Boliger solgt i {vejNavn} med givne parametre: {boligList.Count}");
            sw.WriteLine();

            foreach (Bolig b in boligList)
            {
                StringBuilder sb = new StringBuilder();
                string s = b.SalgsDato.ToString();

                sb.Append(s.Substring(6));
                sb.Append("/");
                sb.Append(s.Substring(4, 2));
                sb.Append("/");
                sb.Append(s.Substring(0, 4));

                sw.WriteLine($" ---- Bolig {b.BoligID} ---- ");
                sw.WriteLine($"  Adresse: {b.Adresse}");
                sw.WriteLine($"  Salgsdato: {sb}");
                sw.WriteLine($"  Salgspris: {b.Pris}");
                sw.WriteLine($"  MæglerID: {b.MedarbejderID}");
                sw.WriteLine(" ------------------ ");
                sw.WriteLine();
                sw.WriteLine();
            }

            sw.Close();
        }
    }
}
