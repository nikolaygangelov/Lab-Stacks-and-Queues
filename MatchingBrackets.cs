using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
			string expression = Console.ReadLine();
			Stack<int> openBracketsInexes = new Stack<int>();

			
			for (int i = 0; i < expression.Length; i++)
			{
				char currentLetter = expression[i];
				
				if (currentLetter == '(')
				{
					openBracketsInexes.Push(i);
				}

				if (currentLetter == ')')
				{
						int openBracketIndex = openBracketsInexes.Pop();
					string subExpression = expression.Substring(openBracketIndex, i - openBracketIndex + 1);
                    Console.WriteLine(subExpression);
  			    }

			}
		}
    }
}
