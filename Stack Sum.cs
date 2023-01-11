using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Stack<int> stack = new Stack<int>(list);

            string command = string.Empty;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] inputParameters = command.Split();
                string commandType = inputParameters[0];


                if (commandType == "add")
                {
                    int number1 = int.Parse(inputParameters[1]);
                    int number2 = int.Parse(inputParameters[2]);

                    stack.Push(number1);
                    stack.Push(number2);

                }
                else if (commandType == "remove")
                {
                    int n = int.Parse(inputParameters[1]);


                    for (int i = 0; i < n; i++)
                    {
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        stack.Pop();
                    }

                }

            }
            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}
