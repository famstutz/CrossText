using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CrossText.Service.DataContract
{
    [DataContract]
    public class TeletextStructureSite
    {
        public TeletextStructureSite()
        {
          this.SubSites = new List<int>();
        }
      
        [DataMember]
        public int SiteNumber { get; set; }

        [DataMember]
        public List<int> SubSites { get; set; }

    }
}