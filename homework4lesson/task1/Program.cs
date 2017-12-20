using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    //Количество маршрутов с препятствиями.Реализовать чтение массива с препятствием и нахождение количество маршрутов.

    class Program
    {
        static void Print(int[,]a)
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

        static void Main(string[] args)
        {
            int[,] a = new int[6, 6];
            StreamReader sr = new StreamReader("C:\\CSharp\\task1.txt");
            char c = Convert.ToChar(" ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                string s = sr.ReadLine();
                string [] s1 = s.Split(c);
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(s1[j]);
                }
            }
            sr.Close();
            Print(a);
            int count = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != 0)
                    {
                        if (i - 1 >= 0 && j - 1 >= 0)
                        {
                            if (a[i - 1, j] == 1 && a[i, j - 1] == 1)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\nКоличество путей: {0}", count);
            Console.ReadKey();
        }   
    }
}
