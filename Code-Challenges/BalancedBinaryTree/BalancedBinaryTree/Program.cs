using System;
using System.Collections.Generic;
using BalancedBinaryTree.Classes;

namespace BalancedBinaryTree
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

            bool balanced = IsBinaryTreeBalanced(bt.Root);

            Console.WriteLine($"This tree is {balanced} balanced");
            Console.Read();
        }
        public static bool IsBinaryTreeBalanced(Node root)
        {
            bool result = false;
            int leftNodesCount = InOrder(root.Left).Count;
            int rightNodesCount = InOrder(root.Right).Count;

            if (leftNodesCount == 0 && rightNodesCount == 0)
                return true;
            if (leftNodesCount <= rightNodesCount + 1
                && leftNodesCount >= rightNodesCount - 1)
                result = true;
            return result;
        }
        public static List<int> InOrder(Node node)
        {
            List<int> list = new List<int>();
            InOrder(node, list);
            return list;
        }
        private static List<int> InOrder(Node node, List<int> list)
        {
            if (node.Left != null)
                InOrder(node.Left, list);
            list.Add(node.Value);
            if (node.Right != null)
                InOrder(node.Right, list);
            return list;
        }
    }
}
