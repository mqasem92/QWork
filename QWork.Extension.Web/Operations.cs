using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace QWork.Extension.Web
{
    /// <summary>
    /// Operation For Web
    /// </summary>
    /// <createdOn>1/27/2016 12:45 PM</createdOn>
    public static class Operations
    {
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
