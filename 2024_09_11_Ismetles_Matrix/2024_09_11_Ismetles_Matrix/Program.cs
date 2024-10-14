using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_11_Ismetles_Matrix
{
    internal class Program
    {
        static int[,] tomb;
        static List<int> szomszedok;

        static void Main(string[] args)
        {
            Console.Write("Adja meg a mátrix sorát: ");
            int sor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg a mátrix oszlopát: ");
            int oszlop = Convert.ToInt32(Console.ReadLine());
            tomb = new int[sor, oszlop];
            Console.WriteLine();

            MatrixFeltoltes();
            MatrixKiiratas();
            Console.WriteLine();

            Feladat1();
            Feladat2();


            Console.ReadLine();
        }

        static void Feladat2()
        {
            (int maxSor, int maxOszlop) = LegnagyobbAtlaguSzomszed();
            Console.WriteLine("A {0}. sorban és {1}. oszlopban találhato az az elem, amelyik szommszédjainak átlaga a legnagyobb");
        }

        static (int, int) LegnagyobbAtlaguSzomszed()
        {
            int maxi = 0;
            int maxj = 0;
            int maxe = 0;
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    double atkagAkt = SzomszedGyujt(i,j).;
                    if (tomb[i,j] > tomb[maxi, maxj])
                    {
                        maxi = i;
                        maxj = j;
                    }
                }
            }

            return (maxi, maxj);
        }

        static void Feladat1()
        {
            Console.Write("Adja meg a kívánt sorszámát: ");
            int sor2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a kívánt oszlopszámát: ");
            int oszlop2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            SzomszedGyujt(sor2-1, oszlop2-1);
            SzomszedKiir();
        }

        static void SzomszedKiir()
        {
            for (int i = 0; i < szomszedok.Count; i++) { 
                Console.Write(szomszedok[i] + " ");
            }
            Console.WriteLine();
        }

        static List<int> SzomszedGyujt(int sor2, int oszlop2)
        {
            szomszedok = new List<int>();
            for (int i = -1; i < 2; i++)
            {
                for(int j = -1; j < 2; j++)
                {
                    if (sor2 + i > -1 && oszlop2 + j > -1 && sor2 + i < tomb.GetLength(0) && oszlop2 + j < tomb.GetLength(1) && (i != 0 || j != 0))
                        szomszedok.Add(tomb[sor2 +i, oszlop2 + j]);
                }
            }
            return szomszedok;
        }



        static void MatrixKiiratas()
        {
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    if (tomb[i, j] < 10)
                        Console.Write("  " +tomb[i, j] + " ");
                    else if (tomb[i,j] < 100)
                        Console.Write(" " + tomb[i, j] + " ");
                    else
                        Console.Write(tomb[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void MatrixFeltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    tomb[i, j] = r.Next(0, 1001);
                }
            }
        }
    }
}
