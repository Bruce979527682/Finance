using System;
using System.Collections.Generic;
using System.Text;

namespace Finance.Utils
{
    public class FieldHelper
    {
        public static string GetParseString(string value, string defaultStr)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return value.Trim();
            }
            return defaultStr;
        }

        public static int GetParseInt(string value, int defaultValue)
        {
            int num;
            int.TryParse(value, out num);
            if (num > 0)
            {
                return num;
            }
            return defaultValue;
        }
    }
}
