﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Kocsma
{
    internal class Ital
    {
        private int ar, alkoholtartalom;

        public int Ar
        {
            get { return ar; }
            set { ar = value; }
        }

        public int Alkoholtartalom
        {
            get { return alkoholtartalom; }
            set { alkoholtartalom = value; }
        }

        public Ital(int ar, int alkoholtartalom)
        {
            this.ar = ar;
            this.alkoholtartalom = alkoholtartalom;
        }
    }
}
