using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;
using CrossText.Service.Helpers;
using System.Xml.Linq;
using CrossText.Service.DataContract;
using System.Reflection;

namespace CrossText.Service.MenuStructureLoader
{
    public class XmlMenuStructureLoader : IMenuStructureLoader
    {
        #region Properties
        public String TeletextStructureXml
        {
            get;
            private set;
        }
        public String TeletextStructureSchema
        {
            get;
            private set;
        }
        public String TeletextStructureSchemaNamespace
        {
            get;
            private set;
        }
        #endregion

        #region Constructors
        public XmlMenuStructureLoader(String teletextStructureXml, String teletextStructureSchema, String teletextStructureSchemaNamespace)
        {
            SetTeletextStructureXml(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
        }
        #endregion

        #region Private Methods 
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