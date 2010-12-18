using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml.Schema;
using System.Xml;
using System.Reflection;

namespace CrossText.Service.Helpers.Xml
{
    public class XmlValidator
    {
        #region Properties
        public String XmlFile
        {
            get;
            private set;
        }
        public String SchemaFile
        {
            get;
            private set;
        }
        protected bool IsValidFlag
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public XmlValidator(String xmlFile, String schemaFile)
        {
            if (!File.Exists(xmlFile))
                throw new ApplicationException(String.Format("Given XML-file '{0}' does not exist", xmlFile));

            if (!File.Exists(schemaFile))
                throw new ApplicationException(String.Format("Given XSD-file '{0}' does not exist", schemaFile));

            XmlFile = xmlFile;
            SchemaFile = schemaFile;
        }
        #endregion

        #region Methods
        public bool IsValid()
        {
            IsValidFlag = true;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            XmlReader reader = XmlReader.Create(new XmlTextReader(XmlFile), settings);
            settings.Schemas.Add(null, new XmlTextReader(SchemaFile));

            while (reader.Read())
            { }
            reader.Close();

            return IsValidFlag;
        }

        public void CustomValidationEventHandler(object sender, ValidationEventArgs args)
        {
            IsValidFlag = false;
        }
        #endregion
    }
}