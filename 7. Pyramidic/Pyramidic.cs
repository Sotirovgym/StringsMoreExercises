using System;
using System.Collections.Generic;
using System.Linq;

class Pyramidic
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var lines = new string[n];
        var pyramid = new List<string>();

        for (int i = 0; i < n; i++)
        {
            lines[i] = Console.ReadLine();
        }

        FindPyramid(lines, pyramid);

        Console.WriteLine(pyramid.OrderByDescending(x => x.Length).First());

    }

    private static void FindPyramid(string[] lines, List<string> pyramid)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            var currentLine = lines[i];

            for (int j = 0; j < currentLine.Length; j++)
            {
                var currentCharacter = currentLine[j];
                var count = 1;
                var currentPyramid = string.Empty;

                for (int k = i; k < lines.Length; k++)
                {
                    var currentCount = new string(currentCharacter, count);

                    if (lines[k].Contains(currentCount))
                    {
                        currentPyramid += currentCount + Environment.NewLine;
                    }
                    else
                    {
                        break;
                    }

                    count += 2;
                }

                pyramid.Add(currentPyramid.Trim());
            }
        }
    }
}

