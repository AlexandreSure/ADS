using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    //Реализовать функцию возведения числа a в степень b:
    //a)без рекурсии;
    //b)рекурсивно;
    //c)* рекурсивно, используя свойство чётности степени.

    class Program
    {
        static int ExponentiationA(int a, int b)
        {
            int c = a;
            if (b>0)
            {
                for (int i = 1; i < b; i++)
                {
                    a = c * a;
                }
                return a;
            }
            else return 1;
        }

        static int ExponentiationB(int a, int b)
        {
            if (b>0)
            {
                return a * ExponentiationB(a, b-1);
            }
            else return 1;
        }

        static int ExponentiationC(int a, int b)
        {
            if (b > 0)
            {
                if (b%2==0)
                {
                    return a * ExponentiationB(a*a, b - 2);
                }
                return a * ExponentiationB(a, b - 1);
            }
            else return 1;
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            Console.WriteLine(ExponentiationA(a, b));
            Console.WriteLine(ExponentiationB(a, b));
            Console.WriteLine(ExponentiationC(a, b));
            Console.ReadKey();
        }
    }
}
