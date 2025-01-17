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
        static void Main(string[] args)
        {
            Fajlbeolvasas();

            Console.ReadLine();
        }

        static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("eredmenyek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {

            }
            sr.Close();
        }
    }
}
