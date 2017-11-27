using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _19_DatesFromTextInCanada
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\d{2}).(\d{2}).(\d{4})");
            var text = Console.ReadLine();
            MatchCollection matches = regex.Matches(text);
            var pattern = "yyyy-MM-dd";
            foreach(Match match in matches)
            {
                var year = int.Parse(match.Groups[3].Value);
                var month = int.Parse(match.Groups[2].Value);
                var day = int.Parse(match.Groups[1].Value);
                DateTimeFormatInfo formatInfo = (new CultureInfo("en-CA")).DateTimeFormat;
                DateTime date = new DateTime(year, month, day);
                Console.WriteLine(date.ToString(pattern));
            }
        }
    }
}
