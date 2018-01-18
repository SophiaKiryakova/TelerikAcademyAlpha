using System;
using System.Collections.Generic;

namespace _04_BracketsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    stack.Push(i);
                }
                if(input[i] == ')')
                {
                    var startIndex = stack.Pop();
                    var endEndex = i;
                    Console.WriteLine(input.Substring(startIndex, endEndex - startIndex + 1));
                }
            }
        }
    }
}
