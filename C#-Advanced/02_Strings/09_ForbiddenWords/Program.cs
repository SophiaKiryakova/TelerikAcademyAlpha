using System;
using System.Linq;

namespace _09_ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var forbidenWords = Console.ReadLine().Split().ToList();
            var text = Console.ReadLine();
            
            for(int i = 0; i < forbidenWords.Count; i++)
            {
                if (text.Contains(forbidenWords[i]))
                {
                    text = text.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
