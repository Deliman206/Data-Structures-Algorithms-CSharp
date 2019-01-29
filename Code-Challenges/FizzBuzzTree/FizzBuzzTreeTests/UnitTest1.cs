using System;
using Xunit;
using FizzBuzzTree;
using FizzBuzzTree.Classes;

namespace FizzBuzzTreeTests
{
    public class FizzBuzzTree
    {
        [Fact]
        public void TestWithTree()
        {
            BinaryTree bt = new BinaryTree();
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);

            bt.Root = one;
            one.Left = two;
            one.Right = three;
            two.Right = five;
            three.Left = four;

            BinaryTree btT = new BinaryTree();

            Node oneT = new Node(1);
            Node twoT = new Node(2);
            Node threeT = new Node(3);
            threeT.Value = "Fizz";
            Node fourT = new Node(4);
            Node fiveT = new Node(5);
            fiveT.Value = "Buzz";

            btT.Root = oneT;
            oneT.Left = twoT;
            oneT.Right = threeT;
            twoT.Right = fiveT;
            threeT.Left = fourT;
            
            Assert.Equal(btT.Root.ToString(), Program.FizzBuzzTree(bt).Root.ToString());
        }
    }
    public class FizzBuzzCheck
    {
        [Fact]
        public void NoChanges()
        {
            Node node = new Node(1);
            Assert.True(Convert.ToInt32(Program.FizzBuzzCheck(node).Value) == 1);
        }
        [Fact]
        public void FizzTest()
        {
            Node node = new Node(3);
            Assert.True(Program.FizzBuzzCheck(node).Value == "Fizz");
        }
        [Fact]
        public void BuzzTest()
        {
            Node node = new Node(5);
            Assert.True(Program.FizzBuzzCheck(node).Value == "Buzz");
        }
        [Fact]
        public void FizzBuzzTest()
        {
            Node node = new Node(15);
            Assert.True(Program.FizzBuzzCheck(node).Value == "FizzBuzz");
        }
    }
}
