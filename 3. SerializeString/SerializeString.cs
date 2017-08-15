using System;
using System.Collections.Generic;
using System.Linq;

class SerializeString
{
    static void Main()
    {
        var input = Console.ReadLine();
        var letters = new Dictionary<char, List<int>>();
        var currentIndex = -1;

        foreach (var symbol in input)
        {
            currentIndex = input.IndexOf(symbol, currentIndex + 1);

            if (!letters.ContainsKey(symbol))
            {
                letters[symbol] = new List<int>();
            }

            letters[symbol].Add(currentIndex);
        }

        foreach (var kvp in letters)
        {
            var letter = kvp.Key;
            var index = kvp.Value;

            Console.WriteLine($"{letter}:{string.Join("/", index)}");
        }
    }
}

