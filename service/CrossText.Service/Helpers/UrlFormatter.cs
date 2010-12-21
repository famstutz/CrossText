using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossText.Service.Helpers
{
    /// <summary>
    /// Provides functionality to correctly format the Url
    /// </summary>
    public class UrlFormatter
    {
        #region Public static methods
        /// <summary>
        /// Formats the teletext URL.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="siteNumber">The site number.</param>
        /// <param name="subSiteNumber">The sub site number.</param>
        /// <returns></returns>
        public static string FormatTeletextUrl(string baseUrl, int siteNumber, int subSiteNumber)
        {
            return string.Format(baseUrl, siteNumber, subSiteNumber.ToString("00"));
        }

        /// <summary>
        /// Formats the teletext URL.
        /// </summary>
        /// <param name="siteNumber">The site number.</param>
        /// <param name="subSiteNumber">The sub site number.</param>
        /// <returns></returns>
        public static string FormatTeletextUrl(int siteNumber, int subSiteNumber)
        {
            return FormatTeletextUrl(ConfigurationHelper.TeletextBaseUrl, siteNumber, subSiteNumber);
        }
        #endregion
    }
}
