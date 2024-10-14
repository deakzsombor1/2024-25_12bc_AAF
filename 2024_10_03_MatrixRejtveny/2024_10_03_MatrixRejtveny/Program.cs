using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_10_03_MatrixRejtveny
{
    internal class Program
    {

        static int[,] matrix = new int[10, 10];
        static List<Megoldas> megoldasok = new List<Megoldas>();

        static void Main(string[] args)
        {

            Fajlbeolvasas();
            FajlbeolvasasMegoldasok();

            Console.ReadLine();
        }


        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("feladvany.txt");

            int j = 0;
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                for (int i = 0; i < st.Length; i++)
                {
                    matrix[j,i] = Convert.ToInt32(st[i]);
                }
                j++;
            }
            f.Close();
        }


        static void FajlbeolvasasMegoldasok()
        {
            StreamReader g = new StreamReader("megoldas.txt");
            g.ReadLine();

            while (!g.EndOfStream)
            {
                int[,] sm = new int[10, 10];
                string nev = g.ReadLine();
                for (int i = 0;i < 10; i++)
                {
                    string[] st = g.ReadLine().Split(' ');
                    for(int j = 0; j < st.Length; j++)
                    {
                        sm[i,j] = Convert.ToInt32(st[j]);
                    }
                }
                Megoldas sv = new Megoldas(nev, sm);
                megoldasok.Add(sv);
            }
            
            g.Close();
        }
    }

    struct Megoldas
    {
        public string nev;
        public int[,] megoldas;

        public Megoldas(string nev, int[,] matrix)
        {
            this.nev = nev;
            megoldas = matrix;
        }
    }
}
