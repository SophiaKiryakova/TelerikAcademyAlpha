using System;

namespace Telerik_OOP_03_Principles_Part_02_RangeExceptions
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // First we will ask for the numbers
            Console.WriteLine("Please, enter a number in the range between 0 and 100.");
            int start = 0;
            int end = 100;

            try
            {
                int input = int.Parse(Console.ReadLine());

                if(input < start || input > end)
                {
                    throw new InvalidRangeException<int>(start, end, "Invalid number!");
                }
                else
                {
                    Console.WriteLine($"The number {input} is in the range!");
                }
            }
            catch(InvalidRangeException<int> exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            
            // Now we can do the tests for the date. First we add the start and end dates and we ask the user to enter the date he/she wants.
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);
            Console.WriteLine("\nPlease, enter a date in the format year.month.day:");

            try
            {
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                if(date < startDate || date > endDate)
                {
                    throw new InvalidRangeException<DateTime>(startDate, endDate, "Invalid date!");
                }
                else
                {
                    Console.WriteLine($"Your date: {date} is valid!");
                }
            }
            catch(InvalidRangeException<DateTime> exeption)
            {
                Console.WriteLine(exeption.Message);
            }
        }
    }
}
