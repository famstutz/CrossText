using System;
using CrossText.Service.Helpers.Xml;

namespace CrossText.Service.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class XmlHelper
    {
        #region Public Static Methods
        /// <summary>
        /// Determines whether the given XML file is valid
        /// </summary>
        /// <param name="xmlFile">The XML file.</param>
        /// <param name="schemaFile">The schema file.</param>
        /// <returns>
        ///   <c>true</c> if the supplied XML file is valid; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidXml(String xmlFile, String schemaFile)
        {
            bool isValid = false;
            XmlValidator validator = new XmlValidator(xmlFile, schemaFile);

            try
            {
                isValid = validator.IsValid();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(String.Format("Could not validate Xml-File '{0}' against Schema-File '{1}", xmlFile, schemaFile), ex);
            }

            return isValid;
        }
        #endregion
    }
}