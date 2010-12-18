
using System.Runtime.Serialization;

namespace CrossText.Service.DataContract
{
    /// <summary>
    /// Contract used in case there is a fault present
    /// </summary>
    public class FaultContract
    {
        #region Properties
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [DataMember]
        public string Message
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets the stack trace.
        /// </summary>
        /// <value>
        /// The stack trace.
        /// </value>
        [DataMember]
        public string StackTrace 
        {
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [DataMember]
        public string Source
        {
            get; 
            set; 
        }
        #endregion
    }
}