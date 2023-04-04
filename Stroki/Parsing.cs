using System.Text;
using System.Threading.Channels;

namespace Stroki
{
    public class Parsing
    {
        const int ap = 46; // ascii point
        const int ans = 48; // ascii number start
        const int ane = 57; // ascii number end
        public static string CheckType(string s, string type)
        {
            if (String.IsNullOrEmpty(s))
                return "File is Empty".ToString();
            s = s.Trim();
            int count = 0;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            int lenght = asciiBytes.Length;
            if (s.ToLower() == "false" || s.ToLower() == "true")
                type = "bool";
            else if (s == "0")
                type = "int";
            else
            {
                for (int i = 0; i < lenght; i++)
                    if (asciiBytes[i] >= ans && asciiBytes[i] <= ane)
                        count++;
                if (count == asciiBytes.Length && asciiBytes[0] != ans)
                    type = "int";
                else if (count == lenght - 1 && asciiBytes[0] != ap && asciiBytes[lenght - 1] != ap && !s.Contains(' '))
                {
                    if (s.Contains('.') || s.Contains(','))
                        type = "double";
                    else
                        type = "string";
                }
                else
                    type = "string";
            }
            return type.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        public static void Converting(string type) //сами жоский канвертир
        {
            if (type == "int")
                Convert.ToInt32(type).ToString();
            else if (type == "double")
                Convert.ToDouble(type).ToString();
            else if (type == "bool")
                Convert.ToBoolean(type).ToString();
            else
                type.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public static void KMPPrefix(string s)
        {

        }
        public static void KMPHelping()
        {

        }
    }
}