using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADShomework8
{
    //Шкрабов Александр
    //Реализовать сортировку подсчетом.

    class Program
    {
        static void Main(string[] args)
        {
            const int m = 1000;
            int[] c = new int[m];
            int[] a = new int[] { 6, 3, 2, 5, 7, 5, 2, 3, 1, 4, 6, 8, 4, 78, 32, 12, 54, 67, 34, 62, 87, 98, 23, 76 };
            int b = 0;
            Console.WriteLine("Array before sort:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}",a[i]);
            }
            for (int i = 0; i < m; i++)                         //Здесь в методичке указана длина массива a, хотя заполнять нужно
            {                                                   //частотный массив по всей его длине 
                c[i] = 0;
            }
            for (int i = 0; i < a.Length; i++)                  //Здесь же наоборот нужно подставить длину массива a, вместо длины
            {                                                   //частотного массива
                c[a[i]]++;
            }
            for (int j = 0; j < m; j++)                         //Здесь аналогично
            {
                for (int i = 0; i <= c[j] - 1; i++)             //Здесь в условии должен быть знак "<=", т.к. при 0<0 условие не вы-
                {                                               //полнится 
                    a[b++] = j;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Array after sort:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            Console.ReadKey();
        }
    }
}
