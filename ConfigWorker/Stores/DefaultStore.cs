using ConfigWorker.Interfaces;
using System.Configuration;

namespace ConfigWorker.Stores
{
    /// <summary>
    /// Default implementation of IStore for classic desktop apps
    /// </summary>
    class DefaultStore : IStore
    {
        /// <summary>
        /// Get string from store
        /// </summary>
        /// <param name="name">parameter name</param>
        /// <returns></returns>
        public string Get(string name)
        { return ConfigurationManager.AppSettings[name]; }

        /// <summary>
        /// Set string to store
        /// </summary>
        /// <param name="name">parameter name</param>
        /// <param name="value">parameter value</param>
        public void Set(string name, string value)
        {
            Configuration configuration = null;
            try
            {
                configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings.Add(name, value);
            }
            finally
            { configuration?.Save(); }
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
