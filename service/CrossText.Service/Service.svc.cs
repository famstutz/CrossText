using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Web;
using CrossText.Service.DataContract;
using CrossText.Service.MenuStructureLoader;
using CrossText.Service.Helpers;
using CrossText.Service.SiteCaching;
using System.Collections;
using System.Xml;

namespace CrossText.Service
{
    /// <summary>
    /// The implementation of ICrossTextService
    /// </summary>
    public class Service : ICrossTextService
    {   
        #region Implemented Methods from ICrossTextService
        /// <summary>
        /// Gets the teletext site.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public string GetTeletextSite(int number)
        {
            string Url = string.Empty;

            try
            {
                // Check first if URL with 00 does exists
                Url = UrlFormatter.FormatTeletextUrl(number, 0);

                if (!Helper.CheckIfURLExists(new Uri(Url)))
                {
                    // Get the Image
                    Url = UrlFormatter.FormatTeletextUrl(number, 1);
                }

                string value;
                using (var cache = new SerializableSiteCache<string, string>(EnvironmentHelper.ExecutionDirectory + ConfigurationHelper.SerializedSiteCacheFile))
                {
                    // Is image in cache and not expired?
                    if (cache.ContainsKey(Url))
                        return cache.Get(Url);

                    byte[] image = Helper.GetImageFromURL(Url);
                    value = Helper.GetBase64DataURI(ConfigurationHelper.ImageMimeType, image);

                    // Add to cache
                    cache.Insert(Url, value);
                }

                return value;
            }
            catch (Exception ex)
            {
                FaultContract fault = new FaultContract();
                throw new FaultException<FaultContract>(fault, new FaultReason(string.Format("Teletext Site could not be found, {0}", Url)));
            }
        }

        /// <summary>
        /// Gets the teletext sub site.
        /// </summary>
        /// <param name="SiteNumber">The site number.</param>
        /// <param name="subSiteNumber">The sub site number.</param>
        /// <returns></returns>
        public string GetTeletextSubSite(int SiteNumber, int subSiteNumber)
        {            
            try
            {
                // Get the Image
                string Url = UrlFormatter.FormatTeletextUrl(SiteNumber, subSiteNumber);

                string value;
                using (var cache = new SerializableSiteCache<string, string>(EnvironmentHelper.ExecutionDirectory + ConfigurationHelper.SerializedSiteCacheFile))
                {
                    // Is image in cache and not expired?
                    if (cache.ContainsKey(Url))
                        return cache.Get(Url);

                    byte[] image = Helper.GetImageFromURL(Url);
                    value = Helper.GetBase64DataURI(ConfigurationManager.AppSettings["ImageMimeType"], image);

                    // Add to cache
                    cache.Insert(Url, value);
                }
                return value;
            }
            catch (Exception ex)
            {
                FaultContract fault = new FaultContract();
                throw new FaultException<FaultContract>(fault, new FaultReason("Teletext Site couldn't be found"));
            }
        }

        /// <summary>
        /// Gets the teletext structure.
        /// </summary>
        /// <param name="SiteNumber">The site number.</param>
        /// <returns></returns>
        public DataContract.TeletextStructureSite GetTeletextStructure(int SiteNumber)
        {
          try
          {
            TeletextStructureSite siteInfo = new TeletextStructureSite(SiteNumber);

            // check if Subsites exists
            for (int indexSite = 0; indexSite < 10; indexSite++)
            {
              string Url = UrlFormatter.FormatTeletextUrl(SiteNumber, indexSite);
              if (Helper.CheckIfURLExists(new Uri(Url)))
              {
                siteInfo.SubSites.Add(indexSite);
              }
            }

            return siteInfo;
          }
          catch (Exception ex)
          {
            FaultContract fault = new FaultContract();
            throw new FaultException<FaultContract>(fault, new FaultReason(ex.Message));
          }
        }

        /// <summary>
        /// Gets the menu structure.
        /// </summary>
        /// <returns></returns>
        public DataContract.MenuStructureList GetMenuStructure()
        {
          try
          {
             IMenuStructureLoader loader = new XmlMenuStructureLoader(
             EnvironmentHelper.ExecutionDirectory + ConfigurationHelper.TeletextStructureDefinition,
             EnvironmentHelper.ExecutionDirectory + ConfigurationHelper.TeletextStructureSchema,
             ConfigurationHelper.TeletextStructureSchemaNamespace
             );

              return loader.LoadMenuStructures();
          }
          catch (Exception ex)
          {
            FaultContract fault = new FaultContract();
            throw new FaultException<FaultContract>(fault, new FaultReason(ex.Message));
          }
        }
        #endregion
    }
}