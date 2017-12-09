using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADShw2
{
    //Шкрабов Александр
    //Реализовать функцию перевода из 10 системы в двоичную используя рекурсию.

    class Program
    {
        static void DecimalToBinaryRec(int a)
        {
            if (a / 2 != 0) DecimalToBinaryRec(a / 2);
            Console.Write(a%2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number:");
            int a = int.Parse(Console.ReadLine());
            DecimalToBinaryRec(a);
            Console.ReadKey();
        }
    }
}
