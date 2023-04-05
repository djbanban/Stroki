using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using static Stroki.Parsing;

namespace ParseStroki
{
    class ParseStroki
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string s = "222.5";
            Converter(s, "double");

        }
    }
}