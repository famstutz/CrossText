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

    }
}