using System;
using System.Runtime.Serialization;

namespace CrossText.Service.DataContract
{
    /// <summary>
    /// Reprents a menu-item
    /// </summary>
    [DataContract]
    public class MenuStructure
    {
        #region Properties
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [DataMember]
        public string Title
        {
            get; 
            set; 
        }

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
        #endregion

        #region Public Methods
        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;
            
            MenuStructure ms = (MenuStructure)obj;
           
            if (!Object.Equals(SiteNumber, ms.SiteNumber)) 
                return false;
            if (!Object.Equals(Title, ms.Title)) 
                return false;

            return true;
        }
        #endregion
    }


}