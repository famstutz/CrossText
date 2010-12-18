using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace CrossText.Service.Helpers.Xml
{
    /// <summary>
    /// Validates a given XML-file
    /// </summary>
    public class XmlValidator
    {
        #region Properties
        /// <summary>
        /// Gets the XML file.
        /// </summary>
        public String XmlFile
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the schema file.
        /// </summary>
        public String SchemaFile
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is valid flag.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is valid flag; otherwise, <c>false</c>.
        /// </value>
        protected bool IsValidFlag
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlValidator"/> class.
        /// </summary>
        /// <param name="xmlFile">The XML file.</param>
        /// <param name="schemaFile">The schema file.</param>
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
        /// <summary>
        /// Determines whether this instance is valid.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </returns>
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
        #endregion

        #region Event Handlers
        /// <summary>
        /// Customs the validation event handler.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="System.Xml.Schema.ValidationEventArgs"/> instance containing the event data.</param>
        public void CustomValidationEventHandler(object sender, ValidationEventArgs args)
        {
            IsValidFlag = false;
        }
        #endregion
    }
}