using System.Text;
using System.Threading.Channels;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Stroki
{
    public class Parsing 
    {

        const int ap = 46; // ascii point
        const int ans = 48; // ascii number start
        const int ane = 57; // ascii number end

        public static string CheckTypePositive(byte[] asciiBytes, string s, int lenght, string type)
        {
            int count = 0;
            for (int i = 0; i < lenght; i++)
                if (asciiBytes[i] >= ans && asciiBytes[i] <= ane)
                    count++;
            if (count == asciiBytes.Length && asciiBytes[0] != ans) // lenght - 1 тк один знак уходит на "-"
                type = "int";
            else if (count == lenght - 2 && asciiBytes[0] != ap && asciiBytes[lenght - 1] != ap && !s.Contains(' '))
                if (s.Contains('.') || s.Contains(','))
                    type = "double";
                else
                    type = "string";
            else
                type = "string";
            return type.ToString();
        }

        public static string CheckTypeNegative(byte[] asciiBytes, string s, int lenght, string type)
        {
            int count = 0;
            for (int i = 0; i < lenght; i++)
                if (asciiBytes[i] >= ans && asciiBytes[i] <= ane)
                    count++;
            if (count == asciiBytes.Length - 1 && asciiBytes[0] != ans && asciiBytes[lenght - 1] != 45) // lenght - 1 тк один знак уходит на "-"
                type = "int";
            else if (count == lenght - 2 && asciiBytes[0] != ap && asciiBytes[lenght - 1] != ap && !s.Contains(' ') && asciiBytes[0] == 45)
                if (s.Contains('.') || s.Contains(','))
                    type = "double";
                else
                    type = "string";
            else
                type = "string";
            return type.ToString();
        }

        public static string CheckType(string s, out string type1)
        {
            string type = "";
            if (String.IsNullOrEmpty(s))
                return type1 = "File is Empty".ToString();
            s = s.Trim();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            int lenght = asciiBytes.Length;
            if (s.ToLower() == "false" || s.ToLower() == "true")
                type = "bool";
            else if (s == "0")
                type = "int";
            else
            {
                if (!s.Contains('-'))
                    type = CheckTypePositive(asciiBytes, s, lenght, type);
                else
                    type = CheckTypeNegative(asciiBytes, s, lenght, type);
            }
            type1 = type;
            return type.ToString();
        }

        public static int[] CharToInt(char[] letters, int[] c, int n)
        {
            for (int i = 0; i < n; i++)
                c[i] = (int)Char.GetNumericValue(letters[i]);
            return c;
        }

        public static void CharToDouble(char[] letters, string s) //доделать тк он конвертируеь запятую в -1
        {
            s = s.Replace(',', '.');
            int n = s.Length;
            int[] c = new int[n];
            string[] strings = s.Split('.');
            Console.WriteLine(String.Join(" ", strings));
            for (int i = 0; i < n; i++)
            {
                c[i] = (int)Char.GetNumericValue(letters[i]);
            }
            Console.WriteLine(String.Join("", c).Replace('0', ','));
            return;
        }

        public static dynamic Converter(string s, string type)
        {
            //создание массива char элементов и заполнение его символами из строки
            char[] letters = s.ToCharArray();
            int n = letters.GetLength(0);
            int[] c = new int[n];
            Console.WriteLine(String.Join(" ", letters));
            if (type == "bool")
                return s.ToString();
            else if (type == "string")
                return s.ToString();
            else
                if (type == "int")
                CharToInt(letters, c, n);
            else
                CharToDouble(letters, s);
            string result = String.Join("", c);
            return result.ToString();
        }

        static void Main()
        {
            string? type1 = null;
            string s = "-1.2";
            Console.WriteLine($"Проверка типа данных: {CheckType(s, out type1)}");
            Console.WriteLine($"Конвертированная строка: {Converter(s, type1)}");
        }
        public static void KMPPrefix(string s)
        {

        }
        public static void KMPHelping()
        {

        }
        //основная kmp функция
        public static List<int> KMPSearch(string s, string subString)
        {
            //лист с индексами начала и конца подстрок(нужен для методов использующиъ поиск подстрок)
            List<int> subStringIndexList = new List<int>(); 

            return subStringIndexList;
        }
        //ещё один велосипед, заменяет подстрочку в строке на новую, учитывая количество вхождений подстроки(указывается пользователем)
        public static string SubStringReplace(string s,string subString,string newSubString,int occurrences)
        {
            List<int> subStringIndexList = KMPSearch(s, subString);
            if (subStringIndexList.Count/2<occurrences)
            {
                occurrences = subStringIndexList.Count/2;
            }
            return s;
        }
        public static string SubStringDelete(string s, string subString,int occurrences)
        {
            
            List<int> subStringIndexList = SlowSubStringSearch(s, subString);//KMPSearch(s, subString); некич сделай кмп сёрч
            if (subStringIndexList.Count / 2 < occurrences)
            {
                occurrences = subStringIndexList.Count / 2;
            }
            for (int j = subStringIndexList.Count; j >= 2; j -= 2)
            {
                s = s.Remove(subStringIndexList[j], subStringIndexList[j+1]-subStringIndexList[j] + 1);
            }
            return s;
        }
        //велосипед(String.Insert())
        public static string SubStringInsert(string s, string subString, int InsertionIndex)
        {
            string newString = "";
            for (int i = 0;i< InsertionIndex; i++)
            {
                newString += s[i];
            }
            for (int i = 0; i < subString.Length; i++)
            {
                newString += subString[i];
            }
            for (int i = InsertionIndex; i < s.Length; i++)
            {
                newString += s[i];
            }
            return newString;
        }

        //медленный поиск начальных и конечных индексов подстрок в строке (abccab, ab - 0,1;4,5) и запись их в лист
        public static List<int> SlowSubStringSearch(string s, string subString) 
        {
            List<int> subStringIndexList = new List<int>();
            int startIndex;
            int endIndex = 0;
            bool breakFlag;
            for (int i = 0;i<s.Length;i++)
            {
                startIndex = i;
                breakFlag = false;
                for (int j = 0;j<subString.Length;j++)
                {
                    if (subString[j] != s[j+i])
                    {
                        breakFlag = true;
                        break;
                    }
                    endIndex = j+i;
                }
                if (breakFlag == false)
                {
                    subStringIndexList.Add(startIndex);
                    subStringIndexList.Add(endIndex);
                }
            }
            return subStringIndexList;
        }

    }
}