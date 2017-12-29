using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{   
    // Написать рекурсивную функцию обхода графа в глубину.
    
    class Program
    {
        static void Load(string path, out int[,] a)
        {
            StreamReader sr = new StreamReader(path);
            int N = int.Parse(sr.ReadLine());
            a = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string temp = sr.ReadLine();
                string[] mTemp = temp.Split(Convert.ToChar(" "));
                for (int j = 0; j < N; j++)
                {
                    a[i, j] = int.Parse(mTemp[j]);
                }
            }
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Bypass(int[,] a, int[] act, int i, int j)
        {
            if (a[i, j] != 0)
            {
                if (act[i] != 1)
                {
                    act[i] = 1;
                    if (j + 1 < a.GetLength(1))
                    {
                        Bypass(a, act, i = 0, j + 1);
                    }
                }
                else if (i + 1 < a.GetLength(0))
                {
                    Bypass(a, act, i + 1, j);
                }
            }
            else if (i + 1 < a.GetLength(0))
            {
                Bypass(a, act, i + 1, j);
            }
        } 

        static void Main(string[] args)
        {
            string path = "C:\\CSharp\\ADSm.txt";
            int[] act = new int[6] { 1, 0, 0, 0, 0, 0 };
            int[,] a;
            Load(path, out a);
            int i = 0; int j = 0;
            Print(a);
            Bypass(a, act, i, j);
            Console.WriteLine("\nA   B   C   D   E   F");
            Console.WriteLine("{0}   {1}   {2}   {3}   {4}   {5}", act[0], act[1], act[2], act[3], act[4], act[5]);
            Console.ReadKey();
        }
    }
}
