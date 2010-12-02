using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CrossText.Service.DataContract;
using System.Configuration;

namespace CrossText.Service
{
    public class Service : ICrossTextService
    {
        public byte[] GetTeletextSite(int number)
        {
            try
            {
              // Get the Image
              string Url = string.Format(ConfigurationManager.AppSettings["BaseUrl"], number, "00");

              return Helper.GetImageFromURL(Url);
            }
            catch (Exception ex)
            {
                FaultContract fault = new FaultContract();
                throw new FaultException<FaultContract>(fault, new FaultReason("Teletext Site couldn't be found"));
            }
        }

        public byte[] GetTeletextSubSite(int SiteNumber, int subSiteNumber)
        {
            try
            {
              // Get the Image
              string Url = string.Format(ConfigurationManager.AppSettings["BaseUrl"], SiteNumber, string.Format("{0:00}", subSiteNumber));

              return Helper.GetImageFromURL(Url);
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
            MenuStructureList menuList = new MenuStructureList();
            menuList.Add(new MenuStructure() { SiteNumber = 101, Title = "News" });
            menuList.Add(new MenuStructure() { SiteNumber = 200, Title = "Sport" });
            menuList.Add(new MenuStructure() { SiteNumber = 300, Title = "TV/Radio" });
            menuList.Add(new MenuStructure() { SiteNumber = 400, Title = "Reisen" });
            menuList.Add(new MenuStructure() { SiteNumber = 500, Title = "Konsum" });
            menuList.Add(new MenuStructure() { SiteNumber = 600, Title = "Finanzen" });
            menuList.Add(new MenuStructure() { SiteNumber = 700, Title = "Entertainment" });
            menuList.Add(new MenuStructure() { SiteNumber = 800, Title = "Freizeit" });

            return menuList;
        }
    }
}