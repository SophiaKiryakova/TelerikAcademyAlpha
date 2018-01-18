using System;
using System.Globalization;

namespace _17_DateInBulgarian
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialDate = Console.ReadLine().Split('.', ':', ' ');
            int day = int.Parse(initialDate[0]);
            int month = int.Parse(initialDate[1]);
            int year = int.Parse(initialDate[2]);
            int hour = int.Parse(initialDate[3]);
            int min = int.Parse(initialDate[4]);
            int sec = int.Parse(initialDate[5]);
            DateTime date = new DateTime(year, month, day, hour, min, sec);
            DateTime newDate = date.AddMinutes(390);
            string pattern = "dd.MM.yyyy hh:mm:ss";
            Console.Write(newDate.ToString(pattern) + " ");
            Console.WriteLine(newDate.ToString("ddd", new CultureInfo("bg-BG")));
        }
    }
}
