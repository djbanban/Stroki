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
            int InsertionIndex = 1;
            int occurances = 10;
            Console.ForegroundColor = ConsoleColor.Green;
            string s = "abcdJIJAabcdJIJAabcd"; // "2/2";
            //Console.WriteLine(CheckType(s));
            string subString = "abcd";
            List<int> subStringIndexList = SlowSubStringSearch(s, subString);
            //subStringIndexList = SlowSubStringSearch(s, subString);
            s = SubStringDelete(s, subString, occurances);
            Console.WriteLine(s);
            //foreach (int subStringIndex in subStringIndexList)
            //{
                //Console.WriteLine(subStringIndex);
            //}
        }
    }
}