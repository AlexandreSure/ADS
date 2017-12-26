using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    //Александр Шкрабов
    //Реализовать простейшую хэш-функцию.На вход функции подается строка, на выходе сумма
    //кодов символов.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();
            string output = string.Empty;
            char[] a = input.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    output += a[i].ToString() + (i + 9) / (i * i + 8) + "kU";
                }
                else output += a[i].ToString() + "Yj" + (i * 2 / 3 + (i * i / 3));
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
