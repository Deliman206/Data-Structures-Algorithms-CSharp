using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GraphDataStructure.Classes;

namespace GraphDataStructureTests
{
    public class SizeTests
    {
        [Fact]
        public void GetSizeWithEmptyGraph()
        {
            Graph graph = new Graph();
            Assert.True(graph.Size() == 0);
        }
        [Fact]
        public void GetSizeWithGraphManyNodes()
        {
            Graph graph = new Graph();
            for (int i = 0; i < 100; i++)
            {
                var node = graph.AddNode(i);
            }
            Assert.True(graph.Size() == 100);
        }
    }
}
