using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

/// <summary>
/// At no time should an exception or stack trace be shown to the end user. Catch and handle any such exceptions and return a printed value or operation which cleanly represents the state and either stops execution cleanly, or provides the user with clear direction and output.
/// </summary>
namespace Trees.Classes
{
    public class BinaryTree
    {
        public Array InOrder(Node node)
        {
            List<Node> list = new List<Node>();

            InOrder(node.Left);
            list.Add(node);
            InOrder(node.Right);

            Node[] array = list.ToArray();
            return array;
        }
        public Array PostOrder(Node node)
        {
            List<Node> list = new List<Node>();

            PostOrder(node.Left);
            PostOrder(node.Right);
            list.Add(node);

            Node[] array = list.ToArray();
            return array;
        }
        public Array PreOrder(Node node)
        {
            List<Node> list = new List<Node>();

            list.Add(node);
            PreOrder(node.Left);
            PreOrder(node.Right);

            Node[] array = list.ToArray();
            return array;
        }
    }
}
