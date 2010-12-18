﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CrossText.Service.DataContract;
using System.Configuration;
using System.Xml;
using CrossText.Service.Helpers;
using CrossText.Service.MenuStructureLoader;

namespace CrossText.Service
{
    public class Service : ICrossTextService
    {
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

        public DataContract.MenuStructureList GetMenuStructure()
        {
            IMenuStructureLoader loader = new XmlMenuStructureLoader(
                AppDomain.CurrentDomain.BaseDirectory + ConfigurationHelper.TeletextTeletextStructureDefinition,
                AppDomain.CurrentDomain.BaseDirectory + ConfigurationHelper.TeletextTeletextStructureSchema,
                ConfigurationHelper.TeletextTeletextStructureSchemaNamespace
                );

            return loader.LoadMenuStructures();
        }
    }
}