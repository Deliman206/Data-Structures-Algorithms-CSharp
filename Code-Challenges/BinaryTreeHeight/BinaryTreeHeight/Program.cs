using System;
using BinaryTreeHeight.Classes;
namespace BinaryTreeHeight
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node bt = new Node();
            Node two = new Node();
            Node three = new Node();
            Node four = new Node();
            Node five = new Node();

            bt.Left = two;
            bt.Right = three;
            three.Right = four;
            four.Right = five;


            Console.WriteLine($"Height of the Binary Tree is: -- {BinaryTreeHeight(bt)} --");
            Console.Read();
        }
        /// <summary>
        /// Finds max height of binary tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns>int height</returns>
        public static int BinaryTreeHeight(Node node)
        {
            if (node != null)
            {
                int rightHeight = BinaryTreeHeight(node.Right);
                int leftHeight = BinaryTreeHeight(node.Left);

                if (rightHeight > leftHeight)
                    return rightHeight + 1;
                return leftHeight + 1;
            }
            else
                return 0;
        }
       
        
    }
}
