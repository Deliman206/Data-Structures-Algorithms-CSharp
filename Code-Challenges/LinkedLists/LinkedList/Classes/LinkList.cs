﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkList (Node node)
        {
            Head = node;
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
    }
}
