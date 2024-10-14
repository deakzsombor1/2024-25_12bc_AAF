using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_09_25_Struktura_valasztas
{
    internal class Program
    {

        static List<Kepviselo> kepviselok = new List<Kepviselo>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            //Kiiratas();
            Feladat2();
            Feladat3();

            Console.ReadLine();
        }

        static void Feladat3()
        {
            Console.Write("Adja meg a képviselő vezetéknevét: ");
            string veznev = Console.ReadLine();

            Console.Write("Adja meg a képviselő keresztnevét: ");
            string kernev = Console.ReadLine();

            int i = 0;

            while (i < kepviselok.Count && kepviselok[i].vnev != veznev && kepviselok[i].knev != kernev)
                i++;
            {
                if (i < kepviselok.Count)
                {
                    Console.WriteLine(veznev + " " + kernev + " " + kepviselok[i].szavazat);
                }
                else
                {
                    Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban!");
                }
            }
        }

        static void Feladat2()
        {
            int indult = 0;
            for (int i = 0; i < kepviselok.Count; i++)
            {
                indult++;
            }
            Console.WriteLine("A helyhatósági választáson " + indult + " képviselőjelölt indult.");
        }

        static void Kiiratas()
        {
            for (int i = 0; i < kepviselok.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", kepviselok[i].kerulet, kepviselok[i].szavazat, kepviselok[i].vnev, kepviselok[i].knev, kepviselok[i].part);
            }
        }

        static void Fajlbeolvasas()
        {
            //string[] sorok = File.ReadAllLines("szavazatok.txt");
            // Van ilyen is, de ez az osszes sort kigyujt egy tombe

            StreamReader f = new StreamReader("szavazatok.txt");
            //f.ReadLine(); Egy sort olvas ki
            while (!f.EndOfStream) 
            {
                string[] st = f.ReadLine().Split(' ');
                Kepviselo sv = new Kepviselo(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), st[2], st[3], st[4]);
                kepviselok.Add(sv);
            }

            f.Close();
        }
    }

    struct Kepviselo 
    {
        public int kerulet, szavazat;
        public string vnev, knev, part;

        public Kepviselo(int ujkerulet, int ujszavazat, string ujvnev, string ujknev, string ujpart)
        {
            this.kerulet = ujkerulet;
            this.szavazat = ujszavazat;
            this.vnev = ujvnev;
            this.knev = ujknev;
            this.part = ujpart;
        }
    }
}
