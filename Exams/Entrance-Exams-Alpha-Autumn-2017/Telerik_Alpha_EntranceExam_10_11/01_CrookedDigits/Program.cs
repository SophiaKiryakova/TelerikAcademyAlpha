using System;

namespace Telerik_Alpha_EntranceExam_10_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            while(n.Length > 1)
            {
                long result = 0;

                for(int i = 0; i < n.Length; i++)
                {
                    if (Char.IsDigit(n[i]))
                    {
                        result += int.Parse(n[i].ToString());
                    }
                }
                n = result.ToString();
            }
            Console.WriteLine(n);
        }
    }
}
