using System;
using System.Collections;
using System.Collections.Generic;

namespace TreeIntersectionChallenege
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node t1 = new Node(1);
            Node one1 = new Node(1);
            Node two1 = new Node(1);
            Node three1 = new Node(1);
            Node four1 = new Node(1);
            Node five1 = new Node(1);
            Node six1 = new Node(1);

            t1.Left = one1;
            one1.Left = three1;
            one1.Right = four1;
            t1.Right = two1;
            two1.Left = five1;
            two1.Right = six1;

            Node t2 = new Node(2);
            Node one2 = new Node(2);
            Node two2 = new Node(2);
            Node three2 = new Node(2);
            Node four2 = new Node(2);
            Node five2 = new Node(2);
            Node six2 = new Node(2);

            t2.Left = one2;
            one2.Left = three2;
            one2.Right = four2;
            t2.Right = two2;
            two2.Left = five2;
            two2.Right = six2;

            foreach (var item in TreeIntersection(t1, t2))
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }
        public static List<int> TreeIntersection(Node treeOne, Node treeTwo)
        {
            Hashtable ht = new Hashtable();
            Queue q = new Queue();
            List<int> list = new List<int>();

            q.Enqueue(treeOne);
            while(q.Count > 0)
            {
                Object x = q.Dequeue();
                Node node = x as Node;
                
                if(!ht.Contains(node.Value))
                    ht.Add(node.Value, true);

                if (node.Left != null)
                    q.Enqueue(node.Left);
                if (node.Right != null)
                    q.Enqueue(node.Right);

            }
            q.Enqueue(treeTwo);
            while (q.Count > 0)
            {
                Object x = q.Dequeue();
                Node node = x as Node;

                if (ht.Contains(node.Value) && !list.Contains(node.Value))
                    list.Add(node.Value);

                if (node.Left != null)
                    q.Enqueue(node.Left);
                if (node.Right != null)
                    q.Enqueue(node.Right);
            }
            return list;
        }
    }
}
