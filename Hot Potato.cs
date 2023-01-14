using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine()
                .Split()
                .ToList();
     
            Queue<string> queue = new Queue<string>(kids);
            int n = int.Parse(Console.ReadLine());

            int tosses = 1;

            while ( queue.Count != 1)
            {
                string kid = queue.Dequeue();

                if (tosses < n)
                {
                    tosses++;
                    queue.Enqueue(kid);
                }
                else
                {
                    Console.WriteLine($"Removed {kid}");
                    tosses = 1;
                }

            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
