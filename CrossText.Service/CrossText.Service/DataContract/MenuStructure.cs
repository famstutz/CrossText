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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;
            
            MenuStructure ms = (MenuStructure)obj;
           
            if (!Object.Equals(SiteNumber, ms.SiteNumber)) return false;
            if (!Object.Equals(Title, ms.Title)) return false;

            return true;
        }
    }


}