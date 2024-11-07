using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog_osztaly
{
    class Haromszog
    {
        public double oldal1, oldal2, oldal3;

        public Haromszog(string sor)
        {
            string[] st = sor.Split(';');
            this.oldal1 = Convert.ToDouble(st[0]);
            this.oldal2 = Convert.ToDouble(st[1]);
            this.oldal3 = Convert.ToDouble(st[2]);
        }

        public bool SzerkeszthetoE()
        {
            return oldal1 + oldal2 > oldal3 && oldal1 + oldal3 > oldal2 && oldal2 + oldal3 > oldal1;
        }

        public bool EgyenloSzaruE()
        {
            return oldal1 == oldal2 || oldal2 == oldal3 || oldal3 == oldal1;
        }

        public bool SzabalyosE()
        {
            return oldal1 == oldal2 && oldal1 == oldal3 && oldal2 == oldal3;
        }

        public bool DerekszoguE()
        {
            return oldal1 * oldal1 + oldal2 * oldal2 == oldal3 * oldal3 || oldal1 * oldal1 + oldal3 * oldal3 == oldal2 * oldal2 || oldal2 * oldal2 + oldal3 * oldal3 == oldal1 * oldal1;
        }

        public double Kerulet()
        {
            return oldal1 + oldal2 + oldal3;
        }

        public double Terulet()
        {
            double s = Kerulet() / 2;
            return Math.Sqrt(s * (s-oldal1) * (s - oldal2) * (s - oldal3));
        }
    }
}
