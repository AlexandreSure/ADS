using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        //Реализовать бинарный алгоритм поиска в виде функции, которой передается
        //отсортированный массив.Функция возвращает индекс найденного элемента или -1, если
        //элемент не найден.

        static int BinarySearch(int[]a, int value)
        {
            int L = 0;
            int N = a.Length;
            int R = N - 1;
            int m = L + (R-L) / 2;
            while (L <= R && a[m] != value && m < a.Length)
            {
                if (a[m] < value) L = m + 1;
                else R = m - 1;
                m = L + (R - L) / 2;
                if (m == N) m--;            }
            if (a[m] == value) return m;
            else return -1;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 4, 5, 7, 3, 5, 7, 3, 1, 3 };
            Array.Sort(a);
            Console.Write("Введите искомый элемент: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Индекс этого элемента: {0}", BinarySearch(a, value));
            Console.ReadKey();
        }
    }
}
