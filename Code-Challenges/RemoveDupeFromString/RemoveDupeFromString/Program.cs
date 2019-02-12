using System;
using System.Collections.Generic;

namespace RemoveDupeFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{RemoveDupe("aabbcc")}");
            Console.Read();
        }

        public static string RemoveDupe(string line)
        {
            string result = ""; 
            foreach(char c in line)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
