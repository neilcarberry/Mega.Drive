namespace Infrastructure.CacheImplementations
{
    #region Usings

    using System.Net.Http;

    #endregion

    public class RuntimeCacheWithRemoteRemoval : RuntimeCache
    {
        #region Fields

        private readonly string _hubUrl;

        #endregion

        #region Constructors

        public RuntimeCacheWithRemoteRemoval()
        {
            //_hubUrl = ConfigSettingsRepository.GetSettingValue("SignalRHubUrl", string.Empty, false);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Removes an items with the specified key from the cache
        /// </summary>
        /// <param name="key">The key to remove</param>
        /// <param name="patternMatch">Are we using a pattern match</param>
        public override void Remove(string key, bool patternMatch = true)
        {
            base.Remove(key, patternMatch);

            HttpClient client = new HttpClient();

            client.PostAsync($"{_hubUrl}/Cache/Remove?key={key}&patternMatch={patternMatch}", new StringContent(string.Empty));
        }

        #endregion
    }
}
