using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TProject.Settings;

namespace TProject.ComponentHelper
{
    //It's wrapper
    //will be include different method to hendeal different type of navigation
    public class NavigationHelper
    {
        public static void NavigateToUrl(string Url)
        {
            ObjectRpository.Driver.Navigate().GoToUrl(Url);
        }

        public static void NavigateBack()
        {
            ObjectRpository.Driver.Navigate().Back();
        }

        public static void NavigateForward()
        {
            ObjectRpository.Driver.Navigate().Forward();
        }

        public static void NavigateRefresh()
        {
            ObjectRpository.Driver.Navigate().Refresh();
        }

        internal static void NavigateToUrl(object p)
        {
            throw new NotImplementedException();
        }
    }
}
