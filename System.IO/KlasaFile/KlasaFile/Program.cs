using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KlasaFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime;
            Console.WriteLine("Upišite ime. ");
            ime= Console.ReadLine();

            string datoteka = "ime.txt";

            if (File.Exists(datoteka))
            {
                if (!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }


                File.Copy(datoteka, "backup\\ime_" + DateTime.Now.ToString("yyyy_MMM_ddd_H_m_ss") + ".txt");
                File.Delete(datoteka);
            }

            File.WriteAllText(datoteka, ime);

            Console.ReadKey();
        }
    }
}
