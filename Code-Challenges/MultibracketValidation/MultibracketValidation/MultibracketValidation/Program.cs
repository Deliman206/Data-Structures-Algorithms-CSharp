using System;
using System.Linq;
using System.Collections.Generic;

namespace MultibracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check out me following the rules ;)");
            Console.WriteLine("this is true [{GOOOOOO}](Kona!!!)");
            Console.WriteLine(MultiBracketValidation("[{GOOOOOO}](Kona!!!)"));
            Console.WriteLine("this is false [{GOOOOOO)](Kona!!!}");
            Console.WriteLine(MultiBracketValidation("[{GOOOOOO)](Kona!!!}"));

            Console.Read();
        }

        public static bool MultiBracketValidation(string input)
        {
            Stack<char> stack = new Stack<char>();
            char[] inputChar = input.ToCharArray();

            char[] eventCharacters = { '[', '{', '(', ']', '}', ')' };
            var bracket = (open: '[', close: ']');
            var curled = (open: '{', close: '}');
            var parens = (open: '(', close: ')');

            for (int i = 0; i < inputChar.Length; i++)
            {
                if (!eventCharacters.Contains(inputChar[i])) continue;
                else if (inputChar[i] == bracket.close)
                {
                    try
                    {
                        char x = stack.Peek();
                        if (x == bracket.open)
                            stack.Pop();
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                }
                else if (inputChar[i] == curled.close)
                {
                    try
                    {
                        char x = stack.Peek();
                        if (x == curled.open)
                            stack.Pop();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else if (inputChar[i] == parens.close)
                {
                    try
                    {
                        char x = stack.Peek();
                        if (x == parens.open)
                            stack.Pop();
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                }
                else stack.Push(inputChar[i]);
            }
            try
            {
                stack.Pop();
            }
            catch (Exception)
            {
                return true;
            }
            return false;
        }
    }
}
