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
    public static class Controls
    {
        #region Bind

        //TODO: Test
        public static void BindWith(this DataBoundControl control, ICollection dataSource)
        {
            control.DataSource = dataSource;
            control.DataBind();
        }

        #region Drop Down List

        //TODO: Test
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

        //TODO: Test
        public static void BindWith(this DropDownList control, ICollection dataSource, bool isRequired = true)
        {
            string dataTextField = string.IsNullOrWhiteSpace(control.DataTextField) ? "Text" : control.DataTextField;
            string dataValueField = string.IsNullOrWhiteSpace(control.DataValueField) ? "Value" : control.DataValueField;
            control.BindWith(dataSource, dataValueField, dataTextField, isRequired);
        }

        #endregion

        #endregion

        #region TextBox

        //TODO: Test
        public static string TrimmedText(this TextBox textBox)
        {
            return textBox.Text.Trim();
        }

        //TODO: Test
        public static T GetValue<T>(this TextBox control, bool trimmedText = false, T defaultValue = default(T))
        {
            if (trimmedText)
                return control.TrimmedText().To(defaultValue);

            return control.Text.To(defaultValue);
        }

        //TODO: Test
        public static void SetValue(this TextBox control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region Label

        //TODO: Test
        public static T GetValue<T>(this Label control, T defaultValue = default(T))
        {
            return control.Text.To(defaultValue);
        }

        //TODO: Test
        public static void SetValue(this Label control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region Literal

        //TODO: Test
        public static T GetValue<T>(this Literal control, T defaultValue = default(T))
        {
            return control.Text.To(defaultValue);
        }

        //TODO: Test
        public static void SetValue(this Literal control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region Button

        //TODO: Test
        public static T GetValue<T>(this Button control, T defaultValue = default(T))
        {
            return control.Text.To(defaultValue);
        }

        //TODO: Test
        public static void SetValue(this Button control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region LinkButton

        //TODO: Test
        public static T GetValue<T>(this LinkButton control, T defaultValue = default(T))
        {
            return control.Text.To(defaultValue);
        }

        //TODO: Test
        public static void SetValue(this LinkButton control, object value)
        {
            var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
            control.Text = valueString;
        }

        #endregion

        #region Drop Down List

        //TODO: Test
        public static T GetValue<T>(this DropDownList control, T defaultValue = default(T))
        {
            return control.SelectedValue.To(defaultValue);
        }

        //TODO: Test
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
