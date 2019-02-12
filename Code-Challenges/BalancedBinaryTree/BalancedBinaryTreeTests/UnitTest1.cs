using System;
using Xunit;
using BalancedBinaryTree;
using BalancedBinaryTree.Classes;
namespace BalancedBinaryTreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void IsBinaryTreeBalancedTrue()
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

            Assert.True(Program.IsBinaryTreeBalanced(bt.Root));
        }
        [Fact]
        public void IsBinaryTreeBalancedFalse()
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
            four.Left = six;
            four.Right = seven;

            Assert.False(Program.IsBinaryTreeBalanced(bt.Root));
        }
    }
}
