using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().ToList();
            var answer = ReverseDigitsOfNumber(number);
            Console.WriteLine(string.Join("", answer));
        }

        private static List<char> ReverseDigitsOfNumber(List<char> number)
        {
            number.Reverse();
            return number;
        }
    }
}
