using System;
using System.Collections.Generic;

namespace _03_CombinationsWithoutDuplicates
{
    class Program
    {
        static List<string> list;
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            var k = int.Parse(Console.ReadLine());
            list = new List<string>();

            int[] arr = new int[k];
            GetCombinations(arr, 0, 1, n);
            Console.WriteLine(string.Join(", ", list));
        }

        private static void GetCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                var str = "(";
                var areDifferent = true;

                for(int i = 0; i < arr.Length - 1; i++)
                {
                    if(arr[i] == arr[i + 1])
                    {
                        areDifferent = false;
                        break;
                    }
                }
                if (areDifferent)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i < arr.Length - 1)
                        {
                            str += arr[i] + " ";
                        }
                        else
                        {
                            str += arr[i] + ")";
                        }
                    }
                    list.Add(str);
                }
            }
            else
            {
                for(int i = 1; i <= end; i++)
                {
                    arr[index] = i;
                    GetCombinations(arr, index + 1, i, end);
                }
            }
        }
    }
}
