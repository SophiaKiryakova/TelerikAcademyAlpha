using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LCMGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12. Write a program in C# Sharp to find the LCM and GCD of two numbers using recursion.

            Console.WriteLine("Input first number: ");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            var secondNumber = int.Parse(Console.ReadLine());
            var listDivisors = new List<int>();

            FindGCDAndLCM(firstNumber, secondNumber, Math.Min(firstNumber, secondNumber));        
        }
        private static void FindGCDAndLCM(int firstNumber, int secondNumber, int divisor)
        {
            if(firstNumber % divisor == 0 && secondNumber % divisor == 0)
            {
                Console.WriteLine($"The GCD of {firstNumber} and {secondNumber} is {divisor}.");
                Console.WriteLine($"The LCM of {firstNumber} and {secondNumber} is {(firstNumber * secondNumber) / divisor}.");
                return;
            }
            divisor--;
            FindGCDAndLCM(firstNumber, secondNumber, divisor);
        }
    }
}
