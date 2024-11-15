using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Szamitogep_class
{
    internal class Program
    {

        static List<Szamitogep> szamitogepek = new List<Szamitogep>();
        static void Main(string[] args)
        {
            Feladat0();
            Fajlbeolvasas();
            
            Feladat1();
            

            Console.ReadLine();
        }

        static void Feladat1()
        {
            int osszes = BekapcsoltE();
            Console.WriteLine("{0} db számítógép van bekapcsolva", osszes);
        }

        static int BekapcsoltE()
        {
            int osszes = 0;
            for (int i = 0; szamitogepek.Count > 0; i++)
            {
                if (szamitogepek[i].kapcsolva_e == true)
                {
                    osszes++;
                }
                else
                {
                    i++;
                }
            }
            return osszes;
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("Szamitogep.txt");
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split('\t');
                szamitogepek.Add(new Szamitogep(Convert.ToInt32(st[0]), st[1] == "x" ));
            }
            f.Close();
        }


        static void Feladat0()
        {
            Szamitogep sz1 = new Szamitogep();
            Szamitogep sz2 = new Szamitogep(2048, false);

            Console.WriteLine(sz1.ToString());
            Console.WriteLine(sz2.ToString());
            
            sz1.Kapcsol();
            ProgramMasolasa(sz1, 800);


        }

        static void ProgramMasolasa(Szamitogep sz, double hely)
        {

            if (sz.ProgramMasol(hely))
            {
                Console.WriteLine("Sikeres a másolás");
            }
            else
            {
                Console.WriteLine("Nem sikerült a másolás");
            }
            Console.WriteLine(sz.ToString());
        }
    }
}
