using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025_01_17_LinqKosarlabda
{
    internal class Program
    {
        static List<Eredmenyek> eredmenyek = new List<Eredmenyek>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            //FajlKiiratas();
            Feladat3();
            Feladat4();

            Console.ReadLine();
        }

        private static void Feladat4()
        {
            var dontetlen = eredmenyek.Where();
        }

        private static void Feladat3()
        {
            var hazai = eredmenyek.Where(x => x.hazai == "Real Madrid").Count();
            var idegen = eredmenyek.Where(x => x.idegen == "Real Madrid").Count();
            Console.WriteLine($"3. feladat: Real Madrid: Hazai: {hazai}, Idegen: {idegen}");
        }

        /*
        static void FajlKiiratas()
        {
            for (int i = 0; i < eredmenyek.Count; i++)
            {
                Console.WriteLine(eredmenyek[i].hazai);
            }
        }
        */

        static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("eredmenyek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Eredmenyek sv = new Eredmenyek(sr.ReadLine());
                eredmenyek.Add(sv);
            }
            sr.Close();
        }
    }
}
