using System;
using System.Collections.Generic;
using System.Linq;

class Stateless
{
    static void Main()
    {
        var inputLine = Console.ReadLine();
        var fiction = Console.ReadLine();

        while (inputLine != "collapse")
        {
            while (fiction.Length > 0)
            {
                if (inputLine.Contains(fiction))
                {
                    inputLine = inputLine.Replace(fiction, "");
                }

                if (fiction.Length == 1)
                {
                    fiction = string.Empty;
                }
                else
                {
                    fiction = fiction.Substring(1, fiction.Length - 2);
                }                
            }

            if (inputLine == "")
            {
                Console.WriteLine("(void)");
            }
            else
            {
                Console.WriteLine(inputLine.Trim());
            }

            inputLine = Console.ReadLine();

            if (inputLine == "collapse")
            {
                return;
            }

            fiction = Console.ReadLine();
        }
    }
}

