using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        //Исполнитель Калькулятор преобразует целое число, записанное на экране.У исполнителя две команды, каждой команде присвоен
        //номер:
        //1.Прибавь 1;
        //2.Умножь на 2. 
        //Первая команда увеличивает число на экране на 1, вторая увеличивает это число в 2 раза.Сколько существует программ,
        //которые число 3 преобразуют в число 20? а) с использованием массива; б) с использованием рекурсии.

        static int A(int[] a, int b, int count)
        {
            for (int i = b + 1; i < a.Length; i++)
            {
                if (a[i]%2==0)
                {
                    count++;
                }
            }
            return count;
        }

        static int B(int b, int c, int count)
        {
            if (b != c)
            {
                if ((b + 1) % 2 == 0) count++;
                return B(b + 1, c, count);
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] a = new int[21];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }
            int b = 3;
            int c = a.Length - 1;
            int count = 1;
            Console.WriteLine(A(a, b, count));
            Console.WriteLine(B(b, c, count));
            Console.ReadKey();
        }
    }
}
