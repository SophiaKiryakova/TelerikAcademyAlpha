using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizesArrays = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var answer = CalculateSumOfArrays(sizesArrays, firstArray, secondArray);

            Console.WriteLine(string.Join(" ", answer));
        }

        private static List<int> CalculateSumOfArrays(int[] sizesArrays, int[] firstArray, int[] secondArray)
        {
            var answer = new List<int>();
            int remainder = 0;

            for(int i = 0; i < sizesArrays.Min(); i++)
            {
                var sum = firstArray[i] + secondArray[i] + remainder;
                remainder = 0;
                if (sum < 10)
                {
                    answer.Add(sum);
                }
                else
                {
                    answer.Add(sum % 10);
                    remainder = sum / 10;
                }
            }
            if(remainder > 0 && firstArray.Length == secondArray.Length)
            {
                answer.Add(remainder);
            }
            else if(firstArray.Length > secondArray.Length)
            {
                int secondRemainder = 0;
                for (int i = secondArray.Length; i < firstArray.Length; i++)
                { 
                    if (remainder > 0 && i == secondArray.Length)
                    {
                        if (remainder < 10)
                        {
                            answer.Add(firstArray[i] + remainder);
                        }
                        else
                        {
                            answer.Add(firstArray[i] + remainder % 10);
                            secondRemainder = remainder / 10;
                        }
                    }

                    else
                    {
                        answer.Add(firstArray[i] + secondRemainder);
                        secondRemainder = 0;
                    }
                   
                }
            }
            else if(firstArray.Length < secondArray.Length)
            {
                int secondRemainder = 0;

                for (int i = firstArray.Length; i < secondArray.Length; i++)
                {
                    if (remainder > 0 && i == firstArray.Length)
                    {
                        if (remainder < 10)
                        {
                            answer.Add(secondArray[i] + remainder);
                        }
                        else
                        {
                            answer.Add(secondArray[i] + remainder % 10);
                            secondRemainder = remainder / 10;
                        }
                    }
                    else
                    {
                        answer.Add(secondArray[i] + secondRemainder);
                        secondRemainder = 0;
                    }
                }
            }
            return answer;
        }
    }
}
