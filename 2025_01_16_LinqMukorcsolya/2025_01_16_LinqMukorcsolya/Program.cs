using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Data;

namespace _2025_01_16_LinqMukorcsolya
{
    internal class Program
    {
        static List<Korcsolya> donto = new List<Korcsolya>();
        static List<Korcsolya> rovidprogram = new List<Korcsolya>();


        static void Main(string[] args)
        {
            donto = Fajlbeolvasas("donto.csv");
            rovidprogram = Fajlbeolvasas("rovidprogram.csv");
            Feladat2();
            Feladat3();
            Feladat5_6();
            Feladat7();
            // Írassa ki a legjobb versenyzőket országonként (ahol 1-nél több versenyző volt)
            Feladat7_1();
            Feladat8();

            Console.ReadLine();
        }

        private static void Feladat8()
        {
            StreamWriter sw = new StreamWriter("vegeredmeny.csv");
            var csoportositas = rovidprogram.Select(x => new
            {
                nev = x.nev,
                orszag = x.orszag,
                osspont = OsszpontSzam(x.nev)
            })
                .OrderByDescending(x => x.osspont);
            int i = 1;
            foreach(var item in csoportositas)
            {
                Console.WriteLine($"{i};{item.nev};{item.orszag};{item.osspont}");
                i++;
            }
            sw.Close();
        }

        private static void Feladat7_1()
        {
            var csoportositas = donto.GroupBy(versenyzo => versenyzo.orszag)
                .Where(obj => obj.Count() > 1)
                .Select(obj => new
                {
                    orszagkod = obj.Key,
                    legjobb = obj.ToList().Find(c => c.osszpont == obj.Max(x => x.osszpont))
                }
                );
            foreach (var item in csoportositas)
            {
                Console.WriteLine($"{item.orszagkod} {item.legjobb}");
            }
        }

        private static void Feladat7()
        {
            Console.WriteLine("7. Feladat.");
            var csoportositas = donto.GroupBy(versenyzo => versenyzo.orszag)
                .Select(obj => new
                {
                    orszagkod = obj.Key,
                    darab = obj.Count()
                }).
                Where(x => x.darab >1);
            foreach(var item in csoportositas)
            {
                Console.WriteLine($"{item.orszagkod} {item.darab}");
            }
        }

        private static void Feladat5_6()
        {
            Console.WriteLine("5. Feladat.");
            Console.Write($"\tKérem a versenyző nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("6. Feladat.");
            Console.Write($"A versenyző összpontszáma: {OsszpontSzam(nev)}");
            Console.WriteLine();
        }

        private static double OsszpontSzam(string nev)
        {
            var versenyzoR = rovidprogram.Find(x => x.nev == nev);
            if (versenyzoR == null) return -1;
            var versenyzoD = donto.Find(x => x.nev == nev);
            if(versenyzoD == null) return versenyzoR.osszpont;
            return versenyzoR.osszpont + versenyzoD.osszpont;
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. Feladat.");
            bool vanEMagyar = donto.Any(x => x.orszag == "HUN");
            if (vanEMagyar)
            {
                Console.WriteLine("A magyar versenyző bejutott a kűrbe.");
            }
            else
            {
                Console.WriteLine("A magyar versenyző nem jutott be a kűrbe.");
            }
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat.");
            Console.WriteLine($"\tA rövid programban {rovidprogram.Count} induló volt."); 
        }

        private static List<Korcsolya> Fajlbeolvasas(string fajl)
        {
           List<Korcsolya> versenyzo = new List<Korcsolya>();
           StreamReader sr = new StreamReader(fajl);
           sr.ReadLine();
           while (!sr.EndOfStream)
           {
                Korcsolya sv = new Korcsolya(sr.ReadLine());
                versenyzo.Add(sv);
           }
           sr.Close();
           return versenyzo;
        }
    }
}
