using System.ServiceModel;
using System.ServiceModel.Web;
using CrossText.Service.DataContract;

namespace CrossText.Service
{
    /// <summary>
    /// The interface for the CrossText.Service web service
    /// </summary>
    [ServiceContract]
    public interface ICrossTextService
    {
        /// <summary>
        /// Gets the teletext site.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        [OperationContract]
        [WebGet]
        string GetTeletextSite(int number);

        /// <summary>
        /// Gets the teletext sub site.
        /// </summary>
        /// <param name="SiteNumber">The site number.</param>
        /// <param name="subSiteNumber">The sub site number.</param>
        /// <returns></returns>
        [OperationContract]
        [WebGet]
        string GetTeletextSubSite(int SiteNumber, int subSiteNumber);

        /// <summary>
        /// Gets the teletext structure.
        /// </summary>
        /// <param name="SiteNumber">The site number.</param>
        /// <returns></returns>
        [OperationContract]
        [WebGet]
        TeletextStructureSite GetTeletextStructure(int SiteNumber);

        /// <summary>
        /// Gets the menu structure.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebGet]
        MenuStructureList GetMenuStructure();

    }

}
