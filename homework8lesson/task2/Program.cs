using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    //Реализовать быструю сортировку.
    
    class Program
    {
        static void QuickSort(int[]a, int start, int end)
        {
            int temp = 0;
            int middle = a[(start + end) / 2];
            int i = start; int j = end;
            do
            {
                while (a[i] < middle) i++;
                while (a[j] > middle) j--;
                if (i <= j)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    i++; j--;
                }

            } while (i <= j);
            if (i < end)
            {
                QuickSort(a, i, end);
            }
            if (j > start)
            {
                QuickSort(a, start, j);
            }
        }

        static void Main(string[] args)
        {
            int[] a = new int[12];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 512);
            }
            int start = 0; int end = a.Length - 1;
            Console.WriteLine("Before:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,5}", a[i]);
            }
            QuickSort(a, start, end);
            Console.WriteLine();
            Console.WriteLine("After:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,5}", a[i]);
            }
            Console.ReadKey();
        }
    }
}
