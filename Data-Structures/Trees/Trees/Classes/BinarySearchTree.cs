using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public void Add(Node node)
        {
            if (Root == null)
                Root = node;
            
            else
                Add(Root, node); 
        }
        private void Add(Node root, Node node)
        {
            if (node.Value < root.Value)
            {
                if (root.Left == null)
                    root.Left = node;
                else
                    Add(root.Left, node);
            }            
            else if (root.Right == null)
                root.Right = node;
            else
                Add(root.Right, node);
        }
        public bool Contains(Node node)
        {
            if (Root == null)
                return false;
            if (Root.Value == node.Value)
                return true;
            else
                return Contains(Root, node);
        }
        private bool Contains(Node root, Node node)
        {
            if (root == null)
                return false;
            else if(node.Value == root.Value)
                return true;
            else if (node.Value < root.Value)
                return Contains(root.Left, node);
            else
                return Contains(root.Right, node);
        }
    }
}
