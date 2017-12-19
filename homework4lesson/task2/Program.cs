using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    //Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.

    class Program
    {
        static void Print(string[,]a)
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
            string [,] a = new string [11, 12];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = "0";
                }
            }
            a[0, 2] = "G"; a[0, 3] = "E"; a[0, 4] = "E"; a[0, 5] = "K"; a[0, 6] = "B"; a[0, 7] = "R"; a[0, 8] = "A";
            a[0, 9] = "I"; a[0, 10] = "N"; a[0, 11] = "S";
            a[2, 0] = "G"; a[3, 0] = "E"; a[4, 0] = "E"; a[5, 0] = "K"; a[6, 0] = "M"; a[7, 0] = "I"; a[8, 0] = "N";
            a[9, 0] = "D"; a[10, 0] = "S"; 
            Print(a);
            Console.WriteLine("\n");
            int count = 0;
            int x = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, 0] == "0" || a[0, x] == "0") { }
                else if (a[i, 0] == a[0, x])
                {
                    count++;
                    a[i, x] = count.ToString();
                }
                else
                    for (int k = x; k < a.GetLength(1); k++)
                    {
                        if(a[i, 0] == a[0, k])
                        {
                            count++;
                            a[i, k] = count.ToString();
                        }
                    }
                x++;
            }
            Print(a);
            Console.ReadKey();
        }
    }
}
