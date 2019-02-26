using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GraphDataStructure.Classes;
using System.Linq;

namespace GraphDataStructureTests
{
    public class GetNeighborsTests
    {
        [Fact]
        public void GetNeighbors()
        {
            Graph graph = new Graph();
            Node test = graph.AddNode(1);

            for (int i = 0; i < 10; i++)
            {
                Node nodeTwo = graph.AddNode(i);
                int weight = (i + 15) / 2;

                graph.AddEdge(test, nodeTwo, weight);
            }
            //var x = graph.GetNeighbors(test.ID).Count();
            //Assert.True(graph.GetNeighbors(test.ID).Count() == 10);
        }
    }
}
