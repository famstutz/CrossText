using System;
using System.Configuration;

namespace CrossText.Service.Helpers
{
    /// <summary>
    /// The <see cref="ConfigurationHelper"/> takes care of all configuration stored in Web.Config, User.Config, ...
    /// </summary>
    public static class ConfigurationHelper
    {
        #region Constants
        private const String TELETEXT_STRUCTURE_DEFINITION_KEY = "TeletextStructureDefinition";
        private const String TELETEXT_STRUCTURE_SCHEMA_KEY = "TeletextStructureSchema";
        private const String TELETEXT_STRUCTURE_SCHEMA_NAMESPACE_KEY = "TeletextStructureSchemaNamespace";
        #endregion

        #region Static Public Methods
        /// <summary>
        /// Gets the teletext teletext structure definition.
        /// </summary>
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

        /// <summary>
        /// Gets the teletext teletext structure schema.
        /// </summary>
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

        /// <summary>
        /// Gets the teletext teletext structure schema namespace.
        /// </summary>
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