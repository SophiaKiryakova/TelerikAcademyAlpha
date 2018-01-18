using System;
using System.Collections.Generic;

namespace _04_LongestSubsequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{ 1, 2, 2, 3, 3, 3, 5, 7, 10, 10, 13 };
            List<int> longestSubsequence = new List<int>();
            List<int> currentSubsequence = new List<int>();

            currentSubsequence.Add(numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == currentSubsequence[0])
                {
                    currentSubsequence.Add(numbers[i]);
                }
                else
                {
                    if (currentSubsequence.Count > longestSubsequence.Count)
                    {
                        longestSubsequence.Clear();
                        longestSubsequence.AddRange(currentSubsequence);
                    }
                    currentSubsequence = new List<int>();
                    currentSubsequence.Add(numbers[i]);
                }
            }
            if (currentSubsequence.Count > longestSubsequence.Count)
            {
                longestSubsequence.Clear();
                longestSubsequence.AddRange(currentSubsequence);
            }
            Console.WriteLine(string.Join(" ", longestSubsequence));
        }
    }
}
