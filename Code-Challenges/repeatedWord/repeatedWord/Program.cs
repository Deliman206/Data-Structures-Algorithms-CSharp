using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace repeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string test = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";

            string word = MostRepeatedWord(test).Key;
            int count = MostRepeatedWord(test).Count;
            Console.WriteLine($"{word}, shows up {count} times");

            string word2 = RepeatedWord(test);
            Console.WriteLine($"{word2} is the first repeat");
            Console.Read();
        }
        public static string RepeatedWord(string word)
        {
            Hashtable t = new Hashtable();

            string pattern = @"([^a-zA-Z0-9_])";

            var words = word.Split(" ");
            foreach (string w in words)
            {
                string w1 = w;
                if (w1.Split(".").Length > 1)
                {
                    w1 = w1.Split(".")[0];
                }else
                if (w1.Split("?").Length > 1)
                {
                    w1 = w1.Split("?")[0];
                }else
                if (w1.Split(",").Length > 1)
                {
                    w1 = w1.Split(",")[0];
                }
                if (t.ContainsKey(w1.ToLower()))
                {
                    return w1;
                }
                t.Add(w1.ToLower(), 1);
            }
            return words[0];
        }
        public static (int Count, string Key) MostRepeatedWord(string word)
        {
            Hashtable m = new Hashtable();
            var s = word.Split(" ");

            int count = 0;
            string key = "";

            foreach(var character in s)
            {
                if (!m.ContainsKey(character.ToLower()))
                {
                    m.Add($"{character.ToLower() }", 1);
                    continue;
                }

                int value = Convert.ToInt32(m[character.ToLower()]);
                value += 1;
                m[character.ToLower()] = value;

                if (count < value)
                {
                    count = value;
                    key = character;
                }
            }
            return (Count:count, Key:key);
        }
    }
}
