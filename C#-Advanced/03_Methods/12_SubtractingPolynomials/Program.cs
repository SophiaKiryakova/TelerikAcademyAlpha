using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_SubtractingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var firstPolynomials = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondPolynomials = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var addedPolynomials = AddPolynomials(firstPolynomials, secondPolynomials, n);
            var substractedPolynomials = SubstractPolynomials(firstPolynomials, secondPolynomials, n);
            var multipliedPolynomials = MultiplicatePolynomials(firstPolynomials, secondPolynomials, n);
            Console.WriteLine(string.Join(" ", addedPolynomials));
            Console.WriteLine(string.Join(" ", substractedPolynomials));
            Console.WriteLine(string.Join(" ", multipliedPolynomials));
        }

        private static List<int> MultiplicatePolynomials(int[] firstPolynomials, int[] secondPolynomials, int n)
        {
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(firstPolynomials[i] * secondPolynomials[i]);
            }
            return list;
        }

        private static List<int> SubstractPolynomials(int[] firstPolynomials, int[] secondPolynomials, int n)
        {
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(firstPolynomials[i] - secondPolynomials[i]);
            }
            return list;
        }

        private static List<int> AddPolynomials(int[] firstPolynomials, int[] secondPolynomials, int n)
        {
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(firstPolynomials[i] + secondPolynomials[i]);
            }
            return list;
        }
    }
}
