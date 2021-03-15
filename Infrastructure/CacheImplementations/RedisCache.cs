namespace Infrastructure.CacheImplementations
{
    #region Usings

    using System;
    using System.Linq;
    using Infrastructure.CacheInterfaces;
    using Newtonsoft.Json;

    #endregion

    public class RedisCache : ICache
    {
        #region Fields

        //private readonly TimeSpan _dataCacheTime;
        //private readonly ConnectionMultiplexer _redisConnections;

        #endregion

        #region Constructors

        public RedisCache()
        {
            //_redisConnections = ConnectionMultiplexer.Connect(Config.ReadConfigurationSetting("Redis-Database-ConnectionString", string.Empty));
            //_dataCacheTime = new TimeSpan(0, ConfigSettingsRepository.GetSettingValue("DataCacheTime", 0, false), 0);
        }

        #endregion

        #region Interface Implementations

        /// <summary>
        /// Adds an item to the cache and fails if it already exists
        /// </summary>
        /// <typeparam name="T">The generic type</typeparam>
        /// <param name="key">The key to look up the object later</param>
        /// <param name="objectToCache">The object to add to the cache</param>
        /// <param name="serializerSettings">Optional json serializer settings</param>
        public void Add<T>(string key, T objectToCache)
        {
            //try
            //{
            //    var db = _redisConnections.GetDatabase();
            //    db.StringSet(key, _dataCacheTime);
            //}
            //catch (RedisException rex)
            //{
            //    Log.Error(rex);
            //}
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
            //try
            //{
            //    var db = _redisConnections.GetDatabase();
            //    var redisObject = db.StringGet(key);

            //    if (redisObject.HasValue)
            //    {
            //        return JsonConvert.DeserializeObject<T>(redisObject, serializerSettings);
            //    }
            //}
            //catch (RedisException rex)
            //{
            //    Log.Error(rex);
            //}

            return default(T);
        }

        /// <summary>
        /// Removes an items with the specified key from the cache
        /// </summary>
        /// <param name="key">The key to remove</param>
        /// <param name="patternMatch">Are we using a pattern match</param>
        public void Remove(string key, bool patternMatch = true)
        {
            //try
            //{
            //    var db = _redisConnections.GetDatabase();

            //    if (patternMatch)
            //    {
            //        foreach (var endpoint in _redisConnections.GetEndPoints())
            //        {
            //            var server = _redisConnections.GetServer(endpoint);
            //            var keys = server.Keys(db.Database, "*" + key + "*").ToArray();
            //            db.KeyDelete(keys);
            //        }
            //    }
            //    else
            //    {
            //        if (db.KeyExists(key))
            //        {
            //            db.KeyDelete(key);
            //        }
            //    }
            //}
            //catch (RedisException rex)
            //{
            //    Log.Error(rex);
            //}
        }

        /// <summary>
        /// Does the key exist in the cache
        /// </summary>
        /// <param name="key">The ket to test</param>
        /// <returns>Whether the cache item exists or not</returns>
        public bool Exists(string key)
        {
            //try
            //{
            //    var db = _redisConnections.GetDatabase();
            //    return db.KeyExists(key);
            //}
            //catch (RedisException rex)
            //{
            //    Log.Error(rex);
            //}

            return false;
        }

        #endregion
    }
}
