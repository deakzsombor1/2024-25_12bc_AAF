using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal class Orszagut
    {
        public static List<IKisGepjarmu> jarmuvek = new List<IKisGepjarmu>();

        public static void jarmuvekJonnek(string path)
        {
            StreamReader sr = new StreamReader(path);
            while (sr.EndOfStream)
            {

            }
            sr.Close();
        }

        public static void kiketMertunkBe()
        {
            StreamWriter sw = new StreamWriter("buntetes.txt");
            for (int i = 0; i < jarmuvek.Count; i++)
            {

            }
            sw.Close();
        }
    }
}
