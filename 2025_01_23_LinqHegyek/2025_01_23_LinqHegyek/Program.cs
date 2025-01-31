using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025_01_23_LinqHegyek
{
    internal class Program
    {
        static List<Hegyek> hegyek = new List<Hegyek>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Console.ReadLine();
        }

        private static void Feladat8()
        {
            Console.WriteLine("8. feladat: Hegység statisztika");
            var statisztika = hegyek.GroupBy(x => x.hegyseg);
            foreach (var item in statisztika)
            {

            }
        }

        private static void Feladat7()
        {
            Console.WriteLine($"7. feladat: 3000 lábnál magasabb hegycsúcsok száma: {hegyek.Where(c => c.magassag * 3.280839895 > 3000).Count()}");
        }

        private static void Feladat6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool vane = hegyek.Any(x => x.hegyseg == "Börzsöny" && x.magassag > n);
        }

        private static void Feladat5()
        {
            Console.WriteLine("5. feladat: A legmagasabb hegycsúcs adatai:");
            var legmagasabb = hegyek.Find(c=>c.magassag == hegyek.Max(x => x.magassag));
            //var legmagasabb = hegyek.OrderByDescending(x => x.magassag).First();
            Console.WriteLine("\tNév: {0} \n\tHegység: {1} \n\tMagasság: {2}", legmagasabb.hegycsucs_neve, legmagasabb.hegyseg, legmagasabb.magassag);
        }

        private static void Feladat4()
        {
            Console.Write("4. feladat: ");
            var atlag = hegyek.Average(x => x.magassag); 
            Console.WriteLine("Hegycsúcsok átlagos magassága: " + atlag + " m");

        }

        private static void Feladat3()
        {
            Console.Write("3. feladat: ");
            var hegys = hegyek.Count();
            Console.WriteLine("Hegycsúcsok száma: " + hegys+ " db");
        }

        static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("hegyekMO.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Hegyek sv = new Hegyek(sr.ReadLine());
                hegyek.Add(sv);
            }
            sr.Close();
        }
    }
}
