using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CrossText.Service.DataContract
{
    [CollectionDataContract]
    public class MenuStructureList: List<MenuStructure>
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;
            
            MenuStructureList msl = (MenuStructureList)obj;
            var query = from ms1 in msl
                        join ms2 in this on ms1.SiteNumber equals ms2.SiteNumber
                        select new {Ms1 = ms1, Ms2 = ms2};
            if (query.Count() != msl.Count || query.Count() != this.Count) return false; // missed some elements 
            foreach (var queryResult in query)
            {
                if (queryResult.Ms1.Equals(queryResult.Ms2) == false)
                    return false;
            }
            return true;
        }
    }
}