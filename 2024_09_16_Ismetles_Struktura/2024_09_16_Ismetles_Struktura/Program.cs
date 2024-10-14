using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_16_Ismetles_Struktura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya(); // struktura egy peldanya
            k1.kor = 12;
            k1.fajta = "puli";
            //Console.WriteLine("{0} {1} {2} {3}", k1.kor, k1.nev, k1.fajta, k1.kan);
            //Console.WriteLine(k1.ToString() + " " + k1.oltasokDatuma.First());

            Kutya k2 = new Kutya(4, "Lex", "vizsla", true);
            //Console.WriteLine("{0} {1} {2} {3}", k2.kor, k2.nev, k2.fajta, k2.kan);
            //Console.WriteLine(k2.ToString());

            Kutya k3 = k2;
            k3.fajta = "tacskó";
            //Console.WriteLine(k3.ToString());

            List<Kutya> kutyak = new List<Kutya>() { k1, k2, k3 };

            for (int i = 0; i < kutyak.Count; i++)
            {
                Console.WriteLine(kutyak[i].ToString());
            }

            int max = 0;
            for (int i = 0;i < kutyak.Count;i++)
            {
                if(max < kutyak[i].kor)
                {
                    max = i;
                }
            }
            Console.WriteLine(kutyak[max].nev);


            Console.ReadLine();
        }
    }

    struct Kutya
    {
        public int kor;
        public string nev, fajta;
        public bool kan;
        public List<string> oltasokDatuma;

        //Konstruktor
        public Kutya(int ujkor, string ujnev, string ujfajta, bool ujkan)
        {
            this.kor = ujkor;
            this.nev = ujnev;
            this.fajta = ujfajta;
            this.kan = ujkan;
            oltasokDatuma = new List<string>() { "2022.05.04" };
        }

        //Metodus
        public string ToString()
        {
            return string.Format("{0} {1} {2} {3}", kor, nev, fajta, kan);
        }
    }
}
