﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_14_Static_felhasznalasa
{
    internal class DatumIdo
    {
        /// <summary>
        /// Dátum értékéből kiszedi az év értékét.
        /// </summary>
        /// <param name="datum">
        ///     Formátuma: év*hónap*nap
        ///     * egykarakterből álló elválasztó
        ///     pl. 2024_11_14  2024-11-14  2024.11.14  2024 11 14
        /// </param>
        /// <returns> az év kialakítása egész értékre (konvertálása) </returns>
        public static int Ev(string datum)
        {
            char sc = datum[4];
            string[] st = datum.Split(sc);
            return Convert.ToInt32(st[0]);
        }

        /// <summary>
        /// Dátum értékéből kiszedi az év értékét.
        /// </summary>
        /// <param name="datum">
        ///     Formátuma: év*hónap*nap
        ///     * egykarakterből álló elválasztó
        ///     pl. 2024_11_14  2024-november-14  2024.3.14 2024 március 14
        /// </param>
        /// <returns>A hónap értékének megadása.</returns>
        public static string Honap(string datum)
        {
            char sc = datum[4];
            string[] st = datum.Split(sc);
            return st[1];
        }

        public static bool OszthatoE(int datum)
        {
            if (datum % 4 == 0 && (datum % 100 != 0 || datum % 400 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
