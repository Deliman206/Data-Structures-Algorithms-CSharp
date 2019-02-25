using System;
using GraphDataStructure.Classes;

namespace GraphDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph graph = new Graph();
            Node test = graph.AddNode(1);

            for (int i = 0; i < 10; i++)
            {
                Node nodeTwo = graph.AddNode(i);
                int weight = (i + 15) / 2;

                graph.AddEdge(test, nodeTwo, weight);
            }
            var x = graph.GetNeighbors(test.ID).Count;
            Console.Read();
        }
    }
}
