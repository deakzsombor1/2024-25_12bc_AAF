using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_10_LinqValasztas
{
    internal class Program
    {
        static List<Kepviselo> kepviselok = new List<Kepviselo>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            //Kiiratas();

            OsszIndulo();
            KepviseloSzavazata();
            HanySzavazat();

            Console.ReadLine();
        }

        private static void HanySzavazat()
        {
            int sum = kepviselok.Sum(x => x.Szavazat);
            double szazalek =(double)sum/12345 * 100;
            Console.WriteLine($"A választáson {sum} állampolgár, a jogosultak {Math.Round(szazalek, 2)}%-a vett részt.");
        }

        private static void KepviseloSzavazata()
        {
            Console.Write("Adja meg a képviselő nevét: ");
            string[] nev = Console.ReadLine().Split(' ');
            Kepviselo k = kepviselok.Find(c => c.Vezeteknev == nev[0] && c.Keresztnev == nev[1]);
            if(k == null)
            {
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel \r\na nyilvántartásban!");
            }
            else
            {
                Console.WriteLine($"\t{nev[0]} {nev[1]} képviselő {k.Szavazat} szavazatot kapott.");




            }
        }

        private static void OsszIndulo()
        {
            int ossz = 0;
            for (int i = 0; i < kepviselok.Count; i++)
            {
                ossz++;
            }
            Console.WriteLine("A helyhatósági választáson {0} képviselőjelölt indult.", ossz);
        }

        private static void Kiiratas()
        {
            for (int i = 0; i < kepviselok.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", kepviselok[i].Sorszam, kepviselok[i].Szavazat, kepviselok[i].Vezeteknev, kepviselok[i].Keresztnev, kepviselok[i].Part);
            }
        }

        private static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("szavazatok.txt");

            while (!sr.EndOfStream)
            {
                Kepviselo sv = new Kepviselo(sr.ReadLine());
                kepviselok.Add(sv);
            }

            sr.Close();
        }
    }
}
