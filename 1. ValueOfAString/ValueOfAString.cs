using System;
using System.Collections.Generic;
using System.Linq;

class ValueOfAString
{
    static void Main()
    {
        var text = Console.ReadLine();
        var upperOrLowerCase = Console.ReadLine();

        var sum = 0;

        foreach (var symbol in text)
        {
            if (upperOrLowerCase == "UPPERCASE")
            {
                if (char.IsLetter(symbol))
                {
                    if (char.IsUpper(symbol))
                    {
                        sum += symbol;
                    }
                }
            }
            else
            {
                if (char.IsLetter(symbol))
                {
                    if (char.IsLower(symbol))
                    {
                        sum += symbol;
                    }
                }
            }
        }

        Console.WriteLine($"The total sum is: {sum}");
    }
}

