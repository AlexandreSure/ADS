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
            Console.WriteLine("Введите путь к файлу: ");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            string newPath = string.Empty;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == Convert.ToChar("\\"))
                {
                    newPath += c[i] + "\\";
                }
                else
                newPath += c[i];
            }
            StreamReader sr = new StreamReader(newPath);
            string temp = sr.ReadLine();
            string[] a = temp.Split(Convert.ToChar(" "));
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    Tree = Tree.CreateNewNode(int.Parse(a[i]), null);
                }
                Tree.Insert(Tree, int.Parse(a[i]));
            }
            Console.WriteLine("Выберете способ обхода дерева: 1 - preOrder, 2 - inOrder, 3 - postOrder");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1: Tree.preOrder(Tree); break;
                case 2: Tree.inOrder(Tree); break;
                case 3: Tree.postOrder(Tree); break;
                default:
                    break;
            }
            //string path = "C:\\Users\\йешуа\\source\\repos\\ADShomework6\\Tree.txt";
            Tree.Print(Tree);
            Console.WriteLine();
            Tree.Search(Tree, 5);
            Console.ReadKey();
        }
    }
}
