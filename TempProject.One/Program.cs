using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TempProject.One
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            generator.Initialize(8, 8);

            int y = -1;
            int z = 2;
            Console.ReadLine();
            //DosyaIndir(@"https://www.cdek.com.tr/tr", @"C:\Users\EOZER\Downloads\TempProject\TempProject\TempProject.One\bin\Debug", "index.html");

        }
        public static void DosyaIndir(string URL, string IndirilecekDizin, string DosyaAdi)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(URL), IndirilecekDizin + "/" + DosyaAdi);
            Console.Read();
        }
        private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("Dosya indiriliyor: %{0}", e.ProgressPercentage);
            Console.Read();
        }
        private static void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Dosya indirme tamamlandı.");
            Console.Read();
        }
        
    }
}
