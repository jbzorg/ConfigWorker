using ConfigWorker.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConfigWorker.Stores
{
    /// <summary>
    /// Default implementation of IStore
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
                if ((HttpContext.Current != null) && (!HttpContext.Current.Request.PhysicalPath.Equals(string.Empty)))
                { configuration = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~"); }
                else
                { configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); }

                configuration.AppSettings.Settings.Add(name, value);
            }
            finally
            {
                if (configuration != null)
                { configuration.Save(); }
            }
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
