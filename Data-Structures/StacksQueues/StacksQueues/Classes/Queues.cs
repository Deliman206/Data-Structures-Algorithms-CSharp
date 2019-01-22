using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.Classes;

namespace StacksQueues.Classes
{
    public class Queues
    {
        public Node front { get; set; } = null;
        public Node rear { get; set; } = null;

        public void Enqueue(Node node)
        {
            if (front == null)
            {
                front = node;
                rear = node;
                return;
            }
            rear.Next = node;
            rear = node;
        }
        public Node Dequeue()
        {
            try
            {
                Node dequeueNode = new Node(front.Value);
                front = front.Next;
                return dequeueNode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public Node Peak()
        {
            return front;
        }
    }
}
