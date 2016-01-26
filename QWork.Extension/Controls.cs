using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace QWork.Extension
{
    /// <summary>
    /// Static Controls Class
    /// </summary>
    /// <createdOn>1/26/2016 10:01 AM</createdOn>
    public static class Controls
    {
        #region Bind

        /// <summary>
        /// Binds the with.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="dataSource">The data source.</param>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        public static void BindWith(this DataBoundControl control, ICollection dataSource)
        {
            control.DataSource = dataSource;
            control.DataBind();
        }

        #region Drop Down List

        /// <summary>
        /// Binds the with.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="dataSource">The data source.</param>
        /// <param name="valueField">The value field.</param>
        /// <param name="textField">The text field.</param>
        /// <param name="isRequired">if set to <c>true</c> [is required].</param>
        /// <param name="defaultTextValue">The default text value.</param>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        /// <exception cref="System.ArgumentNullException">No Controls Found !</exception>
        public static void BindWith(this DropDownList control, ICollection dataSource,
            string valueField, string textField, bool isRequired = true, string defaultTextValue = "")
        {
            if (control == null)
            {
                throw new ArgumentNullException("No Controls Found !");
            }

            if (!string.IsNullOrWhiteSpace(textField))
            {
                control.DataTextField = textField;
            }

            if (!string.IsNullOrWhiteSpace(valueField))
            {
                control.DataValueField = valueField;
            }

            control.DataSource = dataSource;
            control.DataBind();

            if (!isRequired)
            {
                return;
            }

            control.Items.Insert(0, new ListItem(defaultTextValue, string.Empty));
        }

        /// <summary>
        /// Binds the with.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="dataSource">The data source.</param>
        /// <param name="isRequired">if set to <c>true</c> [is required].</param>
        /// <createdOn>1/26/2016 9:58 AM</createdOn>
        public static void BindWith(this DropDownList control, ICollection dataSource, bool isRequired = true)
        {
            string dataTextField = string.IsNullOrWhiteSpace(control.DataTextField) ? "Text" : control.DataTextField;
            string dataValueField = string.IsNullOrWhiteSpace(control.DataValueField) ? "Value" : control.DataValueField;
            control.BindWith(dataSource, dataValueField, dataTextField, isRequired);
        }

        #endregion

        #endregion

        #region TextBox

        /// <summary>
        /// Trimmeds the text.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static string TrimmedText(this TextBox textBox)
        {
            return textBox.Text.Trim();
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control">The control.</param>
        /// <param name="trimmedText">if set to <c>true</c> [trimmed text].</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static T GetValue<T>(this TextBox control, bool trimmedText = false, T defaultValue = default(T))
        {
            if (trimmedText)
                return control.TrimmedText().To(defaultValue);

            return control.Text.To(defaultValue);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="value">The value.</param>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static void SetValue(this TextBox control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region Label

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control">The control.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static T GetValue<T>(this Label control, T defaultValue = default(T))
        {
            return control.Text.To(defaultValue);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="value">The value.</param>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static void SetValue(this Label control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region Literal

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control">The control.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static T GetValue<T>(this Literal control, T defaultValue = default(T))
        {
            return control.Text.To(defaultValue);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="value">The value.</param>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static void SetValue(this Literal control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region Button

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control">The control.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static T GetValue<T>(this Button control, T defaultValue = default(T))
        {
            return control.Text.To(defaultValue);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="value">The value.</param>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static void SetValue(this Button control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region LinkButton

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control">The control.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 9:59 AM</createdOn>
        public static T GetValue<T>(this LinkButton control, T defaultValue = default(T))
        {
            return control.Text.To(defaultValue);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="value">The value.</param>
        /// <createdOn>1/26/2016 10:00 AM</createdOn>
        public static void SetValue(this LinkButton control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region Drop Down List

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control">The control.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:00 AM</createdOn>
        public static T GetValue<T>(this DropDownList control, T defaultValue = default(T))
        {
            return control.SelectedValue.To(defaultValue);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 10:00 AM</createdOn>
        public static bool SetValue(this DropDownList control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.SelectedIndex = -1;
            foreach (ListItem listItem in control.Items)
            {
                if (listItem.Value == valueString)
                {
                    listItem.Selected = true;
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
