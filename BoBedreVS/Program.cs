using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoBedreVS
{
    static class Program
    {
        // public static string strconn = "Server=den1.mssql8.gear.host; Database=bobedre1; User ID=bobedre1; Password=Js63Ot-_y8SE";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forside());
        }

      
       
    }
}
