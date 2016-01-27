using System;
using System.Configuration;
using QWork.Core.Enum;

namespace QWork.Core.Settings
{
    /// <summary>
    ///     File Typs Class Settings
    /// </summary>
    /// <createdOn>1/26/2016 12:24 PM</createdOn>
    public class FileTypeSetting
    {
        #region Helper

        /// <summary>
        ///     Determines whether [is allowed extension] [the specified extension].
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <param name="fileType">Type of the file.</param>
        /// <returns></returns>
        /// <createdOn>1/27/2016 8:00 AM</createdOn>
        /// <exception cref="System.ArgumentOutOfRangeException">null</exception>
        public static bool IsAllowedExtension(string extension, FileType fileType = FileType.Image)
        {
            var isAllowed = false;

            switch (fileType)
            {
                case FileType.Image:
                    isAllowed = ImageExtensions.Contains(extension);
                    break;
                case FileType.Document:
                    isAllowed = DocumentExtensions.Contains(extension);
                    break;
                case FileType.Presentation:
                    isAllowed = PresentationExtensions.Contains(extension);
                    break;
                case FileType.Spreadsheet:
                    isAllowed = SpreadsheetExtensions.Contains(extension);
                    break;
                case FileType.CompressedFile:
                    isAllowed = CompressedFileExtensions.Contains(extension);
                    break;
                case FileType.Website:
                    isAllowed = WebsiteExtensions.Contains(extension);
                    break;
                case FileType.Sound:
                    isAllowed = SoundExtensions.Contains(extension);
                    break;
                case FileType.Video:
                    isAllowed = VideoExtensions.Contains(extension);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
            }

            return isAllowed;
        }

        #endregion

        #region Private Keys

        /// <summary>
        ///     The _image extensions key
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _imageExtensionsKey = "ImageExtensions";

        /// <summary>
        ///     The _document extensions key
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _documentExtensionsKey = "DocumentExtensions";

        /// <summary>
        ///     The _presentation extensions key
        /// </summary>
        /// <createdOn>1/26/2016 12:22 PM</createdOn>
        private const string _presentationExtensionsKey = "PresentationExtensions";

        /// <summary>
        ///     The _spreadsheet extensions key
        /// </summary>
        /// <createdOn>1/26/2016 12:22 PM</createdOn>
        private const string _spreadsheetExtensionsKey = "SpreadsheetExtensions";

        /// <summary>
        ///     The _compressed file extensions key
        /// </summary>
        /// <createdOn>1/26/2016 12:22 PM</createdOn>
        private const string _compressedFileExtensionsKey = "CompressedFileExtensions";

        /// <summary>
        ///     The _sound extensions key
        /// </summary>
        /// <createdOn>1/26/2016 12:22 PM</createdOn>
        private const string _soundExtensionsKey = "SoundExtensions";

        /// <summary>
        ///     The _video extensions key
        /// </summary>
        /// <createdOn>1/26/2016 12:22 PM</createdOn>
        private const string _videoExtensionsKey = "VideoExtensions";

        /// <summary>
        ///     The _website extensions key
        /// </summary>
        /// <createdOn>1/26/2016 12:22 PM</createdOn>
        private const string _websiteExtensionsKey = "WebsiteExtensions";

        #endregion

        #region Priavte Variables

        /// <summary>
        ///     The _image extensions
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _imageExtensions = "jpeg,jpg,jif,jfif,gif,png,tiff,tif,pcd,ico";

        /// <summary>
        ///     The _document extensions
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _documentExtensions = "doc,docm,docx,dot,pdf,rtf,txt";

        /// <summary>
        ///     The _presentation extensions
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _presentationExtensions = "key,ppt,pptx,ppsx,pptx";

        /// <summary>
        ///     The _spreadsheet extensions
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _spreadsheetExtensions = "csv,xls,xlsx";

        /// <summary>
        ///     The _compressed file extensions
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _compressedFileExtensions = "zip,rar,7z,bz2,gzip";

        /// <summary>
        ///     The _sound extensions
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _soundExtensions = "3ga,m4a,m4p,mp2,mp3,mpga,ra,ram,wav,wma";

        /// <summary>
        ///     The _video extensions
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _videoExtensions = "3gp,avi,divx,flv,mov,mp4,mpeg,mpg,rm,swf,wmv";

        /// <summary>
        ///     The _website extensions
        /// </summary>
        /// <createdOn>1/26/2016 12:21 PM</createdOn>
        private const string _websiteExtensions = "css,html,htm,js,json,php";

        #endregion

        #region Public Proparety

        /// <summary>
        ///     Gets the image extensions.
        /// </summary>
        /// <value>
        ///     The image extensions.
        /// </value>
        /// <createdOn>1/26/2016 12:13 PM</createdOn>
        public static string ImageExtensions
        {
            get
            {
                var value = ConfigurationManager.AppSettings[_imageExtensionsKey];
                return !string.IsNullOrEmpty(value) ? value : _imageExtensions;
            }
        }

        /// <summary>
        ///     Gets the document extensions.
        /// </summary>
        /// <value>
        ///     The document extensions.
        /// </value>
        /// <createdOn>1/26/2016 12:13 PM</createdOn>
        public static string DocumentExtensions
        {
            get
            {
                var value = ConfigurationManager.AppSettings[_documentExtensionsKey];
                return !string.IsNullOrEmpty(value) ? value : _documentExtensions;
            }
        }

        /// <summary>
        ///     Gets the presentation extensions.
        /// </summary>
        /// <value>
        ///     The presentation extensions.
        /// </value>
        /// <createdOn>1/26/2016 12:16 PM</createdOn>
        public static string PresentationExtensions
        {
            get
            {
                var value = ConfigurationManager.AppSettings[_presentationExtensionsKey];
                return !string.IsNullOrEmpty(value) ? value : _presentationExtensions;
            }
        }

        /// <summary>
        ///     Gets the spreadsheet extensions.
        /// </summary>
        /// <value>
        ///     The spreadsheet extensions.
        /// </value>
        /// <createdOn>1/26/2016 12:17 PM</createdOn>
        public static string SpreadsheetExtensions
        {
            get
            {
                var value = ConfigurationManager.AppSettings[_spreadsheetExtensionsKey];
                return !string.IsNullOrEmpty(value) ? value : _spreadsheetExtensions;
            }
        }

        /// <summary>
        ///     Gets the compressed file extensions.
        /// </summary>
        /// <value>
        ///     The compressed file extensions.
        /// </value>
        /// <createdOn>1/26/2016 12:18 PM</createdOn>
        public static string CompressedFileExtensions
        {
            get
            {
                var value = ConfigurationManager.AppSettings[_compressedFileExtensionsKey];
                return !string.IsNullOrEmpty(value) ? value : _compressedFileExtensions;
            }
        }

        /// <summary>
        ///     Gets the sound extensions.
        /// </summary>
        /// <value>
        ///     The sound extensions.
        /// </value>
        /// <createdOn>1/26/2016 12:19 PM</createdOn>
        public static string SoundExtensions
        {
            get
            {
                var value = ConfigurationManager.AppSettings[_soundExtensionsKey];
                return !string.IsNullOrEmpty(value) ? value : _soundExtensions;
            }
        }

        /// <summary>
        ///     Gets the video extensions.
        /// </summary>
        /// <value>
        ///     The video extensions.
        /// </value>
        /// <createdOn>1/26/2016 12:20 PM</createdOn>
        public static string VideoExtensions
        {
            get
            {
                var value = ConfigurationManager.AppSettings[_videoExtensionsKey];
                return !string.IsNullOrEmpty(value) ? value : _videoExtensions;
            }
        }

        /// <summary>
        ///     Gets the website extensions.
        /// </summary>
        /// <value>
        ///     The website extensions.
        /// </value>
        /// <createdOn>1/26/2016 12:20 PM</createdOn>
        public static string WebsiteExtensions
        {
            get
            {
                var value = ConfigurationManager.AppSettings[_websiteExtensionsKey];
                return !string.IsNullOrEmpty(value) ? value : _websiteExtensions;
            }
        }

        #endregion
    }
}