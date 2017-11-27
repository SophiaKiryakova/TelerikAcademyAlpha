using System;
using System.Collections.Generic;

namespace _21_LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var dict = new Dictionary<char, int>();

            for(int i = 0; i < text.Length; i++)
            {
                var letter = text[i];

                if (Char.IsLetter(letter))
                {
                    if (!dict.ContainsKey(letter))
                    {
                        dict[letter] = 1;
                    }
                    else
                    {
                        dict[letter]++;
                    }
                }
            }
            foreach(var letter in dict)
            {
                Console.WriteLine("{0} -> {1} times", letter.Key, letter.Value);
            }
        }
    }
}
