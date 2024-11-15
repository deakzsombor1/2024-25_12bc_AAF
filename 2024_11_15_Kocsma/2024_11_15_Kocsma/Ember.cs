using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Kocsma
{
    internal class Ember
    {
        // Adattagok
        private string nev;
        private int kor, penz, reszegseg;
        private bool ferfi, kocsmaban;

        // konstruktorok
        public Ember(string nev, int kor, bool ferfi)
        {
            this.nev = nev;
            this.kor = kor;
            this.ferfi = ferfi;
            reszegseg = 0;
            kocsmaban = false;
        }

        public Ember(string nev, int kor, bool ferfi, int penz)
        {
            this.nev = nev;
            this.kor = kor;
            this.ferfi = ferfi;
            this.penz = penz;
            reszegseg = 0;
            kocsmaban = false;
        }

        // metódusok
        public void Iszik(Kocsmaros kocsmaros)
        {
            if (kocsmaban == true)
            {
                penz --;
                reszegseg++;
                Kocsmaros.koszospohar++;
                kocsmaros.penz++;
            }
            else
            {
                Console.WriteLine("Nincs a kocsmában");
            }
            if(reszegseg == 40)
            {
                Alszik();
            }
        }
        public void Iszik(Kocsmaros kocsmaros, Ital ital)
        {
            if (kocsmaban)
            {
                penz -= ital.ar;
                kocsmaros.penz += ital.ar;
                reszegseg += ital.alkoholtartalom;
            }
            if (reszegseg == 40)
            {
                Alszik();
            }
        }

        public void Alszik()
        {
            reszegseg = 0;
            Console.WriteLine($"{nev} elaludt!");
        }

        public void Hazamegy()
        {
            kocsmaban = false;
            Console.WriteLine($"{nev} hazament.");
        }

        public void Jon()
        {
            kocsmaban = true;
            Console.WriteLine($"{nev} megérkezett.");
        }

        // getterek és szetterek
    }
}
