using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    //   Переписать программу, реализующее двоичное дерево поиска.
    //а) Добавить в него обход дерева различными способами;
    //б) Реализовать поиск в двоичном дереве поиска;
    //в) Добавить в программу обработку командной строки с помощью которой можно указывать
    //   из какого файла считывать данные, каким образом обходить дерево.

    class Program
    {
        static void Main(string[] args)
        {
            Node Tree = new Node();
            string path = "C:\\Users\\йешуа\\source\\repos\\ADShomework6\\Tree.txt";
            StreamReader sr = new StreamReader(path);
            string temp = sr.ReadLine();
            string[] a = temp.Split(Convert.ToChar(" "));
            for (int i = 0; i < a.Length; i++)
            {
                Tree.Insert(Tree, int.Parse(a[i]));
            }
            Tree.Print(Tree);
            Console.WriteLine();
            Tree.Search(Tree, 5);
            Console.ReadKey();
        }
    }
}
