using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TProject.Configuration;

namespace TProject.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetEmail();
        string GetPassword();
        string GetWebsite();
        string GetAdminPage();
        string GetShopManager();

        int GetElementLoadTimeout();
    }
}
