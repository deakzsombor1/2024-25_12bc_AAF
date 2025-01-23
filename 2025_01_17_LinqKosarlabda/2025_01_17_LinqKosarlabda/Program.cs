using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;

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
            Feladat5();
            Feladat6();
            Feladat7();

            Console.ReadLine();
        }

        /*
        private static void Feladat7()
        {
            Console.WriteLine("7. feladat:");
            var tobbhusznal = eredmenyek.GroupBy(x => x.helyszin).Where(obj => obj.Count() > 20);
            foreach (var item in tobbhusznal)
            {
                Console.WriteLine("\t" + item.Key + ": " + item.Count());
            }
        }
        */

        private static void Feladat7()
        {
            Console.WriteLine("7. feladat:");
            var tobbhusznal = eredmenyek.GroupBy(x => x.helyszin).Where(obj => obj.Count() > 20)
            
                .Select(obj => new
                {
                    helyszin = obj.Key,
                    ossz = obj.Count()

                });
            foreach (var item in tobbhusznal)
            {
                Console.WriteLine("\t" + item.helyszin + ": " + item.ossz);
            }
        }

        private static void Feladat6()
        {
            Console.WriteLine("6. feladat:");
            var meccsek = eredmenyek.Where(x => x.idopont == "2004-11-21");
            foreach (var item in meccsek)
            {
                Console.WriteLine(" \t" + item.hazai + " - " + item.idegen + " (" + item.hazai_pont + ":" + item.idegen_pont + ")");
            }
        }

        private static void Feladat5()
        {
            Console.Write("5. feladat: barcelonai csapat neve: ");
            var barcelona = eredmenyek.Find(x => x.hazai.Contains("Barcelona"));
            Console.WriteLine(barcelona.hazai);
        }

        private static void Feladat4()
        {
            Console.Write("4. feladat: Volt döntetlen? ");
            var dontetlen = eredmenyek.Find(x => x.hazai_pont == x.idegen_pont);
            if(dontetlen == null)
            {
                Console.WriteLine("nem");
            }
            else
            {
                Console.WriteLine("volt");
            }
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
                Console.WriteLine(eredmenyek[i].idopont);
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
