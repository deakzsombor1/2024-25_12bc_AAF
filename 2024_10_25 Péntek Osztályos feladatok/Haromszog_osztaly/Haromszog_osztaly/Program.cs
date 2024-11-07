using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Haromszog_osztaly
{
    internal class Program
    {
        
        static List<Haromszog> haromszogek = new List<Haromszog>();

        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat1();
            Feladat2();

            Console.ReadLine();
        }

        static void Feladat2()
        {
            int index = MaxTeruletHaromszogIndexe();
            Haromszog sv = haromszogek[index];
            Console.WriteLine("Max teruletu haromszog oldalai: a={0} b={1} c={2}",sv.oldal1, sv.oldal2, sv.oldal3);
        }

        static int MaxTeruletHaromszogIndexe()
        {
            int maxi = 0;
            for (int i = 0; i < haromszogek.Count; i++)
            {
                if (haromszogek[i].SzerkeszthetoE() && haromszogek[i].Terulet() > haromszogek[maxi].Terulet())
                {
                    maxi = i;
                }
            }
            return maxi;
        }

        static void Feladat1()
        {
            int db = SzerkeszthetoHaromszogekDB();
            Console.WriteLine($"{db} db szerkeszthető háromszögvan.");
        }

        static int SzerkeszthetoHaromszogekDB()
        {
            int db = 0;
            for (int i = 0; i < haromszogek.Count; i++)
                if (haromszogek[i].SzerkeszthetoE())
                    db++;
            return db;
        }


        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("haromszogek.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                haromszogek.Add(new Haromszog(f.ReadLine()));
            }
            f.Close();
        }
    }
}
