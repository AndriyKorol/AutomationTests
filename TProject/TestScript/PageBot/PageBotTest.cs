using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;
using static TProject.Settings.ObjectRpository;

namespace TProject.TestScript.PageBot
{
    [TestClass]
    public class PageBotTest
    {
        private static readonly ILog Logger = Log4netHelper.GetXmlLogger(typeof(PageBotTest));

        [TestMethod]
        public void AdminPagesUploading()
        {
            LinkHelper.ClickLink(By.Id("loginLink"));
            InputHelper.InputIntoField(By.Id("LoginEmailAddress"), Config.GetEmail());
            InputHelper.InputIntoField(By.Id("LoginPassword"), Config.GetPassword());
            LinkHelper.ClickLink(By.ClassName("blue-btn"));
            NavigationHelper.NavigateToUrl(Config.GetAdminPage());
            var links = Driver.FindElements(By.CssSelector("[Id*=rPages_]")).Count;
            //IReadOnlyCollection<IWebElement> links2 = ObjectRpository.Driver.FindElements(By.CssSelector("[Id*=rPages_]"));

            for (int i = 0; i < links; i++)
            {
                var link = Driver.FindElements(By.CssSelector("[Id*=rPages_]"))[i];
                Uri myUri = new Uri(link.GetAttribute("href"));
                link.Click();
                List<IWebElement> txt = Driver.FindElements(By.XPath("//body[contains(@class,'')]")).ToList();

                for (int j = 0; j < txt.Count; j++)
                {
                    string s = txt[j].Text;
                    if (!s.Contains("an error occurred"))
                    {
                        Logger.Info("A page is 'Passed': " + myUri);
                    }
                    else
                    {
                        Logger.Error("A page is 'Failed': " + myUri);
                    }
                }
                NavigationHelper.NavigateToUrl(Config.GetAdminPage());
            }
        }

        [TestMethod]
        public void HomePagesUploading()
        {
            var links = Driver.FindElements(By.CssSelector("a")).Count;
            Logger.Info("Number of links: " + links);


            for (int i = 0; i < links; i++)
            {
                try
                {
                    var link = Driver.FindElements(By.CssSelector("a"))[i];
                    Uri myUri = new Uri(link.GetAttribute("href"));

                    if (myUri.Host == "mechanic.boston" && i <= links)
                    {
                        if (link.Displayed == true )
                        {
                            link.Click();
                        }
                        else
                        {
                            Logger.Error("A link was not visible: " + myUri);
                            NavigationHelper.NavigateToUrl(myUri.AbsoluteUri);
                        }

                        if (JSPopUpHelper.IsPopUpPresent())
                        {
                            JSPopUpHelper.GetPopUpText();
                            Logger.Info("Text from pop-up :" + JSPopUpHelper.GetPopUpText());
                        }

                        List<IWebElement> txt = Driver.FindElements(By.XPath("//body[contains(@class,'')]")).ToList();

                        for (int j = 0; j < txt.Count; j++)
                        {
                            string s = txt[j].Text;
                            if (!s.Contains("an error occurred"))
                            {
                                Logger.Info("Link#: " + "[ " + i + " ] - A page is 'Passed': " + myUri);
                            }
                            else
                            {
                                Logger.Error("Link#: " + "[ " + i + " ] - A page is 'Failed': " + myUri);
                            }
                        }
                    }
                    else
                    {
                        Logger.Info("A Host is not a mechanic: " + "[ " + myUri.Host + " ]");
                        NavigationHelper.NavigateBack();
                    }
                }
                catch (Exception e)
                {
                    Logger.Error("Number of link: " + "[ " + i + " ]");
                    Logger.Fatal(e);
                    NavigationHelper.NavigateToUrl(Config.GetWebsite());
                }
            }
        }

        //[TestMethod]
        //public void ShopsPagesUploading()
        //{
        //    LinkHelper.ClickLink(By.Id("loginLink"));
        //    InputHelper.InputIntoField(By.Id("LoginEmailAddress"), Config.GetEmail());
        //    InputHelper.InputIntoField(By.Id("LoginPassword"), Config.GetPassword());
        //    LinkHelper.ClickLink(By.ClassName("blue-btn"));
        //    NavigationHelper.NavigateToUrl("https://mechanic.boston/dashboard-activity");
        //    var links = Driver.FindElements(By.CssSelector("a")).Count;
        //    IReadOnlyCollection<IWebElement> links2 = ObjectRpository.Driver.FindElements(By.CssSelector("[Id*=rPages_]"));

        //    for (int i = 0; i<links; i++)
        //    {
        //        var link = Driver.FindElements(By.CssSelector("a"))[i];
        //        Uri myUri = new Uri(link.GetAttribute("href"));
        //        link.Click();
        //        //List<IWebElement> txt = Driver.FindElements(By.XPath("//body[contains(@class,'')]")).ToList();

        //        for (int j = 0; j<txt.Count; j++)
        //        {
        //            string s = txt[j].Text;
        //            if (!s.Contains("an error occurred"))
        //            {
        //                Logger.Info("A page is 'Passed': " + myUri);
        //            }
        //            else
        //            {
        //                Logger.Error("A page is 'Failed': " + myUri);
        //            }
        //        }
        //        NavigationHelper.NavigateToUrl(Config.GetAdminPage());
        //    }
        //}
    }
}
