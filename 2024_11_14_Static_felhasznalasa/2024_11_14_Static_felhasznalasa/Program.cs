﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_14_Static_felhasznalasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static - példányosítása nélkül felhasználható adattagok és metódusok.
            // Példányosítás: Random rnd = new Random();
            // Példányosítás nélkül: Math.Sqrt(2);

            /* Szalagavato 12a = new Szalagavato(12, "a");
             * - tánc, jegyek eladása, osztályfőnök ...
             * Static - bevétel, igazgató */

            string datum = "2024_11_14";
            Console.WriteLine(datum);
            Console.WriteLine($"Év: {DatumIdo.Ev(datum)}");

            int ev = 2000;
            Console.WriteLine($"Szökőév-e a {ev}: {DatumIdo.OszthatoE(ev)}");

            Console.ReadLine();
        }

       
    }
}
