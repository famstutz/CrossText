using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CrossText.Service.DataContract;

namespace CrossText.Service
{
   
    [ServiceContract]
    public interface ICrossTextService
    {

        [OperationContract]
        byte[] GetTeletextSite(int number);
        
        [OperationContract]
        byte[] GetTeletextSubSite(int SiteNumber, int subSiteNumber);
        
        [OperationContract]
        TeletextStructureSite GetTeletextStructure(int SiteNumber);
        
        [OperationContract]
        MenuStructureList GetMenuStructure();
    }

}
