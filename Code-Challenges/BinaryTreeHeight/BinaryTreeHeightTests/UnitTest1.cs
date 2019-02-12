using System;
using Xunit;
using BinaryTreeHeight;
using BinaryTreeHeight.Classes;

namespace BinaryTreeHeightTests
{
    public class BinaryTreeHeight
    {
        [Fact]
        public void BinaryTreeWithOnlyRoot()
        {
            Node root = new Node();
            Assert.Equal(1, Program.BinaryTreeHeight(root));
        }
        [Fact]
        public void BinaryTreeWithUnEven()
        {
            Node root = new Node();
            Node one = new Node();
            Node two = new Node();
            Node three = new Node();
            root.Left = one;
            root.Right = two;
            two.Left = three;

            Assert.Equal(3, Program.BinaryTreeHeight(root));
        }
        [Fact]
        public void BinaryTreeWithEven()
        {
            Node root = new Node();
            Node zero = new Node();
            Node one = new Node();
            Node two = new Node();
            Node three = new Node();
            root.Left = one;
            one.Right = zero;
            root.Right = two;
            two.Left = three;
            Assert.Equal(3, Program.BinaryTreeHeight(root));
        }
    }
}
