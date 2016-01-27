using System;
using System.Linq;
using System.Web.UI.WebControls;
using QWork.Core.Enum;
using QWork.Core.Settings;

namespace QWork.Extension.Web
{
    public static class Checking
    {
        #region file upload

        /// <summary>
        /// Determines whether [is valid size] [the specified size].
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="size">Target size to compare.</param>
        /// <param name="sizeSuffixes">The size suffixes of target size.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 11:20 AM</createdOn>
        public static bool IsValidFileSize(this FileUpload control, long size, SizeSuffixes sizeSuffixes = SizeSuffixes.Bytes)
        {
            if (!control.HasFile || !control.HasFiles)
                throw new Exception("No file exsit in the file upload");

            //If file upload has multiple files
            if (control.AllowMultiple)
            {
                return !control.PostedFiles.Any(file => file.ContentLength > size.ToByte(sizeSuffixes));
            }

            //If files not has multiple files
            return control.FileContent.Length <= size.ToByte(sizeSuffixes);
        }

        /// <summary>
        /// Determines whether [is valid file type] [the specified file type].
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="fileType">Type of the file.</param>
        /// <returns></returns>
        /// <createdOn>1/26/2016 12:27 PM</createdOn>
        public static bool IsValidFileType(this FileUpload control, FileType fileType = FileType.Image)
        {
            if (!control.HasFile || !control.HasFiles)
                throw new Exception("No file exsit in the file upload");

            var isAllowedExtension = false;

            if (control.AllowMultiple)
            {
                foreach (var file in control.PostedFiles)
                {
                    isAllowedExtension = FileTypeSetting.IsAllowedExtension(file.FileName.GetSimpleFileExtension(), fileType);

                    if (!isAllowedExtension)
                        return false;
                }
            }
            else
            {
                isAllowedExtension =
                    FileTypeSetting.IsAllowedExtension(control.PostedFile.FileName.GetSimpleFileExtension(), fileType);
            }

            return isAllowedExtension;
        }

        #endregion
    }
}
