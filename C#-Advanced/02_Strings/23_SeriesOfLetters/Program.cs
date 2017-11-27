using System;
using System.Text;

namespace _23_SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var result = new StringBuilder();
            result.Append(text[0]);
            int index = 0;

            for (int i = 1; i < text.Length; i++)
            {
                if (result[index] != text[i])
                {
                    result.Append(text[i]);
                    index++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
