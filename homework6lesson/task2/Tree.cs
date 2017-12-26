using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node parent;
        public Node(){}

        public void Print(Node Tree)
        {
            Node temp = Tree;
            Console.Write(temp.value);
            if (temp.left != null || temp.right != null)
            {
                Console.Write("(");
                if (temp.left != null)
                {
                    Print(temp.left);
                }
                else Console.Write("Null");
                Console.Write(",");
                if (temp.right != null)
                {
                    Print(temp.right);
                }
                else Console.Write("Null");
                Console.Write(")");
            }
        }

        public Node CreateNewNode(int value, Node parent)
        {
            Node temp = new Node();
            temp.left = temp.right = null;
            temp.value = value;
            temp.parent = parent;
            return temp;
        }

        public void Insert(Node head, int value)
        {
            Node temp = null;
            if (head == null)
            {
                head = CreateNewNode(value, null);
                return;
            }
            temp = head;
            if (value > temp.value)
            {
                if (temp.right == null)
                {
                    temp.right = CreateNewNode(value, temp);
                }
                else Insert(temp.right, value);
            }
            if (value < temp.value)
            {
                if (temp.left == null)
                {
                    temp.left = CreateNewNode(value, temp);
                }
                else Insert(temp.left, value);
            }
        }

        public void preOrder(Node Tree)
        {
            if (Tree != null)
            {
                Console.Write(Tree.value + "");
                preOrder(Tree.left);
                preOrder(Tree.right); 
            }
        }

        public void inOrder(Node Tree)
        {
            if (Tree != null)
            {
                preOrder(Tree.left);
                Console.Write(Tree.value + "");
                preOrder(Tree.right);
            }
        }

        public void postOrder(Node Tree)
        {
            if (Tree != null)
            {
                preOrder(Tree.left);
                preOrder(Tree.right);
                Console.Write(Tree.value + "");
            }
        }

        public void Search(Node Tree, int value)
        {
            if (Tree.value != value)
            {
                if (value < Tree.value)
                {
                    if (Tree.left != null)
                    {
                        Search(Tree.left, value);
                    }    
                }
                else if(value > Tree.value)
                {
                    if (Tree.right != null)
                    {
                        Search(Tree.right, value);
                    }
                }
                else Console.WriteLine("Такого элемента в древе нет!!!");
            }
            else Console.WriteLine("Такой элемент найден!!!(в древе)");
        }
    }


}

