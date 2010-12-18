using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Web;
using CrossText.Service.DataContract;
using CrossText.Service.MenuStructureLoader;
using CrossText.Service.Helpers;

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
              Url = string.Format(ConfigurationManager.AppSettings["BaseUrl"], number, "00");

              if (!Helper.CheckIfURLExists(new Uri(Url)))
              {
                // Get the Image
                Url = string.Format(ConfigurationManager.AppSettings["BaseUrl"], number, "01");
              }

              byte[] image = Helper.GetImageFromURL(Url);
              return Helper.GetBase64DataURI(ConfigurationManager.AppSettings["ImageMimeType"], image);
            }
            catch (Exception ex)
            {
                FaultContract fault = new FaultContract();
                throw new FaultException<FaultContract>(fault, new FaultReason(string.Format("Teletext Site couldn't be found, {0}", Url)));
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
              string Url = string.Format(ConfigurationManager.AppSettings["BaseUrl"], SiteNumber, string.Format("{0:00}", subSiteNumber));
              byte[] image = Helper.GetImageFromURL(Url);
              return Helper.GetBase64DataURI(ConfigurationManager.AppSettings["ImageMimeType"], image);
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
          TeletextStructureSite siteInfo = new TeletextStructureSite();
          siteInfo.SiteNumber = SiteNumber;

          // check if Subsites exists ?
        
            for (int indexSite = 0; indexSite < 10; indexSite++)
			      {
              string Url = string.Format(ConfigurationManager.AppSettings["BaseUrl"], SiteNumber, string.Format("{0:00}", indexSite));

              if (Helper.CheckIfURLExists(new Uri(Url)))
              {
			          siteInfo.SubSites.Add(indexSite);
              }
          }

          return siteInfo;
        }

        /// <summary>
        /// Gets the menu structure.
        /// </summary>
        /// <returns></returns>
        public DataContract.MenuStructureList GetMenuStructure()
        {
            IMenuStructureLoader loader = new XmlMenuStructureLoader(
                AppDomain.CurrentDomain.BaseDirectory + ConfigurationHelper.TeletextTeletextStructureDefinition,
                AppDomain.CurrentDomain.BaseDirectory + ConfigurationHelper.TeletextTeletextStructureSchema,
                ConfigurationHelper.TeletextTeletextStructureSchemaNamespace
                );

            return loader.LoadMenuStructures();
        }
        #endregion
    }
}