using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_17_LinqKosarlabda
{
    internal class Eredmenyek
    {
        public string hazai, idegen, helyszin, idopont;
        public int hazai_pont, idegen_pont;

        public Eredmenyek(string sor)
        {
            string[] st = sor.Split(';');
            hazai = st[0];
            idegen = st[1];
            hazai_pont = Convert.ToInt32(st[2]);
            idegen_pont = Convert.ToInt32(st[3]);
            helyszin = st[4];
            idopont = st[5];
        }
    }
}
