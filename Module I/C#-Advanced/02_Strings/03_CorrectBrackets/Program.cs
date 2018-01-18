using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        { 
            // 77%
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            bool areBalanced = true;

            for(int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];
                if (symbol == '(')
                {
                    stack.Push(symbol);
                }
                if (symbol == ')')
                {
                    if (!stack.Any()) areBalanced = false;

                    else if (stack.Pop() != '(')
                    {
                        areBalanced = false;
                    }
                }
                if (!areBalanced) break;
            }
            if (areBalanced)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
