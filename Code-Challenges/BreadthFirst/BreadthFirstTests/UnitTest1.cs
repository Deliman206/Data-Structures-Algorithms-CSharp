using System;
using Xunit;
using BreadthFirst;
using BreadthFirst.Classes;

namespace BreadthFirstTests
{
    public class BreadthFirstMethod
    {
        [Fact]
        public void TreeWithOneNode()
        {
            BinaryTree bt = new BinaryTree();
            Node one = new Node(1);
            bt.Root = one;

            Assert.Equal("1 ", Program.BreadthFirst(bt));
        }

        [Fact]
        public void TreeWithNoNode()
        {
            BinaryTree bt = new BinaryTree();

            Assert.Equal("", Program.BreadthFirst(bt));
        }

        [Fact]
        public void TreeWithManyNodes()
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

            Assert.Equal("1 2 3 4 5 6 7 ", Program.BreadthFirst(bt));
        }
    }
}
