using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CrossText.Service.Helpers
{
    public static class ConfigurationHelper
    {
        #region Members
        private const String TELETEXT_STRUCTURE_DEFINITION_KEY = "TeletextStructureDefinition";
        private const String TELETEXT_STRUCTURE_SCHEMA_KEY = "TeletextStructureSchema";
        private const string TELETEXT_STRUCTURE_SCHEMA_NAMESPACE_KEY = "TeletextStructureSchemaNamespace";
        #endregion

        #region Static Public Methods
        public static String TeletextTeletextStructureDefinition
        {
            get
            {
                String appSetting = ConfigurationManager.AppSettings[TELETEXT_STRUCTURE_DEFINITION_KEY];
                if (String.IsNullOrEmpty(appSetting))
                    throw new ApplicationException(String.Format("Web.config does not contain AppSetting '{0}'", TELETEXT_STRUCTURE_DEFINITION_KEY));

                return appSetting;
            }
        }

        public static String TeletextTeletextStructureSchema
        {
            get
            {
                String appSetting = ConfigurationManager.AppSettings[TELETEXT_STRUCTURE_SCHEMA_KEY];
                if (String.IsNullOrEmpty(appSetting))
                    throw new ApplicationException(String.Format("Web.config does not contain AppSetting '{0}'", TELETEXT_STRUCTURE_SCHEMA_KEY));

                return appSetting;
            }
        }

        public static String TeletextTeletextStructureSchemaNamespace
        {
            get
            {
                String appSetting = ConfigurationManager.AppSettings[TELETEXT_STRUCTURE_SCHEMA_NAMESPACE_KEY];
                if (String.IsNullOrEmpty(appSetting))
                    throw new ApplicationException(String.Format("Web.config does not contain AppSetting '{0}'", TELETEXT_STRUCTURE_SCHEMA_NAMESPACE_KEY));

                return appSetting;
            }
        }
        #endregion
    }
}