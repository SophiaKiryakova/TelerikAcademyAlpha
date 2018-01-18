using System;

namespace Practice_04_IndividualDigitsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Write a program in C# to display the individual digits of a given number using recursion. 

            Console.WriteLine("Enter a number N:");
            var n = Console.ReadLine();

            DisplayIndividualDigits(n, 0);
        }

        private static void DisplayIndividualDigits(string n, int index)
        {

            if(n.Length == index)
            {
                return;
            }
            else
            {
                Console.Write(n[index] + " ");
                index++;
                DisplayIndividualDigits(n, index);
            }
        }
    }
}
