using System;
using Xunit;
using FindMaxValue;
using Trees.Classes;

namespace FindMaxValueTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxOnEmptyTree()
        {
            BinaryTree bt = new BinaryTree();
            Assert.Throws<NullReferenceException>(() => Program.FindMaxValue(bt));
        }
        [Fact]
        public void FindMaxOnOneNodeTree()
        {
            BinaryTree bt = new BinaryTree();
            Node one = new Node(1);
            bt.Root = one;
            Assert.Equal(1, Program.FindMaxValue(bt));
        }
        [Fact]
        public void FindMaxOnBinaryTree()
        {
            BinaryTree bt = new BinaryTree();
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(13);
            Node four = new Node(4);
            Node five = new Node(5);

            bt.Root = one;
            one.Left = two;
            one.Right = three;
            two.Right = five;
            three.Left = four;

            Assert.Equal(13, Program.FindMaxValue(bt));
        }
    }
}
