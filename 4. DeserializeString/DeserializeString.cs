using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DeserializeString
{
    static void Main()
    {
        var input = Console.ReadLine();

        var letters = new SortedDictionary<int, char>();

        while (input != "end")
        {
            var tokens = input.Split(new[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);
            var letter = char.Parse(tokens[0]);
            var indices = tokens.Skip(1).Select(int.Parse).ToList();

            foreach (var index in indices)
            {
                letters.Add(index, letter);
            }
            
            input = Console.ReadLine();
        }

        var stringResult = new StringBuilder();

        foreach (var kvp in letters)
        {
            var letter = kvp.Value;

            stringResult.Append(letter);
        }

        Console.WriteLine(stringResult.ToString());
    }
}

