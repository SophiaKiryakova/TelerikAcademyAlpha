using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_11_AllPossiblePermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11. Write a program in C# to generate all possible permutations of an array using recursion.

            Console.WriteLine("Input the number of elements to store in the array [maximum 5 digits ]: ");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            
            for(int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            FindPermutations(arr, 0, n - 1);
        }

        private static void FindPermutations(int[] arr, int start, int end)
        {
            int i;
            if (start == end)
            {
                for (i = 0; i <= end; i++)
                {
                    Console.Write($"{arr[i]}");
                }
                Console.Write(" ");
            }
            else
            {
                for (i = start; i <= end; i++)
                {
                    SwapTwoNumber(ref arr[start], ref arr[i]);
                    FindPermutations(arr, start + 1, end);
                    SwapTwoNumber(ref arr[start], ref arr[i]);
                }
            }
        }
        private static void SwapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
