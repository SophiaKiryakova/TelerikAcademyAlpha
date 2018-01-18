using System;
using System.Linq;

namespace _24_OrderWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();
            words.Sort();

            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
