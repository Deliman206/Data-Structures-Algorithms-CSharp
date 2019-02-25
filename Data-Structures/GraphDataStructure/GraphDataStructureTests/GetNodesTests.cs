using System.Linq;
using Xunit;
using GraphDataStructure.Classes;
using System;

namespace GraphDataStructureTests
{
    public class GetNodesTests
    {
        [Fact]
        public void GetNodesWithEmptyGraph()
        {
            Graph graph = new Graph();
            Assert.True(graph.GetNodes().Count() == 0);
        }
        [Fact]
        public void GetNodesInGraph()
        {
            Graph graph = new Graph();

            for (int i = 0; i < 1000; i++)
            {
                var node = graph.AddNode(i);
            }
            Assert.Equal(1000, graph.GetNodes().Count());
        }
    }
}
