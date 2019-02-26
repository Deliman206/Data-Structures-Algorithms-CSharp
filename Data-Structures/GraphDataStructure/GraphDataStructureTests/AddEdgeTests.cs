using System;
using System.Linq;
using Xunit;
using GraphDataStructure.Classes;

namespace GraphDataStructureTests
{
    public class AddEdgeTests
    {
        [Fact]
        public void AddEdge()
        {
            Graph graph = new Graph();
            Node nodeOne = graph.AddNode(1);
            Node nodeTwo = graph.AddNode(2);
            int weight = 10;

            graph.AddEdge(nodeOne, nodeTwo, weight);
            //Assert.True(nodeOne.AdjList.Where(t => t.Item1.Equals(nodeTwo)).FirstOrDefault().Item2);
        }
        [Fact]
        public void AddManyEdge()
        {
            Graph graph = new Graph();
            Node nodeOne = graph.AddNode(1);

            for (int i = 0; i < 100; i++)
            {
                Node nodeTwo = graph.AddNode(i);
                int weight = (i+15)/2;

                graph.AddEdge(nodeOne, nodeTwo, weight);
            }

            //Assert.True(graph.Edges.Where(e => e.Item1.ID == nodeOne.ID).Count() == 100);
        }
    }
}
