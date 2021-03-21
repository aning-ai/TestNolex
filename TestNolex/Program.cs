using System;
using System.Collections.Generic;
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

            //todo: caricamento file .ini con valorizzazione valori classi statiche)
            //[StampaServer]
            //StampaServerEnabled = 1
            //UpdateInterval = 3

            //[Archivio]
            //#Percorso SQL
            //ArchivioPath = "CLEARCANVAS64PC\IMAGESERVER2"
            //CatalogName = "FastprintProDoca"
            //#MaxStorageDays = 1000
            //MaxStorageDaysCheckInterval = 10

            //[Dicom]
            //#DCMColPrintProcessServerAdditionalOptions = "-v -d +d"
            //DCMColPrintProcessServerAdditionalOptions = ""
            //#DCMBNPrintProcessServerAdditionalOptions = "-v -d"
            //DCMBNPrintProcessServerAdditionalOptions = ""

            Application.Run(new Form1());
        }
    }
}
