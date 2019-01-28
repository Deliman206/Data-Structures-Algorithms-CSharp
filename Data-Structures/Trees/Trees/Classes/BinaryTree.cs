using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public List<int> InOrder(Node node)
        {
            List<int> list = new List<int>();
            InOrder(node, list);
            return list;
        }
        private List<int> InOrder(Node node, List<int> list)
        {
            if (Root != null)
            {
                if (node.Left != null)
                    InOrder(node.Left, list);
                list.Add(node.Value);
                if (node.Right != null)
                    InOrder(node.Right, list);
                return list;
            }
            else
                return list;
        }
        public List<int> PostOrder(Node node)
        {
            List<int> list = new List<int>();
            PostOrder(node, list);
            return list;
        }
        private List<int> PostOrder(Node node, List<int> list)
        {
            if (Root != null)
            {
                if (node.Left != null)
                    PostOrder(node.Left, list);
                if (node.Right != null)
                    PostOrder(node.Right, list);
                list.Add(node.Value);
                return list;
            }
            else
                return list;
        }
        public List<int> PreOrder(Node node)
        {
            List<int> list = new List<int>();
            PreOrder(node, list);
            return list;
        }
        private List<int> PreOrder(Node node, List<int> list)
        {
            if (Root != null)
            {
                list.Add(node.Value);
                if (node.Left != null)
                    PreOrder(node.Left, list);
                if (node.Right != null)
                    PreOrder(node.Right, list);
                return list;
            }
            else
                return list;
        }
    }
}
