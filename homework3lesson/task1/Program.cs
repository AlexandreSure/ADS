using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADShomework3
{
    //Шкрабов Александр
    //Попробовать оптимизировать пузырьковую сортировку.Сравнить количество операций
    //сравнения оптимизированной и не оптимизированной программы. Написать функции
    //сортировки, которые возвращают количество операций.

    class Program
    {
        static void Print(int[] a)
        {
            foreach (var e in a)
            {
                Console.Write("{0,3}", e);
            }
            Console.WriteLine();
        }
       
        static int BubbleSort(int[] a, out int count)
        {
            count = 0;
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    count++;
                    if (a[j] > a[j+1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        count++;
                    }
                }
            }
            return count;
        }

        static int BubbleSortPlus(int[] a, out int count)
        {
            count = 0;
            int temp = 0;
            bool flag = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    count++;
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        count++;
                        flag = true;
                    }
                }
                if (flag == false) break;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 7, 2, 4, 5, 6, 2, 5, 7, 8, 6, 7, 2, 1, 3, 5, 6, 7, 8, 1, 3, 4, 5 };
            int[] b = new int[] { 7, 2, 4, 5, 6, 2, 5, 7, 8, 6, 7, 2, 1, 3, 5, 6, 7, 8, 1, 3, 4, 5 };
            Console.WriteLine("Before:");
            Print(a);
            int countBubbleSort = BubbleSort(a, out countBubbleSort);
            Console.WriteLine("After BubbleSort:");
            Print(a);
            Console.WriteLine("BubbleSort count: {0}", countBubbleSort);
            int countBubbleSortPlus = BubbleSortPlus(b, out countBubbleSortPlus);
            Console.WriteLine("After BubbleSortPlus:");
            Print(b);
            Console.WriteLine("BubbleSortPlus count: {0}", countBubbleSortPlus);
            Console.ReadKey();
        }
    }
}
