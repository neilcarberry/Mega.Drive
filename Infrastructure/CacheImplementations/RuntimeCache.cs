namespace Infrastructure.CacheImplementations
{
    #region Usings

    using System;
    using System.Collections;
    using System.Linq;
    using System.Text.Json;
    using Infrastructure.CacheInterfaces;
    using Microsoft.Extensions.Caching.Memory;

    #endregion

    public class RuntimeCache : ICache
    {
        #region Fields

        private readonly int _dataCacheTime;
        private IMemoryCache Cache;

        #endregion

        #region Constructors

        public RuntimeCache()
        {
            Cache = new MemoryCache(new MemoryCacheOptions()); 
            //_dataCacheTime = ConfigSettingsRepository.GetSettingValue("DataCacheTime", 0, false);
        }

        #endregion

        #region Interface Implementations

        /// <summary>
        /// Adds an item to the cache and overwrites if it already exists
        /// </summary>
        /// <typeparam name="T">The generic type</typeparam>
        /// <param name="key">The key to look up the object later</param>
        /// <param name="objectToCache">The object to add to the cache</param>
        /// <param name="serializerSettings">Optional json serializer settings</param>
        public void Add<T>(string key, T objectToCache)
        {
            Cache.Set(key, objectToCache);
        }

        /// <summary>
        /// Gets an item from the cache with the specified key
        /// </summary>
        /// <typeparam name="T">The type to cast to</typeparam>
        /// <param name="key">The key to search for</param>
        /// <param name="serializerSettings">Optional json serializer settings</param>
        /// <returns>An object of the specified type</returns>
        public T Get<T>(string key)
        {
            var cacheObject = Cache.Get(key);

            if (cacheObject != null)
            {
                return JsonSerializer.Deserialize<T>(cacheObject.ToString());
            }

            return default(T);
        }

        /// <summary>
        /// Removes an items with the specified key from the cache
        /// </summary>
        /// <param name="key">The key to remove</param>
        /// <param name="patternMatch">Are we using a pattern match</param>
        public virtual void Remove(string key, bool patternMatch = true)
        {
            if (patternMatch)
            {
                //foreach (DictionaryEntry entry in HttpRuntime.Cache.Cast<DictionaryEntry>().Where(entry => entry.Key.ToString().Contains(key)))
                //{
                //    // Delete each cache item that matches
                //    HttpRuntime.Cache.Remove(entry.Key.ToString());
                //}
            }
            else
            {
                Cache.Remove(key);
            }
        }

        /// <summary>
        /// Does the key exist in the cache
        /// </summary>
        /// <param name="key">The ket to test</param>
        /// <returns>Whether the cache item exists or not</returns>
        public bool Exists(string key)
        {
            return Cache.Get(key) != null;
        }

        #endregion
    }
}
