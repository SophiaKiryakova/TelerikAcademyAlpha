using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { '.', ',', ' ', '-', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                var word = text[i];

                if (!dict.ContainsKey(word))
                {
                    dict[word] = 1;
                }
                else
                {
                    dict[word]++;
                }
            }
            foreach (var letter in dict)
            {
                Console.WriteLine("{0} -> {1} times", letter.Key, letter.Value);
            }
        }
    }
}
