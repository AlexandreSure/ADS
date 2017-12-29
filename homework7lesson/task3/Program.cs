using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    // Написать функцию обхода графа в ширину.

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

        static void Bypass(int[,]a, int[] act, Queue<int> qe)
        {
            qe.Enqueue(0);
            act[0] += 1;
            while (qe.Count != 0)
            {
                int p = qe.Dequeue();
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if (a[i, p] == 1 && act[i] < 2)
                    {
                        qe.Enqueue(i);
                        act[i] += 1;
                    }
                }
                act[p] += 1;
            }
        }

        static void Main(string[] args)
        {
            string path = "C:\\CSharp\\testADS.txt";
            int[] act = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[,] a;
            Load(path, out a);
            Queue<int> qe = new Queue<int>();
            Bypass(a, act, qe);
            Console.WriteLine("\nA   B   C   D   E   F   G   H");
            Console.WriteLine("{0}   {1}   {2}   {3}   {4}   {5}   {6}   {7}", act[0], act[1], act[2], act[3], act[4], act[5], act[6], act[7]);
            Console.ReadKey();
        }
    }
}
