using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();

            if (Directory.Exists(putanja))  //provjera ako direktorij postoji
            {
                //ako direktorij postoji, ispisujemo sve datoteke u njemu
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }
            else
            {
                Console.WriteLine("Direktorij ne postoji!");
            }

            string putanjaPoddirektorija = "\\Test";

            string novaPutanja = putanja + putanjaPoddirektorija;


            if (!Directory.Exists(putanja + putanjaPoddirektorija))
            {
                Directory.CreateDirectory(novaPutanja);
            }
            else
            {
                Console.WriteLine("Direktorij već postoji!");
            }

            Console.WriteLine("Poddirektoriji: ");
            foreach (string poddirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }

            Directory.Delete(novaPutanja);
            Console.WriteLine("Nakon brisanja: ");
            foreach (string datoteka in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(datoteka);
            }

            Console.ReadKey();
        }
    }
}
