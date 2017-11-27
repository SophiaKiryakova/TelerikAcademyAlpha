using System;
using System.Collections.Generic;

namespace _14_WordDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var dict = new Dictionary<string, string>();

            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");

            Console.WriteLine(dict[word]);
        }
    }
}
