using ConfigWorker.Interfaces;
using System.Collections.Concurrent;
using System.Configuration;
using System.Web.Configuration;

namespace ConfigWorker.Web.Stores
{
    /// <summary>
    /// Implementation of IStore for web apps based asp.net
    /// </summary>
    public class WebAppStore : IStore
    {
        private ConcurrentDictionary<string, string> cache = new ConcurrentDictionary<string, string>(); // cache for new records

        /// <summary>
        /// Instance of WebAppStore
        /// </summary>
        public static WebAppStore Instance { get; } = new WebAppStore();

        /// <summary>
        /// Private constructor for singleton
        /// </summary>
        private WebAppStore() { }

        /// <summary>
        /// Get string from store
        /// </summary>
        /// <param name="name">parameter name</param>
        /// <returns></returns>
        public string Get(string name)
        {
            string res;
            if (cache.TryGetValue(name, out res)) return res;
            else return WebConfigurationManager.AppSettings[name];
        }

        /// <summary>
        /// Set string to store
        /// </summary>
        /// <param name="name">parameter name</param>
        /// <param name="value">parameter value</param>
        public void Set(string name, string value)
        {
            if (!cache.ContainsKey(name))
            {
                Configuration configuration = null;
                try
                {
                    configuration = WebConfigurationManager.OpenWebConfiguration("~");
                    configuration.AppSettings.Settings.Add(name, value);
                    cache.TryAdd(name, value);
                }
                finally
                {
                    { configuration?.Save(); }
                }
            }
        }
    }
}
