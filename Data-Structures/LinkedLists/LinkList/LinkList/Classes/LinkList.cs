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

        public void Insert(int value)
        {
            Node insertNode = new Node(value);
            Node temp = Head;
            Head = insertNode;
            Head.Next = temp;
        }
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
        public void Append(int value)
        {
            Node node = new Node(value);
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }
        public void InsertBefore(int value, int newValue)
        {
            Node node = new Node(newValue);
            Current = Head;
            while(Current.Next.Value != value)
            {
                if (Current == null)
                {
                    return;
                }
                Current = Current.Next;
            }
            node.Next = Current.Next;
            Current.Next = node;
        }
        public void InsertAfter(int value, int newValue)
        {
            Node node = new Node(newValue);
            Current = Head;
            while (Current.Value != value)
            {
                if (Current == null)
                {
                    return;
                }
                Current = Current.Next;
            }
            node.Next = Current.Next;
            Current.Next = node;
        }
    }
}
