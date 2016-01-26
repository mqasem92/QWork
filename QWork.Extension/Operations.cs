using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWork.Extension
{
    public static class Operations
    {
        #region string

        //TODO: Test
        public static string RemoveWhiteSpaces(this string value)
        {
            var stringBuilder = new StringBuilder();
            foreach (var c in value)
            {
                switch (c)
                {
                    case '\r':
                    case '\n':
                    case '\t':
                        continue;
                    default:
                        stringBuilder.Append(c);
                        break;
                }
            }

            return stringBuilder.ToString();
        }

        //TODO: Test
        public static string ToHtmlMode(this string value)
        {
            return !string.IsNullOrEmpty(value) ? value.Replace(Environment.NewLine, "<br/>") : string.Empty;
        }

        #endregion
    }
}
