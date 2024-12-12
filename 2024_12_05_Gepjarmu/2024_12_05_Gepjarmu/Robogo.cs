using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal class Robogo : Jarmu, IKisGepjarmu
    {
        public int maxsebesseg;

        public Robogo(int maxsebbesseg,int sebesseg, string rendszam):base(sebesseg, rendszam)
        {
            this.maxsebesseg = maxsebbesseg;
        }

        public override bool gyorshajtottE(int korlat)
        {
            if (sebesseg > korlat)
            {
                return true;
            }
            return false;
        }

        public bool haladhatItt(int korlat)
        {
            if (sebesseg > korlat)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Robogo: " + base.ToString();
        }
    }
}
