using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Faker;
using System.Collections;

namespace GraphDataStructure.Classes
{
    public class Graph
    {
        public List<Node> Vertecies { get; set; } = new List<Node>();
        public Dictionary<Node, bool> Map { get; set; } = new Dictionary<Node, bool>();

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
        /// <summary>
        /// Gets a list of all nodes from the input node
        /// </summary>
        /// <param name="node"></param>
        /// <returns>List<Node></returns>
        public List<Node> BreadthFirstTraversal(Node input)
        {
            List<Node> solution = new List<Node>();
            Queue que = new Queue();
            if(input != null)
            {
                que.Enqueue(input);
                while(que.Count != 0)
                {
                    Node node = que.Dequeue() as Node;
                    solution.Add(node);
                    Map.Add(node, true);
                    foreach(var item in node.AdjList)
                    {
                        if (!Map.ContainsKey(item.Item1))
                        {
                            que.Enqueue(node);
                        }
                    }
                }
            }
            return solution;
        }
        
    }
}
