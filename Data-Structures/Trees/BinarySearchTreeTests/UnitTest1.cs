using System;
using Xunit;
using Trees.Classes;

namespace TreesTests
{
    public class AddMethodTests
    {
        [Fact]
        public void AddNodeToTree()
        {
            Node one = new Node(1);
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(one);
            Assert.True(bst.Root.Value == 1);
        }
    }
}
