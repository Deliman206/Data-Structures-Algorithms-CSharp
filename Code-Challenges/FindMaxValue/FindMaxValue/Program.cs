using System;
using System.Collections;
using Trees.Classes;

namespace FindMaxValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);
            Node seven = new Node(7);

            bt.Root = one;
            one.Left = two;
            one.Right = three;
            two.Left = four;
            two.Right = five;
            three.Left = six;
            three.Right = seven;

            Console.WriteLine($"The max Value of the tree is: { FindMaxValue(bt) }");
            Console.Read();
        }
        public static int FindMaxValue(BinaryTree bt)
        {
            int maxValue = bt.Root.Value;
            Queue que = new Queue();

            if(bt.Root != null)
            {
                if (bt.Root.Left != null)
                    que.Enqueue(bt.Root.Left);
                if (bt.Root.Right != null)
                    que.Enqueue(bt.Root.Right);
                while(que.Count != 0)
                {
                    Node node = que.Dequeue() as Node;
                    maxValue = CheckMax(maxValue, node.Value);
                    if (node.Left != null)
                        que.Enqueue(node.Left);
                    if (node.Right != null)
                        que.Enqueue(node.Right);
                }
            }
            return maxValue;
        }
        private static int CheckMax(int currentMax, int num)
        {
            if (num > currentMax)
                return num;
            return currentMax;
        }
    }
}
