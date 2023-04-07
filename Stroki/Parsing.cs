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

        public static string CheckTypeSub(int countpoint, int countminus, byte[] asciiBytes, out string type)
        {
            int count = 0;
            for (int i = 0; i < asciiBytes.Length; i++)
                if (asciiBytes[i] >= 48 && asciiBytes[i] <= 57)
                    count++;
            if (countminus == 1 && asciiBytes[0] == 45) //для минуса
                if (count == asciiBytes.Length - 1)
                    type = "int";
                else if (count == asciiBytes.Length - 2 && countminus == 1)
                    type = "double";
                else
                    type = "string";
            else if (countminus == 0)
                if (count == asciiBytes.Length)
                    type = "int";
                else if (count == asciiBytes.Length - 1 && countpoint == 1 && asciiBytes[0] != 46 && asciiBytes[0] != 44)//код для запятой вместо 1
                    type = "double";
                else
                    type = "string";
            else
                type = "string";
            return type;
        }

        public static void Counter(byte[] asciiBytes, out int cm, out int cp)
        {
            int com = 0; int cop = 0;
            foreach (byte c in asciiBytes)
                if (c == 46 || c == 44)
                    cop++;
                else if (c == 45) //вместо единицы аски код для запятой нужно
                    com++;
            cm = com; cp = cop;
        }

        public static string CheckType(string s)
        {
            string type;
            int cp = 0; int cm = 0;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            int lenght = asciiBytes.Length;
            if (String.IsNullOrEmpty(s))
                type = "File is Empty".ToString();
            s = s.Trim();
            if (s.ToLower() == "false" || s.ToLower() == "true")
                type = "bool";
            else
            {
                Counter(asciiBytes, out cm, out cp);
                CheckTypeSub(cp, cm, asciiBytes, out type);
            }
            return type.ToString();
        }
        /// <summary>
        /// вспомогательная функция переводящая символы в целые числа
        /// </summary>
        /// <param name="letters">массив символов,состоящий из символов строки s</param>
        /// <param name="c">массив целых чисел</param>
        /// <param name="n">длина массива символов letters</param>
        /// <returns></returns>
        public static int CharToInt(int[] c1r, int l1, string s, string type)
        {
            int index = l1 + 1;
            int resint = 0;
            char[] letters = s.ToCharArray();
            if (type == "double")
                for (int i = 1; i < l1 + 1; i++)
                {
                    c1r[i] = (int)Char.GetNumericValue(letters[i - 1]);
                }
            for (int i = l1 + 1; i < letters.Length; i++)
            {
                c1r[index] = (int)Char.GetNumericValue(letters[index]);
                index++;
            }
            Array.Reverse(c1r);
            if (type == "int")
            {
                for (int i = 0; i < s.Length; i++)
                    c1r[i] = (int)Char.GetNumericValue(letters[i]);
                Array.Reverse(c1r);
                for (int i = 0; i < s.Length; i++)
                    resint += (int)(c1r[i] * Math.Pow(10, i));
            }
            return resint;
        }
        /// <summary>
        /// посимвольно переводим в int и переворачиваем строки
        /// </summary>
        /// <param name="c1r">массив</param>
        /// <param name="l">длина целой части строки</param>
        /// <param name="l1">длина дробной части строки</param>
        public static void CharToIntforDouble(int[] c1r, char[] l, int l1)
        {
            int index = l1 + 1;

            for (int i = 1; i < l1 + 1; i++)
            {
                c1r[i] = (int)Char.GetNumericValue(l[i - 1]);
            }
            for (int i = l1 + 1; i < l.Length; i++)
            {
                c1r[index] = (int)Char.GetNumericValue(l[index]);
                index++;
            }
            Array.Reverse(c1r);
        }
        /// <summary>
        /// вспомогательная функция,в которой мы получаем ответ ,конвертированный в double
        /// </summary>
        /// <param name="cr">массив</param>
        /// <param name="minus">флаг для отрицательного числа</param>
        /// <param name="l2">длина дробной части</param>
        /// <returns></returns>
        public static double Print(int[] cr, bool minus, int l2)
        {
            double result = 0;
            int n = cr.Length;
            for (int i = 0; i < n; i++)
                result += cr[i] * Math.Pow(10, i);
            double ans = result / Math.Pow(10, l2);
            if (minus)
                result = ans * (-1);
            else
                result = ans;
            return result;
        }
        /// <summary>
        /// основаная функция double,необходимая для конверта строки в double
        /// </summary>
        /// <param name="s">исходная строка</param>
        public static double CharToDouble(string s)
        {
            bool minus = false;
            if (s.Contains('-'))
                minus = true;
            s = s.Trim('-').Replace(',', '.');
            char[] letters = s.ToCharArray();
            int[] cr = new int[letters.Length];
            string[] parts = s.Split('.');
            int l1 = parts[0].Length;
            int l2 = parts[1].Length;
            CharToInt(cr, l1, s, "double");
            double res = Print(cr, minus, l2);
            return res;
        }


        /// <summary>
        /// метод,позволяющий конвертировать строку в другой тип
        /// </summary>
        /// <param name="s">строка</param>
        /// <param name="type">тип</param>
        /// <returns></returns>
        public static dynamic Converter(string s, string type)
        {
            dynamic result = 0;
            char[] letters = s.ToCharArray();
            int n = s.Length;
            int[] c = new int[n];
            if (type == "bool")
            {
                if (s.ToLower() == "true")
                    return true;
                else if (s.ToLower() == "false") return false;
            }
            if (type == "string")
                return s;
            if (type == "int")
                result = CharToInt(c, n, s, "int");
            if (type == "double")
                result = CharToDouble(s);
            return result;
        }
        /// <summary>
        /// вспомогательная фукция КМП для вычисления префикса функции
        /// </summary>
        /// <param name="s">строка</param>
        /// <returns></returns>
        public static int[] GetPrefix(string s)
        {
            int[] result = new int[s.Length];
            result[0] = 0;

            for (int i = 1; i < s.Length; i++)
            {
                int k = result[i - 1];
                while (s[k] != s[i] && k > 0)
                    k = result[k - 1];
                if (s[k] == s[i])
                    result[i] = k + 1;
                else
                    result[i] = 0;

            }
            return result;
        }
        /// <summary>
        /// эффективный алгоритм нахождения точек входа подстроки в строку
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="s">строка</param>
        /// <returns></returns>
        public static string FindSubstring(string pattern, string s)
        {
            int[] pf = GetPrefix(pattern);
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                while (index > 0 && pattern[index] != s[i])
                    index = pf[index - 1];
                if (pattern[index] == s[i])
                    index++;
                if (index == pattern.Length)
                    return $"{i - index + 1}";
            }
            return "";
        }
        //ещё один велосипед, заменяет подстрочку в строке на новую, учитывая количество вхождений подстроки(указывается пользователем)
        /// <summary>
        /// заменяет подстрочку в строке на новую, учитывая количество вхождений подстроки(указывается пользователем)
        /// </summary>
        /// <param name="s">Исходная строка</param>
        /// <param name="subString">Подстрока</param>
        /// <param name="newSubString">Новая подстрока</param>
        /// <param name="occurrences">Количество вхождений</param>
        /// <returns></returns>
        public static string SubStringReplace(string s,string subString,string newSubString,int occurrences = 1)
        {
            List<int> subStringIndexList = SlowSubStringSearch(s, subString);//KMPSearch(s, subString);
            if (subStringIndexList.Count/2<occurrences)
            {
                occurrences = subStringIndexList.Count/2;
            }
            Console.WriteLine(subStringIndexList[0]);
            s = SubStringDelete(s, subString, 1);
            s = SubStringInsert(s, newSubString, subStringIndexList[0]);
            for (int j = 2; j < occurrences * 2 - 1; j += 2)
            {
                Console.WriteLine(subStringIndexList[j]);
                s = SubStringDelete(s, subString, 1);
                s = SubStringInsert(s, newSubString, subStringIndexList[j]+(newSubString.Length- subString.Length));
            }
            return s;
        }
        //Удаляет подстроку с учётом введённого количества вхождений подстроки
        public static string SubStringDelete(string s, string subString,int occurrences)
        {
            string newString;
            List<int> subStringIndexList = SlowSubStringSearch(s, subString);//KMPSearch(s, subString); некич сделай кмп сёрч
            if (subStringIndexList.Count / 2 < occurrences)
            {
                occurrences = subStringIndexList.Count / 2;
            }
            for (int j = occurrences*2 - 1; j > 0; j -= 2) 
            {
                newString = "";
                for (int i = 0; i < subStringIndexList[j - 1]; i++)
                {
                    newString += s[i];
                }
                for (int i = subStringIndexList[j]+1;i<s.Length;i++)
                {
                    newString += s[i];
                }
                s = newString;
            }
            Console.WriteLine(s);
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
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    startIndex = i;
                    breakFlag = false;
                    for (int j = 0; j < subString.Length; j++)
                    {
                        if (subString[j] != s[j + i])
                        {
                            breakFlag = true;
                            break;
                        }
                        endIndex = j + i;
                    }
                    if (breakFlag == false)
                    {
                        subStringIndexList.Add(startIndex);
                        subStringIndexList.Add(endIndex);
                    }
                }
            }
            catch (Exception) { }
            return subStringIndexList;
        }

    }
}