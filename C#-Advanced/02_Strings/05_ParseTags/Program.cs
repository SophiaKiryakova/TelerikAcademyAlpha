using System;
using System.Text.RegularExpressions;
using System.Text;
namespace _05_ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Regex regex = new Regex("<upcase>(.*?)</upcase>");           
            var sb = new StringBuilder();

            for(int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]);
            }
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                sb.Replace(match.ToString(), match.Groups[1].Value.ToUpper());
            }
            Console.WriteLine(sb);
        }
    }
}
