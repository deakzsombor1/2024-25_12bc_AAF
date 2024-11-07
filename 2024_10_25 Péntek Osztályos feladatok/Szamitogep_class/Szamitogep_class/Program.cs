using System;
using System.Collections.Generic;
using System.IO;
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
            Beolvasas();

            Console.ReadLine();
        }

        static void Beolvasas()
        {
            StreamReader f = new StreamReader("Szamitogep.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                szamitogepek.Add(new Szamitogep(f.ReadLine()));
            }
            f.Close();
        }
    }
}
