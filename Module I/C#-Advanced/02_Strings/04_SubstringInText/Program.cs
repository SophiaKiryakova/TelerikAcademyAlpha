using System;
using System.Linq;

namespace _04_SubstringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var text = Console.ReadLine().ToLower().Split(new string[] { word }, StringSplitOptions.None);
            var count = text.Count() - 1;

            Console.WriteLine(count);
        }
    }
}