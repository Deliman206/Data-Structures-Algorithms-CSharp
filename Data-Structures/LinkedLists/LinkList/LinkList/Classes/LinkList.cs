using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LList()
        {
            Head = null;
        }
        /// <summary>
        /// Takes the input value and makes a new Node and then adds to to the Head of the Linked List
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            Node insertNode = new Node(value);
            Node temp = Head;
            Head = insertNode;
            Head.Next = temp;
        }
        /// <summary>
        /// Takes input value and makes a new Node then checks if any node in the Linked List has a value of the input value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Either exists or does not</returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Prints the Linked List
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            if (Head == null)
            {
                return "NULL";
            }
            string printLinkedList = "";
            Current = Head;
            while (Current.Next != null)
            {
                printLinkedList += $"{Current.Value} -> ";
                Current = Current.Next;
            }
            printLinkedList += $"{Current.Value} -> NULL";
            return printLinkedList;
        }
        /// <summary>
        /// Takes the input value and makes a new Node then adds it to the end of the Linked List
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Node node = new Node(value);
            Current = Head;
            if (Head == null)
            {
                Head = node;
            } else
            {
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = node;
            }
        }
        /// <summary>
        /// Takes the input newValue and makes a new Node then inserts the node before the first Node with a value of input value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertBefore(int value, int newValue)
        {
            Node node = new Node(newValue);
            Current = Head;
            if (Head.Value == value)
            {
                Insert(newValue);
            }
            else
            {
                while(Current.Next != null)
                {
                    if (Current.Next.Value == value)
                    {
                        node.Next = Current.Next;
                        Current.Next = node;
                        return;
                    }
                    Current = Current.Next;
                }
            }
        }
        /// <summary>
        /// Takes the input newValue and makes a new Node then inserts the node after the first Node with a value of input value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertAfter(int value, int newValue)
        {
            Node node = new Node(newValue);
            Current = Head;
            if (Head.Value == value)
            {
                node.Next = Head.Next;
                Head.Next = node;
            }
            else
            {
                while(Current.Next != null)
                {
                    if (Current.Next.Value == value)
                    {
                        node.Next = Current.Next.Next;
                        Current.Next.Next = node;
                    }
                    Current = Current.Next;
                }
            }
        }
    }
}
