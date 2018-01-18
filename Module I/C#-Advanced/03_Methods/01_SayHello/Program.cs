using System;

namespace Telerik_03_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            PrintGreeting(name);
        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
