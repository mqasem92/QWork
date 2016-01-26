using System;
using System.Globalization;
using System.Text;

namespace QWork.Extension.Arabic
{
    /// <summary>
    /// Static Convertor For Arabic
    /// </summary>
    /// <createdOn>1/26/2016 10:04 AM</createdOn>
    public static class Converter
    {
        /// <summary>
        /// To the string with arabic numbers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:04 AM</createdOn>
        public static string ToStringWithArabicNumbers(this int input, string format = null, IFormatProvider formatProvider = null)
        {
            string str;
            if (format == null && formatProvider == null)
            {
                str = input.ToString();
            }
            else if (format == null)
            {
                str = input.ToString(formatProvider);
            }
            else if (formatProvider == null)
            {
                str = input.ToString(format);
            }
            else
            {
                str = input.ToString(format, formatProvider);
            }

            return str.ToStringWithArabicNumbers();
        }

        /// <summary>
        /// To the string with arabic numbers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:04 AM</createdOn>
        public static string ToStringWithArabicNumbers(this decimal input, string format = null, IFormatProvider formatProvider = null)
        {
            string str;
            if (format == null && formatProvider == null)
            {
                str = input.ToString(CultureInfo.InvariantCulture);
            }
            else if (format == null)
            {
                str = input.ToString(formatProvider);
            }
            else if (formatProvider == null)
            {
                str = input.ToString(format);
            }
            else
            {
                str = input.ToString(format, formatProvider);
            }

            return str.ToStringWithArabicNumbers();
        }

        /// <summary>
        /// To the string with arabic numbers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:04 AM</createdOn>
        public static string ToStringWithArabicNumbers(this double input, string format = null, IFormatProvider formatProvider = null)
        {
            string str;
            if (format == null && formatProvider == null)
            {
                str = input.ToString(CultureInfo.InvariantCulture);
            }
            else if (format == null)
            {
                str = input.ToString(formatProvider);
            }
            else if (formatProvider == null)
            {
                str = input.ToString(format);
            }
            else
            {
                str = input.ToString(format, formatProvider);
            }

            return str.ToStringWithArabicNumbers();
        }

        /// <summary>
        /// To the string with arabic numbers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:04 AM</createdOn>
        public static string ToStringWithArabicNumbers(this short input, string format = null, IFormatProvider formatProvider = null)
        {
            string str;
            if (format == null && formatProvider == null)
            {
                str = input.ToString();
            }
            else if (format == null)
            {
                str = input.ToString(formatProvider);
            }
            else if (formatProvider == null)
            {
                str = input.ToString(format);
            }
            else
            {
                str = input.ToString(format, formatProvider);
            }

            return str.ToStringWithArabicNumbers();
        }

        /// <summary>
        /// To the string with arabic numbers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:05 AM</createdOn>
        public static string ToStringWithArabicNumbers(this float input, string format = null, IFormatProvider formatProvider = null)
        {
            string str;
            if (format == null && formatProvider == null)
            {
                str = input.ToString(CultureInfo.InvariantCulture);
            }
            else if (format == null)
            {
                str = input.ToString(formatProvider);
            }
            else if (formatProvider == null)
            {
                str = input.ToString(format);
            }
            else
            {
                str = input.ToString(format, formatProvider);
            }

            return str.ToStringWithArabicNumbers();
        }

        /// <summary>
        /// To the string with arabic numbers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:05 AM</createdOn>
        public static string ToStringWithArabicNumbers(this DateTime input, string format = null, IFormatProvider formatProvider = null)
        {
            string str;
            if (format == null && formatProvider == null)
            {
                str = input.ToString(CultureInfo.InvariantCulture);
            }
            else if (format == null)
            {
                str = input.ToString(formatProvider);
            }
            else if (formatProvider == null)
            {
                str = input.ToString(format);
            }
            else
            {
                str = input.ToString(format, formatProvider);
            }

            return str.ToStringWithArabicNumbers();
        }

        /// <summary>
        /// To the string with arabic numbers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:05 AM</createdOn>
        public static string ToStringWithArabicNumbers(this byte input, string format = null, IFormatProvider formatProvider = null)
        {
            string str;
            if (format == null && formatProvider == null)
            {
                str = input.ToString(CultureInfo.InvariantCulture);
            }
            else if (format == null)
            {
                str = input.ToString(formatProvider);
            }
            else if (formatProvider == null)
            {
                str = input.ToString(format);
            }
            else
            {
                str = input.ToString(format, formatProvider);
            }

            return str.ToStringWithArabicNumbers();
        }

        /// <summary>
        /// To the string with arabic numbers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:05 AM</createdOn>
        public static string ToStringWithArabicNumbers(this string input)
        {
            var utf8Encoder = new UTF8Encoding();
            var utf8Decoder = utf8Encoder.GetDecoder();
            var convertedChars = new StringBuilder();
            var convertedChar = new char[1];
            byte[] bytes = { 217, 160 };
            var inputCharArray = input.ToCharArray();
            foreach (var c in inputCharArray)
            {
                if (char.IsDigit(c))
                {
                    bytes[1] = Convert.ToByte(160 + char.GetNumericValue(c));
                    utf8Decoder.GetChars(bytes, 0, 2, convertedChar, 0);
                    convertedChars.Append(convertedChar[0]);
                }
                else
                {
                    convertedChars.Append(c);
                }
            }

            return convertedChars.ToString();
        }
    }
}
