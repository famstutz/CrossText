using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossText.Service.SiteCaching
{
    /// <summary>
    /// Implements a caching mechanism for the given key and value-pair.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public interface ISiteCache<TKey, TValue>
    {
        /// <summary>
        /// Gets the count.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets the keys.
        /// </summary>
        List<TKey> Keys { get; }

        /// <summary>
        /// Gets or sets the expiry span.
        /// </summary>
        /// <value>
        /// The expiry span.
        /// </value>
        TimeSpan ExpirySpan { get; set; }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines whether the specified key contains key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if the specified key contains key; otherwise, <c>false</c>.
        /// </returns>
        bool ContainsKey(TKey key);

        /// <summary>
        /// Determines whether the specified key is expired.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if the specified key is expired; otherwise, <c>false</c>.
        /// </returns>
        bool IsExpired(TKey key);

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        TValue Get(TKey key);

        /// <summary>
        /// Inserts the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        void Insert(TKey key, TValue value);

        /// <summary>
        /// Removes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        void Remove(TKey key);
    }
}