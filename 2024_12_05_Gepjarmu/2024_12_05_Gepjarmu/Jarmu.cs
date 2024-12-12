using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal abstract class Jarmu
    {
        protected int sebesseg;
        private string rendszam;

        protected Jarmu(int sebesseg, string rendszam)
        {
            this.sebesseg = sebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool gyorshajtottE(int sebessegKorlat);

        public override string ToString()
        {
            return $"{rendszam} - {sebesseg} km/h";
        }
    }
}
