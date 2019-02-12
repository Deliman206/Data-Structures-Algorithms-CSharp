using System;
using LinkedList.Classes;
namespace RemoveDupeFromLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList ll = new LList();

            ll.Insert(1);
            ll.Insert(2);
            ll.Insert(3);
            ll.Insert(1);
            
            Console.WriteLine(RemoveDupes(ll).Print());
            Console.Read();
        }
        public static LList RemoveDupes(LList ll)
        {
            int length = 0;
            Node curr = ll.Head;

            // Get length
            while (curr.Next != null)
            {
                length += 1;
                curr = curr.Next;
            }

            curr = ll.Head;
            //nfor each node of the LL we are going to hold one Node and make a copy
            // then traverse the copy looking for dupes

            while (curr.Next != null)
            {
                Node temp = curr;
                while(temp.Next.Next != null)
                {
                    if (temp.Next == curr)
                        temp.Next = temp.Next.Next;
                    temp = temp.Next;
                }
                curr = curr.Next;
            }

            return ll;
        }
    }
}
