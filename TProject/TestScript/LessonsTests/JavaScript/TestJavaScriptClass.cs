using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using static TProject.Settings.ObjectRpository;

namespace TProject.TestScript.JavaScript
{
    //[TestClass]
    public class TestJavaScriptClass
    {
        private static readonly ILog Logger = Log4netHelper.GetXmlLogger(typeof(TestJavaScriptClass));
        [TestMethod, TestCategory("Smoke")]
        public void TestJS()
        {
            try
            {
                NavigationHelper.NavigateToUrl(Config.GetWebsite());
                LinkHelper.ClickLink(By.Id("loginLink"));
                IJavaScriptExecutor executor = ((IJavaScriptExecutor)Driver);
                executor.ExecuteScript("document.getElementById('LoginEmailAddress').value='qa@byteant.com'");
                executor.ExecuteScript("document.getElementById('LoginPassword').value='test'");
                //cannot click on button with classname
                executor.ExecuteScript("document.getElementById('RegisterButton').click();");
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace);
                throw;
            }
        }

        [TestMethod]
        public void TestJSScrol()
        {
            NavigationHelper.NavigateToUrl(Config.GetWebsite());
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)Driver);
            IWebElement el = Driver.FindElement(By.LinkText("Community"));
            executor.ExecuteScript("window.scrollTo(0, " + el.Location.Y + ")");
            
            el.Click();
        }

        [TestMethod]
        public void FindAllElements()
        {
            NavigationHelper.NavigateToUrl(Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("loginLink"));
            InputHelper.InputIntoField(By.Id("LoginEmailAddress"), Config.GetEmail());
            InputHelper.InputIntoField(By.Id("LoginPassword"), Config.GetPassword());
            LinkHelper.ClickLink(By.ClassName("blue-btn"));
            NavigationHelper.NavigateToUrl("https://mechanic.boston/Administrators/default.aspx");
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
                        Logger.Info("Page passed: " + myUri);
                        NavigationHelper.NavigateToUrl("https://mechanic.boston/Administrators/default.aspx");
                    }
                    else
                    {
                        Logger.Error("Page has an error: " + myUri);
                        NavigationHelper.NavigateToUrl("https://mechanic.boston/Administrators/default.aspx");
                    }
                }



                //try
                //{

                //    // Creates an HttpWebRequest for the specified URL. 
                //    HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(myUri);

                //    // Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //    // Sends the HttpWebRequest and waits for a response.
                //    HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                //    StreamReader sr = new StreamReader(myHttpWebResponse.GetResponseStream());
                //    Console.WriteLine(sr.ReadToEndAsync());
                //    if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                //        Console.WriteLine("\r\nResponse Status " + myUri + "is OK and StatusDescription is: {0}",
                //            myHttpWebResponse.StatusDescription);
                //    // Releases the resources of the response.
                //    myHttpWebResponse.Close();

                //}
                //catch (WebException e)
                //{
                //    Console.WriteLine("\r\nWebException Raised. The following error occured : {0}", e.Status);
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine("\nThe following Exception was raised : {0}", e.Message);
                //}

                //NavigationHelper.NavigateToUrl("https://mechanic.boston/Administrators/default.aspx");
            }




            
        }
    }
}
