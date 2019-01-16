using System;
using LinkedList.Classes;

namespace LLKthFromTheEnd
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Kth From the End Challenge!");
        }
        public static int KthFromTheEnd(LList lL, int k)
        {
            try
            {
                int linkListLength = 0;
                lL.Current = lL.Head;

                while (lL.Current != null)
                {
                    linkListLength += 1;
                    lL.Current = lL.Current.Next;
                }

                lL.Current = lL.Head;
                if (linkListLength - k - 1 < 0)
                {
                    throw new Exception();
                }
                for (int i = 0; i < linkListLength - k - 1; i++)
                {
                    lL.Current = lL.Current.Next;
                }
                return lL.Current.Value;
            }
            catch (Exception)
            {
                Console.WriteLine("The linked list and K value do not work together. Use a K in the bounds of the linked list.");
                throw;
            }
            
        }
    }
}
