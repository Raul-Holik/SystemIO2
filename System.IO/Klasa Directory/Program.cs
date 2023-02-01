using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir;
            string test="\\TEST";
            Console.WriteLine("Unesite putanju direktorija");
            dir=Console.ReadLine();

            if(Directory.Exists(dir))
            {
                Console.WriteLine("Sve datoteke u direktroiju: ");

                foreach(string datoteka in Directory.GetFiles(dir))
                {
                    Console.WriteLine(datoteka);
                }
            }
            string novaPut = dir + test;

            if (!Directory.Exists(novaPut))
            {
                Console.WriteLine("Direktoriji je kreiran.");
                Directory.CreateDirectory(novaPut);
            }
            else
            {
                
                Console.WriteLine("Direktoriji postoji. ");
            }

            foreach(string poddirektoriji in Directory.GetDirectories(dir))
            {
                Console.WriteLine(poddirektoriji);
            }

            Directory.Delete(test);

            Console.WriteLine("Nakon brisanja direktroija TEST.");
            foreach (string poddirektoriji in Directory.GetDirectories(dir))
            {
                Console.WriteLine(poddirektoriji);
            }

            Console.ReadKey();
        }

    }
}
