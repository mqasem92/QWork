using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QWork.Extension
{
    /// <summary>
    /// Static Checking Class
    /// </summary>
    /// <createdOn>1/26/2016 9:56 AM</createdOn>
    public static class Checking
    {
        #region Enumerable

        /// <summary>
        /// Determines whether this instance is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:56 AM</createdOn>
        public static bool IsNull<T>(this IEnumerable<T> value)
        {
            return value == null;
        }

        /// <summary>
        /// Determines whether [is null or empty].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:56 AM</createdOn>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> value)
        {
            return value == null || !value.Any() ? true : false;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:57 AM</createdOn>
        public static bool IsEmpty<T>(this IEnumerable<T> value)
        {
            return !value.Any() ? true : false;
        }

        #endregion

        #region Number

        /// <summary>
        /// Determines whether this instance is integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:57 AM</createdOn>
        public static bool IsInteger(this string value)
        {
            int number;
            return int.TryParse(value, out number);
        }

        /// <summary>
        /// Determines whether this instance is numeric.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:57 AM</createdOn>
        public static bool IsNumeric(this string value)
        {
            double number;
            return double.TryParse(value, out number);
        }

        /// <summary>
        /// Determines whether this instance has number.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:57 AM</createdOn>
        public static bool HasNumber(this string value)
        {
            return value.Any(char.IsDigit);
        }

        /// <summary>
        /// Determines whether this instance is odd.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:57 AM</createdOn>
        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        /// <summary>
        /// Determines whether this instance is even.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:57 AM</createdOn>
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        /// <summary>
        /// Determines whether [is larger than] [the specified compare value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="compareValue">The compare value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:57 AM</createdOn>
        public static bool IsLargerThan(this object value, object compareValue)
        {
            double number = value.ToDouble();
            double numberToCompare = compareValue.ToDouble();

            return number > numberToCompare ? true : false;
        }

        /// <summary>
        /// Determines whether [is larger than or equal] [the specified compare value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="compareValue">The compare value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        public static bool IsLargerThanOrEqual(this object value, object compareValue)
        {
            double number = value.ToDouble();
            double numberToCompare = compareValue.ToDouble();

            return number >= numberToCompare ? true : false;
        }

        /// <summary>
        /// Determines whether [is less than] [the specified compare value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="compareValue">The compare value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        public static bool IsLessThan(this object value, object compareValue)
        {
            double number = value.ToDouble();
            double numberToCompare = compareValue.ToDouble();

            return number < numberToCompare ? true : false;
        }

        /// <summary>
        /// Determines whether [is less than or equal] [the specified compare value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="compareValue">The compare value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        public static bool IsLessThanOrEqual(this object value, object compareValue)
        {
            double number = value.ToDouble();
            double numberToCompare = compareValue.ToDouble();

            return number <= numberToCompare ? true : false;
        }

        /// <summary>
        /// Determines whether the specified compare value is equal.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="compareValue">The compare value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        public static bool IsEqual(this int value, int compareValue)
        {
            return value == compareValue ? true : false;
        }

        /// <summary>
        /// Determines whether the specified compare value is equal.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="compareValue">The compare value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        public static bool IsEqual(this double value, double compareValue)
        {
            return value == compareValue ? true : false;
        }

        #endregion

        #region Guid

        /// <summary>
        /// Determines whether this instance is unique identifier.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        public static bool IsGuid(this string value)
        {
            const string guidRegEx =
                    @"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$";

            var regEx = new Regex(guidRegEx);

            return regEx.IsMatch(value.ToString());
        }

        #endregion

    }
}
