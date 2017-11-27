using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var firstPolynomials = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondPolynomials = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var addedPolynomials = AddPolynomials(firstPolynomials, secondPolynomials, n);

            Console.WriteLine(string.Join(" ", addedPolynomials));
        }

        private static List<int> AddPolynomials(int[] firstPolynomials, int[] secondPolynomials, int n)
        {
            var list = new List<int>();

            for(int i = 0; i < n; i++)
            {
                list.Add(firstPolynomials[i] + secondPolynomials[i]);
            }
            return list;
        }
    }
}
