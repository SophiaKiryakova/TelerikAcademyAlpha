using System;

namespace _02_Legs
{
    class Program
    {
        static void Main(string[] args)
        {
            int legs = int.Parse(Console.ReadLine());
            int combos = 0;

            for (int chicken = 0; chicken <= legs; chicken += 7)
            {
                for (int humans = 0; humans <= (legs - chicken); humans += 5)
                {
                    if ((legs - (humans + chicken)) % 2 == 0) combos++;
                }
            }
            Console.WriteLine(combos);
        }
    }
}
