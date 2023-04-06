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
            int occurances = 2;
            Console.ForegroundColor = ConsoleColor.Green;
            string s = "abcdJIJAabcdJIJAabcd"; // "2/2";
            //Console.WriteLine(CheckType(s));
            string subString = "abcd";
            string newSubString = "CHECK";
            List<int> subStringIndexList = SlowSubStringSearch(s, subString);
            //subStringIndexList = SlowSubStringSearch(s, subString);
            s = SubStringReplace(s, subString, newSubString, occurances);
            Console.WriteLine(s);
            //foreach (int subStringIndex in subStringIndexList)
            //{
                //Console.WriteLine(subStringIndex);
            //}
            //string s = "222.5";
            //Converter(s, "double");
        }
    }
}