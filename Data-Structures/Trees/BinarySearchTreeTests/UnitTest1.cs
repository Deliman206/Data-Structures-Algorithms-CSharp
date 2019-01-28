using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;

namespace TreesTests
{
    public class BstAddMethodTests
    {
        [Fact]
        public void AddNodeToEmptyTree()
        {
            Node one = new Node(1);
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(one);
            Assert.True(bst.Root.Value == 1);
        }
        [Fact]
        public void AddNodeToTree()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);

            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(three);
            bst.Add(two);
            bst.Add(one);
            bst.Add(five);
            bst.Add(four);
            bst.Add(six);

            Assert.True(bst.Root.Left.Left.Value == 1);
            Assert.True(bst.Root.Right.Left.Value == 4);
        }
    }
    public class BstContainsMethodTests
    {
        [Fact]
        public void ContainsOnEmptyTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node one = new Node(1);

            Assert.False(bst.Contains(one));
        }
        [Fact]
        public void ContainsInTree()
        {
            BinarySearchTree bst = new BinarySearchTree();

            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);

            bst.Add(three);
            bst.Add(two);
            bst.Add(one);
            bst.Add(five);
            bst.Add(four);
            bst.Add(six);

            Assert.True(bst.Contains(five));
        }
    }
    public class BtInOrder
    {
        [Fact]
        public void InOrderOnEmptyTree()
        {
            BinaryTree bt = new BinaryTree();
            List<int> solution = new List<int>();

            Assert.Equal(solution, bt.InOrder(bt.Root));
        }
        [Fact]
        public void InOrderOnTree()
        {

            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);
            Node seven = new Node(7);

            List<int> solution = new List<int>();
            solution.Add(4);
            solution.Add(2);
            solution.Add(5);
            solution.Add(1);
            solution.Add(6);
            solution.Add(3);
            solution.Add(7);

            BinaryTree bt = new BinaryTree();
            bt.Root = one;

            one.Left = two;
            one.Right = three;
            two.Left = four;
            two.Right = five;
            three.Left = six;
            three.Right = seven;
            
            Assert.Equal(solution, bt.InOrder(bt.Root));
        }
    }
    public class BtPreOrder
    {
        [Fact]
        public void PreOrderOnEmptyTree()
        {
            BinaryTree bt = new BinaryTree();
            List<int> solution = new List<int>();

            Assert.Equal(solution, bt.PreOrder(bt.Root));
        }
        [Fact]
        public void PreOrderOnTree()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);
            Node seven = new Node(7);

            List<int> solution = new List<int>();
            solution.Add(1);
            solution.Add(2);
            solution.Add(4);
            solution.Add(5);
            solution.Add(3);
            solution.Add(6);
            solution.Add(7);

            BinaryTree bt = new BinaryTree();
            bt.Root = one;

            one.Left = two;
            one.Right = three;
            two.Left = four;
            two.Right = five;
            three.Left = six;
            three.Right = seven;

            Assert.Equal(solution, bt.PreOrder(bt.Root));
        }
    }
    public class BtPostOrder
    {
        [Fact]
        public void PostOrderOnEmptyTree()
        {
            BinaryTree bt = new BinaryTree();
            List<int> solution = new List<int>();

            Assert.Equal(solution, bt.PostOrder(bt.Root));
        }
        [Fact]
        public void PostOrderOnTree()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);
            Node seven = new Node(7);

            List<int> solution = new List<int>();
            solution.Add(4);
            solution.Add(5);
            solution.Add(2);
            solution.Add(6);
            solution.Add(7);
            solution.Add(3);
            solution.Add(1);

            BinaryTree bt = new BinaryTree();
            bt.Root = one;

            one.Left = two;
            one.Right = three;
            two.Left = four;
            two.Right = five;
            three.Left = six;
            three.Right = seven;

            Assert.Equal(solution, bt.PostOrder(bt.Root));
        }
    }
}
