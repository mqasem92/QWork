using System;
using System.IO;
using System.Text;
using QWork.Core.Enum;

namespace QWork.Extension
{
    /// <summary>
    /// Static Operation Class
    /// </summary>
    /// <createdOn>1/26/2016 10:00 AM</createdOn>
    public static class Operations
    {
        #region convert digital size

        /// <summary>
        /// Convert digital size To the byte.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="sizeSuffixes">The size suffixes.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 11:19 AM</createdOn>
        /// <exception cref="System.ArgumentOutOfRangeException">null</exception>
        public static long ToByte(this long value, SizeSuffixes sizeSuffixes)
        {
            switch (sizeSuffixes)
            {
                case SizeSuffixes.Bytes:
                    break;
                case SizeSuffixes.KB:
                    value = value * 1024;
                    break;
                case SizeSuffixes.MB:
                    value = value * 1024 * 1024;
                    break;
                case SizeSuffixes.GB:
                    value = value * 1024 * 1024 * 1024;
                    break;
                case SizeSuffixes.TB:
                    value = value * 1024 * 1024 * 1024 * 1024;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(sizeSuffixes), sizeSuffixes, null);
            }

            return value;
        }

        #endregion

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

        /// <summary>
        /// Gets the file extension without (dot).
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 1:08 PM</createdOn>
        public static string GetSimpleFileExtension(this string value)
        {
            return value.GetFileExtension().Replace(".", "");
        }

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 1:16 PM</createdOn>
        public static string GetFileExtension(this string value)
        {
            var extension = Path.GetExtension(value);

            return extension != null ? extension : value;
        }

        /// <summary>
        /// Gets the name of the file name without (dot).
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 1:10 PM</createdOn>
        public static string GetSimpleFileName(this string value)
        {
            return Path.GetFileNameWithoutExtension(value);
        }

        #endregion
    }
}
