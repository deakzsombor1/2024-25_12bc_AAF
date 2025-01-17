using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_16_LinqMukorcsolya
{
    internal class Korcsolya
    {
        public string nev, orszag;
        public double technikai, komponens;
        public int levonas;
        public double osszpont { get { return technikai + komponens - levonas; } }

        public Korcsolya(string sor)
        {
            string[] st = sor.Replace('.',',').Split(';');
            nev = st[0];
            orszag = st[1];
            technikai = Convert.ToDouble(st[2]);
            komponens = Convert.ToDouble(st[3]);
            levonas = Convert.ToInt32(st[4]);
        }
    }
}
