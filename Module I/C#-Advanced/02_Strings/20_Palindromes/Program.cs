using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var separators = new List<char>();

            for(int i = 0; i < text.Length; i++)
            {
                if (!Char.IsLetter(text[i]))
                {
                    separators.Add(text[i]);
                }
            }
            var arrayWords = text.Split(separators.ToArray()).ToArray();

            var sb = new StringBuilder();
            var palindromes = new List<string>();

            for(int i = 0; i < arrayWords.Length; i++)
            {
                var word = arrayWords[i];
                for(int j = word.Length - 1; j >= 0; j--)
                {
                    sb.Append(word[j]);
                }
                if(word == sb.ToString())
                {
                    palindromes.Add(word);
                }
                sb.Clear();
            }
            Console.WriteLine(string.Join(" ", palindromes));
        }
    }
}
