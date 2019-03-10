using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TProject.Interfaces;
using TProject.Settings;

namespace TProject.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType) Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetEmail()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Email);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }

        public string GetAdminPage()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.AdminPage);
        }

        public string GetShopManager()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.ShopManager);
        }

        public int GetElementLoadTimeout()
        {
            string elementTimeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementLoadTimeOut);
            if (elementTimeout == null)
            {
                return 4;
            }
            else
            {
                return Convert.ToInt32(elementTimeout);
            }
        }
    }
}
