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
            string type = "";
            Console.ForegroundColor = ConsoleColor.Green;
            string path = @"D:\progi\billig\stroki\test.txt";
            string s = " 2.2 ";
           
            Console.WriteLine(CheckType(s,type));

        }
    }
}