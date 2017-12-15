using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    //Реализовать шейкерную сортировку.

    class Program
    {
        static void Print(int[] a)
        {
            foreach (var e in a)
            {
                Console.Write("{0,5}", e);
            }
            Console.WriteLine();
        }

        static int ShakerSort(int[] a, out int count)
        {
            count = 0;
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                            count++;
                        }
                    }
                }
                if (i % 2 != 0)
                {
                    for (int j = a.Length - 1; j != 1; j--)
                    {
                        if (a[j] < a[j - 1])
                        {
                            temp = a[j];
                            a[j] = a[j - 1];
                            a[j - 1] = temp;
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 7, 2, 4, 5, 6, 2, 5, 7, 8, 6, 7, 2, 1, 3, 5, 6, 7, 8, 1, 3, 4, 5 };
            Console.WriteLine("Before:");
            Print(a);
            int count = ShakerSort(a, out count);
            Console.WriteLine("After:");
            Print(a);
            Console.WriteLine("Count: {0}", count);
            Console.ReadKey();
        }
    }
}
