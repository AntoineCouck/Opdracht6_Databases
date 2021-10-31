using System;

namespace Oef1
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());



            AandelenBeheerData.Rss rssdata = new AandelenBeheerData.Rss();

          

            rssdata.Bewaar("Titel", "Ik", "Geen", "http://", DateTime.Now);

            


        }
    }
}
