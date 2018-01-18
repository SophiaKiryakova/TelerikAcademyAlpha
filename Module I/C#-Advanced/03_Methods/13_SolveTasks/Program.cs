using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_SolveTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, choose a task and type its corresponding number. Your options are:");
            Console.WriteLine("1 Reverse the digits of a number");
            Console.WriteLine("2 Calculates the average of a sequence of integers");
            Console.WriteLine("3 Solves a linear equation");
            var usersChoice = int.Parse(Console.ReadLine());

            switch (usersChoice)
            {
                case 1:
                    Console.WriteLine("Please, provide a non-negative number: ");
                    var input = decimal.Parse(Console.ReadLine());
                    while(input < 0)
                    {
                        Console.WriteLine("Please, provide a non-negative number: ");
                        input = decimal.Parse(Console.ReadLine());
                    }
                    var numberToList = input.ToString().ToList();
                    numberToList = ReverseDigitsOfNumber(numberToList);
                    Console.WriteLine(string.Join("", numberToList));
                    break;
                case 2:
                    Console.WriteLine("Please, provide a non-empty number sequence: ");
                    var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
                    while(sequence.Count == 0)
                    {
                        Console.WriteLine("Please, provide a non-empty number sequence: ");
                        sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
                    }
                    var average = FindAverageInSequence(sequence);
                    Console.WriteLine(average);
                    break;
                case 3:
                    Console.WriteLine("Please, provide a linear equation coefficients (on three lines), where a is not equal to 0: ");
                    Console.Write("a = ");
                    int a = int.Parse(Console.ReadLine());
                    while(a == 0)
                    {
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                    }
                    Console.Write("x = ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    int b = int.Parse(Console.ReadLine());
                    int result = CalculateLinearEquasion(a, x, b);
                    Console.WriteLine(result);
                    break;
            }
        }

        private static int CalculateLinearEquasion(int a, int x, int b)
        {
            int result = a * x + b;
            return result;
        }

        private static double FindAverageInSequence(List<int> sequence)
        {
            return sequence.Average();
        }

        private static List<char> ReverseDigitsOfNumber(List<char> numberToList)
        {
            numberToList.Reverse();

            return numberToList;
        }
    }
}
