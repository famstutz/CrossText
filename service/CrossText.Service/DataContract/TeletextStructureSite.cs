using System.Runtime.Serialization;
using System.Collections.Generic;

namespace CrossText.Service.DataContract
{
    /// <summary>
    /// This DataContract represents the structure of one Teletext-site
    /// </summary>
    [DataContract]
    public class TeletextStructureSite
    {
        #region Properties
        /// <summary>
        /// Gets or sets the site number.
        /// </summary>
        /// <value>
        /// The site number.
        /// </value>
        [DataMember]
        public int SiteNumber
        { 
            get;
            set; 
        }

        /// <summary>
        /// Gets or sets the sub sites.
        /// </summary>
        /// <value>
        /// The sub sites.
        /// </value>
        [DataMember]
        public List<int> SubSites 
        { 
            get;
            set; 
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TeletextStructureSite"/> class.
        /// </summary>
        public TeletextStructureSite()
        {
            this.SubSites = new List<int>();
        }
        #endregion
    }
}