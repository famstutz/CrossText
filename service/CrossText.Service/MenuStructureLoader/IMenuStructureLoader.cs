using CrossText.Service.DataContract;

namespace CrossText.Service.MenuStructureLoader
{
    /// <summary>
    /// Provides the functionality to load MenuStructures-items
    /// </summary>
    interface IMenuStructureLoader
    {
        /// <summary>
        /// Loads the menu structures.
        /// </summary>
        /// <returns></returns>
        MenuStructureList LoadMenuStructures();
    }
}
