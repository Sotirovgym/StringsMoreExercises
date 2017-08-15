using System;
using System.Collections.Generic;
using System.Linq;

class Nilapdromes
{
    static void Main()
    {
        var input = Console.ReadLine();

        while (input != "end")
        {
            var nilapdrome = ReturnNilapdrome(input);

            if (nilapdrome != "")
            {
                Console.WriteLine(nilapdrome);
            }

            input = Console.ReadLine();
        }
    }

    private static string ReturnNilapdrome(string input)
    {
        var middleIndex = input.Length / 2;

        var border = string.Empty;
        var leftIndex = 0;

        for (int i = middleIndex + 1; i < input.Length; i++)
        {
            if (input[leftIndex] == input[i])
            {
                border += input[i];
                leftIndex++;
            }
            else
            {
                border = string.Empty;
                leftIndex = 0;

                if (input[i] == input[leftIndex])
                {
                    border += input[i];
                    leftIndex++;    
                }
            }
        }

        if (border != "")
        {
            var left = input.IndexOf(border);
            var right = input.LastIndexOf(border);

            var middle = input.Substring(left + border.Length, input.Length - border.Length * 2);

            if (middle != "")
            {
                return middle + border + middle;
            }
        }

        return "";
    }
}

