using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWork.Extension
{
    /// <summary>
    /// Static Operation Class
    /// </summary>
    /// <createdOn>1/26/2016 10:00 AM</createdOn>
    public static class Operations
    {
        #region string

        /// <summary>
        /// Removes the white spaces.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:00 AM</createdOn>
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

        /// <summary>
        /// To the HTML mode.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:00 AM</createdOn>
        public static string ToHtmlMode(this string value)
        {
            return !string.IsNullOrEmpty(value) ? value.Replace(Environment.NewLine, "<br/>") : string.Empty;
        }

        #endregion
    }
}
