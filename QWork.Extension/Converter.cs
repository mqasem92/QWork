using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace QWork.Extension
{
    /// <summary>
    /// Static Converter Class
    /// </summary>
    /// <createdOn>1/26/2016 9:55 AM</createdOn>
    public static class Converter
    {
        #region Common

        /// <summary>
        /// To the specified default value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:50 AM</createdOn>
        public static T To<T>(this object obj, T defaultValue)
        {
            if (obj == null)
            {
                return defaultValue;
            }

            if (obj is T)
            {
                return (T)obj;
            }

            Type type = typeof(T);

            // Place convert to reference types here
            if (type == typeof(string))
            {
                return (T)(object)obj.ToString();
            }

            Type underlyingType = Nullable.GetUnderlyingType(type);

            if (underlyingType != null)
            {
                return To(obj, defaultValue, underlyingType);
            }

            return To(obj, defaultValue, type);
        }

        /// <summary>
        /// To the specified object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:50 AM</createdOn>
        /// <exception cref="System.NotSupportedException"></exception>
        private static T To<T>(object obj, T defaultValue, Type type)
        {
            // Place convert to structures types here
            if (type == typeof(short))
            {
                short value;
                if (short.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(ushort))
            {
                ushort value;
                if (ushort.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(int))
            {
                int value;

                if (int.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(uint))
            {
                uint value;

                if (uint.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(long))
            {
                long value;
                if (long.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(ulong))
            {
                ulong value;
                if (ulong.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(float))
            {
                float value;
                if (float.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(double))
            {
                double value;
                if (double.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(decimal))
            {
                decimal value;
                if (decimal.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(bool))
            {
                bool value;
                if (bool.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(DateTime))
            {
                DateTime value;
                if (DateTime.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(byte))
            {
                byte value;
                if (byte.TryParse(obj.ToString(), out value))
                {
                    return (T)(object)value;
                }

                return defaultValue;
            }

            if (type == typeof(Guid))
            {
                const string guidRegEx =
                    @"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$";
                var regEx = new Regex(guidRegEx);
                if (regEx.IsMatch(obj.ToString()))
                {
                    return (T)(object)new Guid(obj.ToString());
                }

                return defaultValue;
            }

            if (type.IsEnum)
            {
                if (Enum.IsDefined(type, obj))
                {
                    return (T)Enum.Parse(type, obj.ToString());
                }

                return defaultValue;
            }

            throw new NotSupportedException(
                string.Format("Couldn't parse \"{0}\" as {1} to Type \"{2}\"", obj, type, typeof(T)));
        }

        #endregion

        #region Guid

        /// <summary>
        /// To the unique identifier.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:50 AM</createdOn>
        public static Guid ToGuid(this string value)
        {
            try
            {
                return new Guid(value);
            }
            catch
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// To the unique identifier.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:51 AM</createdOn>
        public static Guid ToGuid(this object value)
        {
            try
            {
                return new Guid(value.ToString());
            }
            catch
            {
                return Guid.Empty;
            }
        }

        public static Guid? ToNullableGuid(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return new Nullable<Guid>(value.ToGuid());
        }

        #endregion

        #region Byte

        /// <summary>
        /// To the byte.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:51 AM</createdOn>
        public static byte ToByte(this object value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>
        /// To the byte.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:51 AM</createdOn>
        public static byte ToByte(this string value, byte defaultValue)
        {
            byte result;
            if (!string.IsNullOrEmpty(value) && byte.TryParse(value.ToString(), out result))
            {
                return result;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the nullable byte.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:51 AM</createdOn>
        public static byte? ToNullableByte(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return new byte?(Convert.ToByte(value));
        }

        #endregion

        #region Short

        /// <summary>
        /// To the short.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:52 AM</createdOn>
        public static short ToShort(this object value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>
        /// To the short.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:52 AM</createdOn>
        public static short ToShort(this string value, short defaultValue)
        {
            short result;
            if (!string.IsNullOrEmpty(value) && short.TryParse(value.ToString(), out result))
            {
                return result;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the nullable short.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:52 AM</createdOn>
        public static short? ToNullableShort(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return new Nullable<short>(Convert.ToInt16(value));
        }

        #endregion

        #region Double

        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:52 AM</createdOn>
        public static double ToDouble(this object value)
        {
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:52 AM</createdOn>
        public static double ToDouble(this object value, double defaultValue)
        {
            double result;
            string stringValue = value == null ? string.Empty : value.ToString();

            if (!string.IsNullOrEmpty(stringValue) && double.TryParse(stringValue, out result))
            {
                return result;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the nullable double.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:54 AM</createdOn>
        public static double? ToNullableDouble(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return new Nullable<double>(Convert.ToDouble(value));
        }

        #endregion

        #region Int

        /// <summary>
        /// To the nullable int.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:54 AM</createdOn>
        public static int? ToNullableInt(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return new Nullable<int>(Convert.ToInt32(value));
        }

        /// <summary>
        /// Converts the string representation of a number to an integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:54 AM</createdOn>
        public static int ToInt(this object value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// Converts the string representation of a number to an integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:54 AM</createdOn>
        public static int ToInt(this object value, int defaultValue)
        {
            string stringValue = value == null ? string.Empty : value.ToString();

            int result;
            if (!string.IsNullOrEmpty(stringValue) && int.TryParse(stringValue, out result))
            {
                return result;
            }

            return defaultValue;
        }

        #endregion

        #region Bool

        /// <summary>
        /// To the bool.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:55 AM</createdOn>
        public static bool ToBool(this object value)
        {
            return Convert.ToBoolean(value);
        }

        #endregion

        #region DateTime

        /// <summary>
        /// To the date time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:55 AM</createdOn>
        public static DateTime ToDateTime(this object value)
        {
            return Convert.ToDateTime(value);
        }

        /// <summary>
        /// To the nullable date time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:55 AM</createdOn>
        public static DateTime? ToNullableDateTime(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return new Nullable<DateTime>(value.ToDateTime());
        }

        #endregion

        #region Collection

        /// <summary>
        /// To the data table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:55 AM</createdOn>
        public static DataTable ToDataTable<T>(this IEnumerable<T> items)
        {
            var propertyDescriptors = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable(typeof(T).FullName);
            foreach (PropertyDescriptor propertyDescriptor in propertyDescriptors)
            {
                var columnType = Nullable.GetUnderlyingType(propertyDescriptor.PropertyType)
                                 ?? propertyDescriptor.PropertyType;
                var dataColumn = new DataColumn(propertyDescriptor.Name, columnType);
                table.Columns.Add(dataColumn);
            }

            foreach (var item in items)
            {
                var row = table.NewRow();
                foreach (PropertyDescriptor propertyDescriptor in propertyDescriptors)
                {
                    row[propertyDescriptor.Name] = propertyDescriptor.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        #endregion
    }
}
