using System.Collections.ObjectModel;
using OpenQA.Selenium;
using TProject.Settings;

namespace TProject.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRpository.Driver.Manage().Window.Maximize();
        }

        public static void BrowserGoBack()
        {
            ObjectRpository.Driver.Navigate().Back();
        }

        public static void BrowserForward()
        {
            ObjectRpository.Driver.Navigate().Forward();
        }

        public static void BrowserRefresh()
        {
            ObjectRpository.Driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index)
        {
            ReadOnlyCollection<string> windows = ObjectRpository.Driver.WindowHandles;

            if (windows.Count < index)
            {
                throw new NoSuchElementException("Invalid Browser Windows index" + index);
            }

            ObjectRpository.Driver.SwitchTo().Window(windows[index]);
            BrowserMaximize();
        }

        public static void SwitchToParentWindow()
        {
            var window = ObjectRpository.Driver.WindowHandles;

            for (int i = window.Count; i > 0; i--)
            {
                ObjectRpository.Driver.Close();
                ObjectRpository.Driver.SwitchTo().Window(window[i]);
            }
            ObjectRpository.Driver.SwitchTo().Window(window[0]);
        }

        public static void SwitchToFrame(By locator)
        {
            ObjectRpository.Driver.SwitchTo().Frame(ObjectRpository.Driver.FindElement(locator));
        }
    }
}
