using System;
using System.Linq;
using Xunit;
using GraphDataStructure.Classes;

namespace GraphDataStructureTests
{
    public class AddNodeTests
    {
        [Fact]
        public void AddNode()
        {
            Graph graph = new Graph();
            Node node = graph.AddNode(1);
            Assert.True(node.Value == 1 && graph.Vertecies.Where(n => n.ID == node.ID).Count() == 1);
        }
        [Fact]
        public void AddManyNodeWithUniqueID()
        {
            Graph graph = new Graph();
            Node uniqueNode = graph.AddNode(1);

            for (int i = 0; i < 1000; i++)
            {
                var node = graph.AddNode(i);
            }
            Assert.True(graph.Vertecies.Where(n => n.ID == uniqueNode.ID).Count() == 1);
        }
    }
}
