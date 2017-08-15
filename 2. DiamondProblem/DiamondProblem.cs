using System;
using System.Collections.Generic;
using System.Linq;

class DiamondProblem
{
    static void Main()
    {
        var input = Console.ReadLine();

        var leftIndex = -1;
        var rightIndex = -1;
        var isFound = false;

        while ((leftIndex = input.IndexOf('<', leftIndex + 1)) > -1 
            && (rightIndex = input.IndexOf('>', leftIndex + 1)) > -1)
        {
            var diamondContent = input.Substring(leftIndex + 1, rightIndex - leftIndex - 1);
            var carats = FindCarats(diamondContent);
           
            Console.WriteLine($"Found {carats} carat diamond");

            isFound = true;    
        }

        if (!isFound)
        {
            Console.WriteLine("Better luck next time");
        }
    }

    private static int FindCarats(string diamondContent)
    {
        var carats = 0;

        foreach (var symbol in diamondContent)
        {
            if (char.IsDigit(symbol))
            {
                carats += symbol - '0';
            }
        }

        return carats;
    }
}

