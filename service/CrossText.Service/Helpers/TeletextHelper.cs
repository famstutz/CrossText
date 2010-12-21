using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossText.Service.Helpers
{
    public class TeletextHelper
    {
        public static string FormatTeletextUrl(string baseUrl, int siteNumber, int subSiteNumber)
        {
            return string.Format(baseUrl, siteNumber, subSiteNumber);
        }

        public static string FormatTeletextUrl(int siteNumber, int subSiteNumber)
        {
            return FormatTeletextUrl(ConfigurationHelper.TeletextBaseUrl, siteNumber, subSiteNumber);
        }
    }
}
