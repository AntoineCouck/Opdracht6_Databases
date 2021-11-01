using System;

namespace Oef1
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());



            AandelenBeheerData.Rss rssdata = new AandelenBeheerData.Rss();



            rssdata.Bewaar("Titel", "Ik", "Geen", "http://", DateTime.Now);
            Console.WriteLine("het is gelukt");




        }
    }
}
