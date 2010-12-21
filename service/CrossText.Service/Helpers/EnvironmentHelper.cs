using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossText.Service.Helpers
{
    /// <summary>
    /// Provides execution environment related constants
    /// </summary>
    public static class EnvironmentHelper
    {
        #region Public static properties
        public static String ExecutionDirectory 
        {
            get
            {
                String baseDirectory = AppDomain.CurrentDomain.RelativeSearchPath;
                baseDirectory = !baseDirectory.EndsWith("\\") ? baseDirectory + "\\" : baseDirectory;
                return baseDirectory;
            }
        }
        #endregion
    }
}