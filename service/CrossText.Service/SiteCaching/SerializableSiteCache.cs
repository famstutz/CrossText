using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrossText.Service.Serialization;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace CrossText.Service.SiteCaching
{
    /// <summary>
    /// Serializable Cache for SiteCache-items
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public sealed class SerializableSiteCache<TKey, TValue> : ISiteCache<TKey, TValue>, IDisposable
    {
        #region Private properties
        /// <summary>
        /// Gets or sets the dictionary.
        /// </summary>
        /// <value>
        /// The dictionary.
        /// </value>
        private SerializableDictionary<TKey, CacheItem<TValue>> Dictionary
        {
            get;
            set;
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Gets or sets the XML file path.
        /// </summary>
        /// <value>
        /// The XML file path.
        /// </value>
        public String XmlFilePath
        {
            get;
            set;
        }
        #endregion

        #region Implemented Properties from ISiteCache<TKey, TValue>
        /// <summary>
        /// Gets or sets the expiry span.
        /// </summary>
        /// <value>
        /// The expiry span.
        /// </value>
        public TimeSpan ExpirySpan
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableSiteCache&lt;TKey, TValue&gt;"/> class.
        /// </summary>
        public SerializableSiteCache(String xmlFilePath)
        {
            Dictionary = new SerializableDictionary<TKey, CacheItem<TValue>>();

            XmlFilePath = xmlFilePath;

            if (File.Exists(XmlFilePath))
                ReadSerializedXml();
            
            if (ExpirySpan == default(TimeSpan))
                ExpirySpan = new TimeSpan(0, 1, 0, 0, 0); // Initialize an the expiry timespan of 1 hour
        }
        #endregion

        #region Deconstructor
        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="SerializableSiteCache&lt;TKey, TValue&gt;"/> is reclaimed by garbage collection.
        /// </summary>
        ~SerializableSiteCache()
        {
            Dispose();
        }
        #endregion

        #region Implemented Methods from ISiteCache<TKey, TValue>
        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            Dictionary = new SerializableDictionary<TKey, CacheItem<TValue>>();
        }

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public TValue Get(TKey key)
        {
            if (!ContainsKey(key))
                throw new ApplicationException(String.Format("Cache does not contain key '{0}'", key.ToString()));

            if (IsExpired(key))
                throw new ApplicationException(String.Format("Value of key '{0}' is expired", key));

            return GetItem(key).Value;
        }

        /// <summary>
        /// Inserts the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Insert(TKey key, TValue value)
        {
            // If the current key is already expired, remove it from the cache
            if (ContainsKey(key) || IsExpired(key))
                Dictionary.Remove(key);

            Dictionary.Add(key, new CacheItem<TValue>(value));
        }

        /// <summary>
        /// Removes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        public void Remove(TKey key)
        {
            Dictionary.Remove(key);
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        public int Count
        {
            get
            {
                return Dictionary.Values.Count;
            }
        }

        /// <summary>
        /// Gets the keys.
        /// </summary>
        public List<TKey> Keys
        {
            get
            {
                return Dictionary.Keys.ToList();
            }
        }

        /// <summary>
        /// Determines whether the specified key contains key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if the specified key contains key; otherwise, <c>false</c>.
        /// </returns>
        public bool ContainsKey(TKey key)
        {
            if (!Dictionary.ContainsKey(key))
                return false;
            return !IsExpired(key);
        }

        /// <summary>
        /// Determines whether the specified key is expired.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if the specified key is expired; otherwise, <c>false</c>.
        /// </returns>
        public bool IsExpired(TKey key)
        {
            if (!Dictionary.ContainsKey(key))
                return false;

            CacheItem<TValue> item = GetItem(key);
            if ((item.CacheTime + ExpirySpan) < DateTime.Now)
                return true;
            return false;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        private CacheItem<TValue> GetItem(TKey key)
        {
            CacheItem<TValue> value;
            try
            {
                Dictionary.TryGetValue(key, out value);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(String.Format("Could not extract value of key '{0}' from cache", key.ToString()), ex);
            }
            return value;
        }

        /// <summary>
        /// Writes the serialized XML.
        /// </summary>
        private void WriteSerializedXml()
        {
            XmlWriter writer = XmlWriter.Create(XmlFilePath);
            try
            {
                Dictionary.WriteXml(writer);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(String.Format("Could not write to XML-file '{0}'", XmlFilePath), ex);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads the serialized XML.
        /// </summary>
        /// <returns>The loaded Dictionary</returns>
        private void ReadSerializedXml()
        {
            if (!File.Exists(XmlFilePath))
                throw new ApplicationException(String.Format("Supplied XML-file '{0}' does not exist", XmlFilePath));

            XmlReader reader = XmlReader.Create(XmlFilePath);
            try
            {
                Dictionary.ReadXml(reader);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(String.Format("Could not load from XML-file '{0}'", XmlFilePath), ex);
            }
            finally
            {
                reader.Close();
            }
        }
        #endregion

        #region Implemented Methods from IDisposable
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (Count > 0)
                WriteSerializedXml();
        }
        #endregion
    }
}