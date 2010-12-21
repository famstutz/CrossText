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
        private const String TELETEXT_BASE_URL = "TeletextBaseUrl";
        private const String IMAGE_MIME_TYPE = "ImageMimeType";
        #endregion

        #region Static Public Methods
        /// <summary>
        /// Gets the teletext teletext structure definition.
        /// </summary>
        public static String TeletextStructureDefinition
        {
            get
            {
                return GetSetting<String>(TELETEXT_STRUCTURE_DEFINITION_KEY);
            }
        }

        /// <summary>
        /// Gets the teletext teletext structure schema.
        /// </summary>
        public static String TeletextStructureSchema
        {
            get
            {
                return GetSetting<String>(TELETEXT_STRUCTURE_SCHEMA_KEY);
            }
        }

        /// <summary>
        /// Gets the teletext teletext structure schema namespace.
        /// </summary>
        public static String TeletextStructureSchemaNamespace
        {
            get
            {
                return GetSetting<String>(TELETEXT_STRUCTURE_SCHEMA_NAMESPACE_KEY);
            }
        }

        /// <summary>
        /// Gets the teletext base URL.
        /// </summary>
        public static String TeletextBaseUrl
        {
            get
            {
                return GetSetting<String>(TELETEXT_BASE_URL);
            }
        }

        public static String ImageMimeType
        {
            get
            {
                return GetSetting<String>(IMAGE_MIME_TYPE);
            }
        }


        /// <summary>
        /// Gets the setting.
        /// </summary>
        /// <param name="setting">The setting.</param>
        /// <returns></returns>
        private static T GetSetting<T>(String settingKey)
        {
            String appSetting = ConfigurationManager.AppSettings[settingKey];
            T convertedAppSetting;

            if (String.IsNullOrEmpty(appSetting))
                throw new ApplicationException(String.Format("Web.config does not contain AppSetting '{0}'", settingKey));
            try
            {
                convertedAppSetting = (T)Convert.ChangeType(appSetting, typeof(T));
            }
            catch (Exception ex)
            {
                throw new ApplicationException(String.Format("Could not convert AppSetting-value '{0}' of key '{1}' to type '{2}'", appSetting, settingKey, typeof(T).ToString()), ex);
            }

            return convertedAppSetting;
        }
        #endregion
    }
}