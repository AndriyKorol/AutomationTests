using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TProject.ComponentHelper;
using TProject.Configuration;
using TProject.CustomExeption;
using TProject.Settings;

namespace TProject.BaseClasses
{
    [TestClass]
    public class BaseClass
    {

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            //install some extensions for browser e.g. using postman extansion file
            //option.AddExtension(@"C:\Users\extension_3_0_12.crx");
            return option;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRpository.Config = new AppConfigReader();

            switch (ObjectRpository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRpository.Driver = GetChromeDriver();
                    NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
                    break;
                case BrowserType.Firefox:
                    ObjectRpository.Driver = GetFirefoxDriver();
                    NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
                    break;
                default:
                    throw new NoSutiableDriverFound("A Driver is not found: " + ObjectRpository.Config.GetBrowser().ToString());
            }

            ObjectRpository.Driver.Manage()
                .Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRpository.Config.GetElementLoadTimeout());
            BrowserHelper.BrowserMaximize();
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRpository.Driver != null)
            {
                ObjectRpository.Driver.Close();
                ObjectRpository.Driver.Quit();
            }
        }
    }
}
