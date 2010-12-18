using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrossText.Service.DataContract;

namespace CrossText.Service.MenuStructureLoader
{
    interface IMenuStructureLoader
    {
        MenuStructureList LoadMenuStructures();
    }
}
