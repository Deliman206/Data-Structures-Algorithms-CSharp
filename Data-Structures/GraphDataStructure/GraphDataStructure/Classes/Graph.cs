using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Faker;

namespace GraphDataStructure.Classes
{
    public class Graph
    {
        public List<Node> Vertecies { get; set; } = new List<Node>();
        public List<Tuple<Node, Node, int>> Edges { get; set; } = new List<Tuple<Node, Node, int>>();
        public Dictionary<int, int> Map { get; set; } = new Dictionary<int, int>();

        /// <summary>
        /// Add Node to Verticies and Map properties
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Added Node</returns>
        public Node AddNode(int value)
        {
            Node node = new Node(value);
            node.ID = RandomNumber.Next(int.MaxValue);

            Map.Add(node.ID, node.Value);

            Vertecies.Add(node);
            return node;
        }

        /// <summary>
        /// Adds Edge for Two Node and the weight between the two Node
        /// </summary>
        /// <param name="nodeOne"></param>
        /// <param name="nodeTwo"></param>
        /// <param name="weight"></param>
        public void AddEdge(Node nodeOne, Node nodeTwo, int weight)
        {
            Edges.Add(Tuple.Create(nodeOne, nodeTwo, weight));
        }

        /// <summary>
        /// Gets all Node in Graph
        /// </summary>
        /// <returns></returns>
        public List<Node> GetNodes()
        {
            return Vertecies;
        }

        /// <summary>
        /// Get all Neighbors of input ID associated to a Node in the Graph
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Tuple of Nodes and their weight</returns>
        public List<Tuple<Node, Node, int>> GetNeighbors(int id)
        {
            return Edges.Where(t => t.Item1.ID == id).ToList();
        }

        /// <summary>
        /// Get the number of Node in the Graph
        /// </summary>
        /// <returns>integar size of node in graph</returns>
        public int Size()
        {
            return Vertecies.Count;
        }
        
    }
}
