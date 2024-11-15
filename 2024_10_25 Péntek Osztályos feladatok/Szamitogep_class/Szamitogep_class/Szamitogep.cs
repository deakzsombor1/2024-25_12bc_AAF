using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamitogep_class
{
    internal class Szamitogep
    {
        public double mb;
        public bool kapcsolva_e;


        // Konstruktorok
        public Szamitogep(double memo, bool bekapcsolva)
        {
            mb = memo;
            kapcsolva_e = bekapcsolva;
        }

        public Szamitogep() 
        {
            mb = 1024;
            kapcsolva_e = false;
        }

        // Metódusok
        public void Kapcsol()
        {
            kapcsolva_e = !kapcsolva_e;
        }

        public bool ProgramMasol(double program)
        {
            if (kapcsolva_e && mb - program >= 0)
            {
                mb -= program;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0} Szabad memória: {1}", kapcsolva_e? "Be van kapcsolva" : "Ki van bekapcsolva",mb);
        }
    }
}
