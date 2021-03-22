using NolexIniSetting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestNolex
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            string file_ini = "..\\..\\..\\TestNolex.ini";
#else
            string file_ini = Application.ExecutablePath +  "\\" + "TestNolex.ini";
#endif            
            if (File.Exists(file_ini))
                IniSetting.Load(file_ini);

            SqlConnection myConnection = new SqlConnection(
                                            "user id=" + Predefiniti_Archivio.UserId + ";" +
                                            "password=" + Predefiniti_Archivio.Pwd + ";" +
                                            "server=" + Predefiniti_Archivio.ArchivioPath + ";" +
                                            "Trusted_Connection=yes;" +
                                            "database=" + Predefiniti_Archivio.CatalogName + ";" +
                                            "connection timeout=30");

            Application.Run(new Form1(myConnection));
        }
    }
}
