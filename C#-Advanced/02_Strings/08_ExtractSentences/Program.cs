using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _08_ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            string text = Console.ReadLine();
            var sb = new StringBuilder();

            var sentences = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var separators = new HashSet<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsLetter(text[i]) && text[i] != '.')
                {
                    separators.Add(text[i]);
                }
            }
            separators.Distinct();

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(inputWord))
                {
                    var words = sentences[i].Split(separators.ToArray()).ToArray();

                    for (int j = 0; j < words.Length; j++)
                    {
                        if (words[j] == inputWord)
                        {
                            sb.Append(sentences[i].Trim() + ". ");
                        }
                    }
                }
            }
            for(int i = 0; i < sb.Length; i++)
            {
                if(i == sb.Length - 1)
                {
                    Console.Write(sb[i].ToString().Trim());
                }
                else
                {
                    Console.Write(sb[i]);
                }
            }
        }
    }
}