using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ADShomework5
{
    //Шкрабов Александр
    //Решить задачу с котом.

    class Program
    {
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0, 5}", a[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void Check(int[,] a, CatStep cs, Queue<CatStep> qe)
        {
            if (cs.x < 9 && cs.y < 9)
            {

                if (cs.x < 9 && cs.y - 1 >= 0 && a[cs.x, cs.y - 1] != 1)
                {
                    CatStep cs1 = new CatStep(cs.value, cs.x, cs.y);
                    a[cs1.x, cs1.y - 1] = cs1.value + 1;
                    cs1.y -= 1;
                    cs1.value += 1;
                    qe.Enqueue(cs1);
                }
                if (cs.x + 1 < 9 && cs.y < 0 && a[cs.x + 1, cs.y] != 1)
                {
                    CatStep cs2 = new CatStep(cs.value, cs.x, cs.y);
                    a[cs2.x + 1, cs2.y] = cs2.value + 1;
                    cs2.x += 1;
                    cs2.value += 1;
                    qe.Enqueue(cs2);
                }
                if (cs.x < 9 && cs.y + 1 < 9 && a[cs.x, cs.y + 1] != 1)
                {
                    CatStep cs3 = new CatStep(cs.value, cs.x, cs.y);
                    a[cs3.x, cs3.y + 1] = cs3.value + 1;
                    cs3.y += 1;
                    cs3.value += 1;
                    qe.Enqueue(cs3);
                }
                if (cs.x - 1 >= 0 && cs.y < 9 && a[cs.x - 1, cs.y] != 1)
                {
                    CatStep cs4 = new CatStep(cs.value, cs.x, cs.y);
                    a[cs4.x - 1, cs4.y] = cs4.value + 1;
                    cs4.x -= 1;
                    cs4.value += 1;
                    qe.Enqueue(cs4);
                }
                if (qe.Count != 0)
                {
                    Check(a, qe.Dequeue(), qe);
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] a = new int[9, 9];
            string path = "C:\\CSharp\\CatMassive.Txt";
            StreamReader sr = new StreamReader(path);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                string temp = sr.ReadLine();
                string[] temp2 = temp.Split(Convert.ToChar(" "));
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(temp2[j]);
                }
            }
            Print(a);
            Queue<CatStep> qe = new Queue<CatStep>();
            CatStep cs = new CatStep(0, 6, 2);
            Console.WriteLine("\n");
            Check(a, cs, qe);
            Print(a);
            Console.ReadKey();
        }
    }
}
