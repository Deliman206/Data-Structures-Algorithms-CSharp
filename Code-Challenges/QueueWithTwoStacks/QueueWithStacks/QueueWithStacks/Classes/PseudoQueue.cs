﻿using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.Classes;
using StacksQueues.Classes;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stacks load = new Stacks();
        public Stacks unload = new Stacks();
        /// <summary>
        /// Adds new node with input value to queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            while (unload.Peak() != null)
            {
                Node temp = unload.Pop();
                load.Push(temp);
            }
            load.Push(node);
        }/// <summary>
        /// Remove node from front of queue
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
            while (load.Peak() != null)
            {
                Node temp = load.Pop();
                unload.Push(temp);
            }

            return unload.Pop();
        }
    }
}
