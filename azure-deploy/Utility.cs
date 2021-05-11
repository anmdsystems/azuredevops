using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ngCodeGen
{
    public class Utility
    {
        public static string getDataType(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var temp = s.Trim().ToLower();
            if (temp == "date")
            {
                return "Date";
            }
            else
            {
                return temp;
            }
        }

        public static string TitleCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(s.Trim().ToLower()).Replace(" ", String.Empty);
        }

        public static string LowercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            char[] a = s.ToCharArray();
            a[0] = char.ToLower(a[0]);

            return new string(a);
        }
    }
}
