using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_CokiSkoki
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var buildings = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            int i = 1;
            var queue = new Queue<int>();
            var stack = new Stack<int>();
            stack.Push(i);

            while (queue.Count < buildings.Length - 1)
            {
                int countJumps = 0;
                for (; i < buildings.Length; i++)
                {
                    if(buildings[index] < buildings[i])
                    {
                        countJumps++;
                        index = i;
                    }                   
                }
                queue.Enqueue(countJumps);
                index = stack.Peek();
                i = stack.Pop() + 1;
                stack.Push(i);
            }
            queue.Enqueue(0);
            Console.WriteLine("{0}\n{1}", queue.Max(), string.Join(" ", queue));
        }
    }
}
