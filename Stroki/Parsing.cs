using System.Threading.Channels;

namespace Stroki
{
    public class Parsing
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string CheckType(string s, string type)
        {
            s = s.Trim();
            if (String.IsNullOrEmpty(s))
                return "пустой файл".ToString();
            bool isNumeric = int.TryParse(s, out _);
            bool isDouble = double.TryParse(s, out _);
            bool isBool = bool.TryParse(s, out _);
            if (isNumeric)
                type = "int";
            else if (isDouble && !s.Contains(' '))
                type = "double";
            else if (isBool)
                type = "bool";
            else
                type = "string";
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