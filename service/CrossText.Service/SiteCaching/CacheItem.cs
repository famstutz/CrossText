using System;
using System.Runtime.Serialization;

namespace CrossText.Service.SiteCaching
{
    /// <summary>
    /// Item to contain Caching-information
    /// </summary>
    /// <typeparam name="TValue">Type of the value-object</typeparam>
    public class CacheItem<TValue>
    {
        #region Private variables
        private TValue itemValue;
        private DateTime cacheTime;
        #endregion

        #region Public properties
        /// <summary>
        /// Gets the value.
        /// </summary>
        public TValue Value
        {
            get
            {
                return itemValue;
            }
            set
            {
                itemValue = value;
                cacheTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Gets the cache time.
        /// </summary>
        public DateTime CacheTime
        {
            get
            {
                return cacheTime;
            }
            set
            {
                cacheTime = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheItem&lt;TValue&gt;"/> class.
        /// </summary>
        public CacheItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheItem&lt;TValue&gt;"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public CacheItem(TValue value)
        {
            Value = value;
        }
        #endregion
    }
}