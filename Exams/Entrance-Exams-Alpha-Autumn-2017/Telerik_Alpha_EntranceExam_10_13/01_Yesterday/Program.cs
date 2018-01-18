using System;

namespace Telerik_Alpha_EntranceExam_10_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            DateTime inputDate = new DateTime(year, month, day);
            DateTime resultDate = inputDate.AddDays(-1);
            Console.WriteLine(resultDate.ToString("d-MMM-yyyy"));
        }
    }
}
