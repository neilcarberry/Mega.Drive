using System;

namespace Infrastructure.CacheImplementations
{
    #region Usings

    using Infrastructure.CacheInterfaces;

    #endregion

    public class NoopCache : ICache
    {
        #region Interface Implementations

        public void Add<T>(string key, T objectToCache, TimeSpan cachetime)
        {
        }

        public T Get<T>(string key)
        {
            return default(T);
        }

        public void Remove(string key, bool patternMatch = true)
        {
        }

        public bool Exists(string key)
        {
            return false;
        }

        #endregion
    }
}
