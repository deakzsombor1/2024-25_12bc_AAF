using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_19_Struktura
{
    internal class Program
    {
        List<string> nevek = new List<string>()
        {
            "Farkas Máté",
            "Deák Zsombor",
            "Kakuk Ákos",
            "Kis Levente",
            "Varga Csaba",
            "Pálinkás Zoltán",
            "Détári Viktória",
            "Gebhardt Lilla",
            "Sebella Máté",
            "Zsidákovits Bálint",
            "Szabó Dániel"
        };



        static void Main(string[] args)
        {
            /* Hozzon létre egy struktúrát, amiben eltárolja a csoport neveit és mindenkinek generál egy 18 számjegyből álló kódot!
             * Ezeket a példányosítás során, adja is át!
             * A struktúrában legyenek a további mezők is: 
             * Magasság, szemüveges, azonosító, jelszó.
             * A példányosítás során fusson le egy véletlen generálás, ami megadja a magasság [160, 190] között. Illetve véletlen szerűen állítsa be, hogy szemüveges-e az illető.
             * Majd ugyan itt a példány elkészülés során, fusson le a struktúrában elkészített két függvény, az egyik eredménye az azonosító a másik jelszó!
             * Azonosító: minden páratlanadik karakter kis betűvel, szóköz nélkül! és a kód számjegyeinek összeg!
             * Jelszó: A kód kettesével vett értékének asci kódjából előállított betű! Ha 32-nél kisebb az érték, adjon hozzá 50-et!
             */

            // Csináljon ToString metódust!
           
            Console.ReadLine();
        }
    }

    struct infocsop
    {
        public string nev, kod, id, jelszo;
        public int magassag;
        public bool szemuveges;

        public infocsop(string ujnev, string ujkod)
        {
            Random r = new Random();
            this.nev = ujnev;
            magassag = r.Next(150, 191);
            //if(r.Next(2)  == 0) 
            //szemuveges = true;
            //else
            //szemuveges = false;
            szemuveges = r.Next(2) == 0;
            this.kod = ujkod;
            id = IdGeneralas(nev);
            jelszo = JelszoGeneralas();
        }
        
        private string IdGeneralas(string szoveg)
        {
            // Kis Pista -> KisPista -> Ksit -> ksit
            //123456789123456789 - > 90
            // ksit90
            string szokoznelkuli = Szokoztelenites(szoveg);
            string paratlanadikBetu = Rovidites(szokoznelkuli);
            int szamjegyOsszege = SzamjegyekOsszeadasa(kod);
            return paratlanadikBetu + szokoznelkuli;
        }

        private int SzamjegyekOsszeadasa(string sz)
        {
            int osszeg = 0;
            for (int i = 0; i < sz.Length; i++)
            {
                //osszeg += sz[i]-48;
                osszeg += Convert.ToInt32("" + sz[i]);
            }
            return osszeg;
        }

        private string Rovidites(string sz)
        {
            string szoveg2 = "";
            for (int i = 0; i < sz.Length; i+= 2)
            {
                szoveg2 = sz[i] + szoveg2;
            }
            return szoveg2;
        }

        private string Szokoztelenites(string sz)
        {
            string szoveg1 = "";
            for (int i = 0; i < sz.Length; i++)
            {
                if (sz[i] != ' ')
                {
                    szoveg1 = szoveg1 + sz[i];
                }
            }
            return sz;
        }


        private string JelszoGeneralas()
        {
            // 12 34 56 78 91 23 45 67 89 -> 72H 34. 56? 78L stb.
            // H.?lDob9-i

            string jelszo = "";
            for (int i = 0; i < kod.Length; i+=2)
            {
                int a = Convert.ToInt32("" + kod[i] + kod[i+1]);
                //jelszo += Convert.ToChar(a);
                jelszo += (char)a;
            }

            return jelszo;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {3} {4} {5}", nev, kod, magassag, szemuveges, id, jelszo);
        }
    }
}
