using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using CrossText.Service.DataContract;

namespace CrossText.Service
{
   
    [ServiceContract]
    public interface ICrossTextService
    {

        [OperationContract]
        [WebGet]
        string GetTeletextSite(int number);
        
        [OperationContract]
        [WebGet]
        string GetTeletextSubSite(int SiteNumber, int subSiteNumber);
        
        [OperationContract]
        [WebGet]
        TeletextStructureSite GetTeletextStructure(int SiteNumber);
        
        [OperationContract]
        [WebGet]
        MenuStructureList GetMenuStructure();

    }

}
