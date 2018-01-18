using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_14_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // 14. Write a program in C# Sharp to get the reverse of a string using recursion.

            Console.WriteLine("Enter a string: ");
            var input = Console.ReadLine();
            var newStr = "";
            ReverseString(input, newStr, input.Length - 1);
        }

        private static void ReverseString(string input, string newStr, int index)
        {
            if(newStr.Length == input.Length)
            {
                Console.WriteLine($"The reversed string is: {newStr}");
                return;
            }
            newStr += input[index];
            index--;
            ReverseString(input, newStr, index);
        }
    }
}
