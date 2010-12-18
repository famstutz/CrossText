using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Schema;
using CrossText.Service.Helpers.Xml;

namespace CrossText.Service.Helpers
{
    public static class XmlHelper
    {
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
    }
}