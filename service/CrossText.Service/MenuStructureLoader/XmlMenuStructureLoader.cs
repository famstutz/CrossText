using System;
using System.IO;
using CrossText.Service.Helpers;
using CrossText.Service.DataContract;
using System.Linq;
using System.Xml.Linq;

namespace CrossText.Service.MenuStructureLoader
{
    /// <summary>
    /// The <see cref="XmlMenuStructureLoader"/> returns all MenuStructures present in a XML-configuration file
    /// </summary>
    public class XmlMenuStructureLoader : IMenuStructureLoader
    {
        #region Properties
        /// <summary>
        /// Gets the teletext structure XML.
        /// </summary>
        public String TeletextStructureXml
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the teletext structure schema.
        /// </summary>
        public String TeletextStructureSchema
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the teletext structure schema namespace.
        /// </summary>
        public String TeletextStructureSchemaNamespace
        {
            get;
            private set;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlMenuStructureLoader"/> class.
        /// </summary>
        /// <param name="teletextStructureXml">The teletext structure XML.</param>
        /// <param name="teletextStructureSchema">The teletext structure schema.</param>
        /// <param name="teletextStructureSchemaNamespace">The teletext structure schema namespace.</param>
        public XmlMenuStructureLoader(String teletextStructureXml, String teletextStructureSchema, String teletextStructureSchemaNamespace)
        {
            SetTeletextStructureXml(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Sets the teletext structure XML.
        /// </summary>
        /// <param name="teletextStructureXml">The teletext structure XML.</param>
        /// <param name="teletextStructureSchema">The teletext structure schema.</param>
        /// <param name="teletextStructureSchemaNamespace">The teletext structure schema namespace.</param>
        private void SetTeletextStructureXml(String teletextStructureXml, String teletextStructureSchema, String teletextStructureSchemaNamespace)
        {
            if (!File.Exists(teletextStructureXml))
                throw new ApplicationException(String.Format("Given TeletextStructure-XML-File '{0}' does not exist", teletextStructureXml));

            if (!XmlHelper.IsValidXml(teletextStructureXml, teletextStructureSchema))
                throw new ApplicationException(String.Format("Given TeletextStructure-XML-File '{0}' is not of valid type", teletextStructureXml));

            TeletextStructureXml = teletextStructureXml;
            TeletextStructureSchema = teletextStructureSchema;
            TeletextStructureSchemaNamespace = teletextStructureSchemaNamespace;
        }
        #endregion

        #region Implemented Methods from IMenuStructureLoader
        /// <summary>
        /// Loads the menu structures.
        /// </summary>
        /// <returns></returns>
        public MenuStructureList LoadMenuStructures()
        {
            MenuStructureList msList = new MenuStructureList();
            XDocument xDoc = XDocument.Load(TeletextStructureXml);
            XNamespace xNs = TeletextStructureSchemaNamespace;
            var msQuery = from menuStructure in xDoc.Descendants(xNs + "TeletextStructure").Descendants(xNs + "MenuStructure")
                          select menuStructure;

            foreach (XElement element in msQuery)
            {
                msList.Add(new MenuStructure() { 
                    SiteNumber = Int32.Parse(element.Descendants(xNs + "SiteNumber").FirstOrDefault().Value),
                    Title = element.Descendants(xNs + "Title").FirstOrDefault().Value 
                });
            }

            return msList;
        }
        #endregion
    }
}