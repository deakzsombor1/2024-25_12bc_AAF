using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_23_LinqHegyek
{
    internal class Hegyek
    {
        public string hegycsucs_neve, hegyseg;
        public int magassag;

        public Hegyek(string sor)
        {
            string[] st = sor.Split(';');
            hegycsucs_neve = st[0];
            hegyseg = st[1];
            magassag = Convert.ToInt32(st[2]);
        }
    }
}
