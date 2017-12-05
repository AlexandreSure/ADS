using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    //Даны целые положительные числа N и K.Используя только операции сложения и вычитания,
    //найти частное от деления нацело N на K, а также остаток от этого деления.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert K:");
            int K = int.Parse(Console.ReadLine());
            int quotient = 0;
            int remainer = 0;
            while (N > K)
            {
                N = N - K;
                quotient++;
            }
            remainer = N;
            Console.WriteLine($"Quotient:{quotient} and remainer:{remainer}");
            Console.ReadKey();
        }
    }
}
