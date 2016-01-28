using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QWork.Extension.Arabic
{
    public static class Checking
    {
        /// <summary>
        /// Determines whether this instance is arabic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/28/2016 6:47 AM</createdOn>
        public static bool IsArabic(this string value)
        {
            if (String.IsNullOrEmpty(value))
                return false;

            const string pattern = @"^[ ءةآأ-ي\s]{2,}$";

            return Regex.IsMatch(value, pattern);
        }
    }
}
