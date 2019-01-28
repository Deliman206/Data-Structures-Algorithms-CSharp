using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; } = null;
        public Node Right { get; set; } = null;

        public Node(int value)
        {
            Value = value;
        }
    }
}
