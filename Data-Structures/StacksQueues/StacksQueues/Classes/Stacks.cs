using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.Classes;

namespace StacksQueues.Classes
{
    public class Stacks
    {
        public Node top { get; set; } = null;

        public void Push(Node node)
        {
            Node temp = top;
            top = node;
            node.Next = top;
        }
        public Node Pop()
        {
            try
            {
                Node temp = top;
                top = top.Next;
                return temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public Node Peak()
        {
            return top;
        }
    }
}
