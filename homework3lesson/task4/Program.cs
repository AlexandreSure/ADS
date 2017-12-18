using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        //Подсчитать количество операций для каждой из сортировок и сравнить его с
        //асимптотической сложностью алгоритма.

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
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        count++;
                    }
                    count++;
                }
            }
            return count;
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
                        count++;
                    }
                }
                else
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
                        count++;
                    }
                }
            }
            return count;
        }

        static int ChooseSort(int[]a, out int count)
        {
            count = 0;
            int j = 0;
            int jmin;
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                jmin = i;
                count++;
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[jmin])
                    {
                        jmin = j;
                    }
                    temp = a[i];
                    a[i] = a[jmin];
                    a[jmin] = temp;
                    count = count + 2;
                }
            }
            return count;
        }

        static int InsertionSort(int[]a, out int count)
        {
            count = 0;
            int stemp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int j = i;
                int temp = a[i];
                count++;
                while (j > 0 && a[j-1] > temp)
                {
                    stemp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = stemp;
                    j--;
                    count++;
                }
                a[j] = temp;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] a1 = new int[] { 1, 2, 5, 7, 2, 8, 5, 3, 7, 2, 6, 6, 7, 2, 8, 2, 1, 3, 4, 6 };
            int[] a2 = new int[] { 1, 2, 5, 7, 2, 8, 5, 3, 7, 2, 6, 6, 7, 2, 8, 2, 1, 3, 4, 6 };
            int[] a3 = new int[] { 1, 2, 5, 7, 2, 8, 5, 3, 7, 2, 6, 6, 7, 2, 8, 2, 1, 3, 4, 6 };
            int[] a4 = new int[] { 1, 2, 5, 7, 2, 8, 5, 3, 7, 2, 6, 6, 7, 2, 8, 2, 1, 3, 4, 6 };
            int count1 = BubbleSort(a1, out count1);
            Print(a1);
            Console.WriteLine("BubbleSort: {0}", count1);
            int count2 = ShakerSort(a2, out count2);
            Print(a2);
            Console.WriteLine("ShakerSort: {0}", count2);
            int count3 = ChooseSort(a3, out count3);
            Print(a3);
            Console.WriteLine("ChooseSort: {0}", count3);
            int count4 = InsertionSort(a4, out count4);
            Print(a4);
            Console.WriteLine("InsertionSort: {0}", count4);
            Console.ReadKey();
        }
    }
}
