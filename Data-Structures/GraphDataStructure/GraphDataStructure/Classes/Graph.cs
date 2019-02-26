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
        public Dictionary<int, int> Map { get; set; } = new Dictionary<int, int>();

        /// <summary>
        /// Add Node to Verticies property
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Added Node</returns>
        public Node AddNode(int value)
        {
            Node node = new Node(value);
            Vertecies.Add(node);
            return node;
        }

        /// <summary>
        /// Adds Edge to nodeOne of nodeTwo and weight
        /// </summary>
        /// <param name="nodeOne"></param>
        /// <param name="nodeTwo"></param>
        /// <param name="weight"></param>
        public void AddEdge(Node nodeOne, Node nodeTwo, int weight)
        {
            Node node = Vertecies.Where(n => n.ID == nodeOne.ID).FirstOrDefault();
            Tuple<Node, int> edge = Tuple.Create(nodeTwo, weight);
            node.AdjList.Add(edge);
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
        public List<Tuple<Node, int>> GetNeighbors(Node node)
        {
            return node.AdjList;
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
