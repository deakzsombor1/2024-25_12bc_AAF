    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal class AudiS8 : Jarmu
    {
        public bool lezerblokkolo;

        public AudiS8(bool lezerblokkolo, int sebesseg, string rendszam) : base(sebesseg, rendszam)
        {
            this.lezerblokkolo = lezerblokkolo;
        }

        public override bool gyorshajtottE(int korlat)
        {
            if (lezerblokkolo == true)
            {
                return false;
            }
            else
            {
                if (sebesseg > korlat)
                {
                    return true;
                }
                return false;
            }
        }

        public override string ToString()
        {
            return "Audi: " + base.ToString();
        }
    }
}
