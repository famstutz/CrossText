using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CrossText.Service.DataContract
{
    [DataContract]
    public class MenuStructure
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public int SiteNumber { get; set; }
    }


}