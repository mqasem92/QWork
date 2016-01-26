using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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

        #region file upload

        /// <summary>
        /// Gets the simple file extension without (dot).
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 12:56 PM</createdOn>
        /// <exception cref="System.Exception">
        /// No file exsit in the file upload
        /// or
        /// File upload has more the one file
        /// </exception>
        public static string GetSimpleFileExtension(this FileUpload control)
        {
            if (!control.HasFile || !control.HasFiles)
                throw new Exception("No file exsit in the file upload");

            if (control.AllowMultiple)
                if (control.PostedFiles.Count() > 1)
                    throw new Exception("File upload has more the one file");

            if (control.AllowMultiple)
                control.PostedFiles[0].FileName.GetSimpleFileExtension();

            return control.PostedFile.FileName.GetSimpleFileExtension();
        }

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 12:58 PM</createdOn>
        /// <exception cref="System.Exception">
        /// No file exsit in the file upload
        /// or
        /// File upload has more the one file
        /// </exception>
        public static string GetFileExtension(this FileUpload control)
        {
            if (!control.HasFile || !control.HasFiles)
                throw new Exception("No file exsit in the file upload");

            if (control.AllowMultiple)
                if (control.PostedFiles.Count() > 1)
                    throw new Exception("File upload has more the one file");

            if (control.AllowMultiple)
                return control.PostedFiles[0].FileName.GetFileExtension();

            return control.PostedFile.FileName.GetFileExtension();
        }

        /// <summary>
        /// Gets the name of the file without Extension.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 1:02 PM</createdOn>
        /// <exception cref="System.Exception">
        /// No file exsit in the file upload
        /// or
        /// File upload has more the one file
        /// </exception>
        public static string GetSimpleFileName(this FileUpload control)
        {
            if (!control.HasFile || !control.HasFiles)
                throw new Exception("No file exsit in the file upload");

            if (control.AllowMultiple)
                if (control.PostedFiles.Count() > 1)
                    throw new Exception("File upload has more the one file");

            if (control.AllowMultiple)
                return control.PostedFiles[0].FileName.GetSimpleFileName();

            return control.PostedFile.FileName.GetSimpleFileName();
        }

        /// <summary>
        /// Gets the simple files extension withput (dot).
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 1:28 PM</createdOn>
        /// <exception cref="System.Exception">
        /// No file exsit in the file upload
        /// or
        /// File upload is not Allow Multiple upload files
        /// </exception>
        public static List<string> GetSimpleFilesExtension(this FileUpload control)
        {
            if (!control.HasFile || !control.HasFiles)
                throw new Exception("No file exsit in the file upload");

            if (!control.AllowMultiple)
                throw new Exception("File upload is not Allow Multiple upload files");

            return control.PostedFiles.Select(file => file.FileName.GetSimpleFileExtension()).ToList();
        }

        /// <summary>
        /// Gets the files extension.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 1:29 PM</createdOn>
        /// <exception cref="System.Exception">
        /// No file exsit in the file upload
        /// or
        /// File upload is not Allow Multiple upload files
        /// </exception>
        public static List<string> GetFilesExtension(this FileUpload control)
        {
            if (!control.HasFile || !control.HasFiles)
                throw new Exception("No file exsit in the file upload");

            if (!control.AllowMultiple)
                throw new Exception("File upload is not Allow Multiple upload files");

            return control.PostedFiles.Select(file => file.FileName.GetFileExtension()).ToList();
        }

        /// <summary>
        /// Gets the name of the files without extension.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 1:30 PM</createdOn>
        /// <exception cref="System.Exception">
        /// No file exsit in the file upload
        /// or
        /// File upload is not Allow Multiple upload files
        /// </exception>
        public static List<string> GetSimpleFilesName(this FileUpload control)
        {
            if (!control.HasFile || !control.HasFiles)
                throw new Exception("No file exsit in the file upload");

            if (!control.AllowMultiple)
                throw new Exception("File upload is not Allow Multiple upload files");

            return control.PostedFiles.Select(file => file.FileName.GetSimpleFileName()).ToList();
        }

        #endregion
    }
}
