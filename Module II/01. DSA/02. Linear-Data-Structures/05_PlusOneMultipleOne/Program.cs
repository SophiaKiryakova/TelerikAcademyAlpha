using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_PlusOneMultipleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var n = numbers[0];
            var m = numbers[1];
            var s = n;
            var queue = new Queue<long>();
            queue.Enqueue(s);
            int skip = 0;

            for (int i = 0; i < m - 1; i++)
            {
                switch (i % 3)
                {
                    case 0:
                        s = queue.ToArray().Skip(skip).Take(1).ToArray()[0];
                        queue.Enqueue(s + 1);
                        skip++;
                        break;
                    case 1:
                        queue.Enqueue((2 * s + 1));
                        break;
                    case 2:
                        queue.Enqueue(s + 2);
                        break;
                    default:
                        break;
                }
            }
            var stack = new Stack<long>(queue);
            Console.WriteLine(stack.Peek());
        }
    }
}
