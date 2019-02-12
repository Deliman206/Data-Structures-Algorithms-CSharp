using System;

namespace UniqueCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{AreCharactersUnique("Kona")}");
            Console.WriteLine($"{AreCharactersUnique("Sean")}");
            Console.WriteLine($"{AreCharactersUnique("Sean and Kona")}");
            Console.Read();

        }
        static public bool AreCharactersUnique(string input)
        {
            input = input.ToLower();
            char[] array = input.ToCharArray();
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                if( (i+1) != array.Length)
                    if (array[i] == array[i + 1])
                        return false;
            }
            return true;
        }
    }
}
