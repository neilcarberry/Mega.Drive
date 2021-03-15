namespace Infrastructure.CacheInterfaces
{
    public interface ICache
    {
        #region Public Methods

        /// <summary>
        /// Adds an item to the cache and fails if it already exists
        /// </summary>
        /// <typeparam name="T">The generic type</typeparam>
        /// <param name="key">The key to look up the object later</param>
        /// <param name="objectToCache">The object to add to the cache</param>
        void Add<T>(string key, T objectToCache);

        /// <summary>
        /// Gets an item from the cache with the specified key
        /// </summary>
        /// <typeparam name="T">The type to cast to</typeparam>
        /// <param name="key">The key to search for</param>
        /// <returns>An object of the specified type</returns>
        T Get<T>(string key);

        /// <summary>
        /// Removes an items with the specified key from the cache
        /// </summary>
        /// <param name="key">The key to remove</param>
        /// <param name="patternMatch">Are we using a pattern match</param>
        void Remove(string key, bool patternMatch = true);

        /// <summary>
        /// Does the key exist in the cache
        /// </summary>
        /// <param name="key">The ket to test</param>
        /// <returns>Whether the cache item exists or not</returns>
        bool Exists(string key);

        #endregion
    }
}
