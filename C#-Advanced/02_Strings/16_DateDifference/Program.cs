using System;
using System.Linq;

namespace _16_DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first date: ");
            var firstDate = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
            DateTime dateFirst = new DateTime(firstDate[2], firstDate[1], firstDate[0]);
            Console.Write("Enter the second date: ");
            var secondDate = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
            DateTime dateSecond = new DateTime(secondDate[2], secondDate[1], secondDate[0]);
            var difference = (dateSecond - dateFirst).TotalDays;
            Console.WriteLine("Distance: {0} days", difference);
        }
    }
}
