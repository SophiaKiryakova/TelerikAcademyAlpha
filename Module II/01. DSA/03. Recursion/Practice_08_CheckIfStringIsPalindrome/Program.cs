using System;

namespace Practice_08_CheckIfStringIsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Write a program in C# Sharp to Check whether a given String is Palindrome or not using recursion.
            Console.WriteLine("Enter a string:");
            var n = Console.ReadLine();

            FindIfStringIsPalindrome(n, 0, n.Length - 1);
        }

        private static void FindIfStringIsPalindrome(string n, int start, int end)
        {
            if(start >= end)
            {
                Console.WriteLine($"{n} is a Palindrome");
                return;
            }
            if(n[start] != n[end])
            {
                Console.WriteLine($"{n} is NOT a Palindrome");
                return;
            }
            else
            {
                start++;
                end--;
                FindIfStringIsPalindrome(n, start, end);
            }
        }
    }
}
