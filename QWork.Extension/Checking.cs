using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QWork.Extension
{
    public static class Checking
    {
        #region Enumerable

        //TODO:Test
        public static bool IsNull<T>(this IEnumerable<T> value)
        {
            return value == null;
        }

        //TODO:Test
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> value)
        {
            return value == null || !value.Any() ? true : false;
        }

        //TODO:Test
        public static bool IsEmpty<T>(this IEnumerable<T> value)
        {
            return !value.Any() ? true : false;
        }

        #endregion

        #region Number

        //TODO: Test
        public static bool IsInteger(this string value)
        {
            int number;
            return int.TryParse(value, out number);
        }

        //TODO: Test
        public static bool IsNumeric(this string value)
        {
            double number;
            return double.TryParse(value, out number);
        }

        //TODO: Test
        public static bool HasNumber(this string value)
        {
            return value.Any(char.IsDigit);
        }

        //TODO: Test
        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        //TODO: Test
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool IsLargerThan(this object value, object compareValue)
        {
            double number = value.ToDouble();
            double numberToCompare = compareValue.ToDouble();

            return number > numberToCompare ? true : false;
        }

        public static bool IsLargerThanOrEqual(this object value, object compareValue)
        {
            double number = value.ToDouble();
            double numberToCompare = compareValue.ToDouble();

            return number >= numberToCompare ? true : false;
        }

        public static bool IsLessThan(this object value, object compareValue)
        {
            double number = value.ToDouble();
            double numberToCompare = compareValue.ToDouble();

            return number < numberToCompare ? true : false;
        }

        public static bool IsLessThanOrEqual(this object value, object compareValue)
        {
            double number = value.ToDouble();
            double numberToCompare = compareValue.ToDouble();

            return number <= numberToCompare ? true : false;
        }

        public static bool IsEqual(this int value, int compareValue)
        {
            return value == compareValue ? true : false;
        }

        public static bool IsEqual(this double value, double compareValue)
        {
            return value == compareValue ? true : false;
        }

        #endregion

        #region Guid

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
