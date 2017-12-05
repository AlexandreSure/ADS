using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    //Ввести возраст человека(от 1 до 150 лет) и вывести его вместе с последующим словом
    //«год», «года» или «лет».
    class Program
    {
        static int LastDigit(ref int value)
        {
            int n = 0; 
            n = value % 10;
            return n;
        }
        static void Print(int n, ref  int value)
        {
            if (n == 1)
            {
                if (value != 11 && value != 111)
                {
                    Console.WriteLine($"{value} год.");
                }
            }
            if (n == 2 || n == 3 || n == 4)
            {
                if (value != 12 && value != 13 && value != 14 && value != 112 && value != 113 && value != 114)
                {
                    Console.WriteLine($"{value} года");
                }
                else Console.WriteLine($"{value} лет");
            }
            else Console.WriteLine($"{value} лет");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert:");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Print(LastDigit(ref value), ref value);
            Console.ReadKey();
        }
    }
}
