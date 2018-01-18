using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_ReverseIntegerOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse);
            var stack = new Stack<int>(numbers);

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
