using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrossText.Service.Serialization;
using System.Xml.Serialization;

namespace CrossText.Service.SiteCaching
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public sealed class SerializableSiteCache<TKey, TValue> : ISiteCache<TKey, TValue>, IXmlSerializable
    {
        #region Member variables
        /// <summary>
        /// The singleton instance of this class
        /// </summary>
        private static SerializableSiteCache<TKey, TValue> instance;
        /// <summary>
        /// The padlock to determine locking status
        /// </summary>
        private static readonly object padlock = new object();
        #endregion 

        #region Private properties
        /// <summary>
        /// Gets or sets the dictionary.
        /// </summary>
        /// <value>
        /// The dictionary.
        /// </value>
        private SerializableDictionary<TKey, TValue> Dictionary
        {
            get;
            set;
        }
        #endregion

        #region Singleton
        /// <summary>
        /// Prevents a default instance of the <see cref="SerializableSiteCache&lt;TKey, TValue&gt;"/> class from being created.
        /// </summary>
        private SerializableSiteCache()
        {
            if (Dictionary == null)
                this.Clear();
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static SerializableSiteCache<TKey, TValue> Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new SerializableSiteCache<TKey, TValue>();

                    return instance;
                }
            }
        }
        #endregion

        #region Implemented Methods from ISiteCache<TKey, TValue>
        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            Dictionary = new SerializableDictionary<TKey, TValue>();
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

            TValue value;
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
        /// Inserts the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Insert(TKey key, TValue value)
        {
            Dictionary.Add(key, value);
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
                return Dictionary.Count;
            }
        }

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
            return Dictionary.ContainsKey(key);
        }
        #endregion

        #region Implemented Methods from IXmlSeralizable
        /// <summary>
        /// Gets the schema.
        /// </summary>
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> stream from which the object is deserialized.</param>
        public void ReadXml(System.Xml.XmlReader reader)
        {
            Dictionary.ReadXml(reader);
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"/> stream to which the object is serialized.</param>
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            Dictionary.WriteXml(writer);
        }
        #endregion
    }
}