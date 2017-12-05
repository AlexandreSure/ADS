using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    //Александр Шкрабов
    //Автоморфные числа.Натуральное число называется автоморфным, если оно равно
    //последним цифрам своего квадрата.Например, 25^2 = 625. Напишите программу, которая
    //вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.

    class Program
    {
        static int CountOfDigits(int num)           //Считаем количество цифр 
        {
            int count = 0;
            while (num != 0)
            {
                num = num / 10;
                count++;
            }
            return count;
        }
        static bool Verification(int num)           //Проверяем, есть ли совпадение
        {
            double temp;
            double lastDigits;
            double dnum = Math.Pow(num, 2);
            if (num > 0)
            {
                temp = Math.Pow(10, CountOfDigits(num));
                lastDigits = dnum % temp;
                if (num == lastDigits) return true;
                else return false;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert a natural number:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if (Verification(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
