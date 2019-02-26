using System;
using System.Collections.Generic;
using System.Text;
using Faker;

namespace GraphDataStructure.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public int ID { get; set; }
        public List<Tuple<Node, int>> AdjList { get; set; }

        public Node(int value)
        {
            Value = value;
            ID = RandomNumber.Next(int.MaxValue);
            AdjList = new List<Tuple<Node, int>>();
        }
    }
}
