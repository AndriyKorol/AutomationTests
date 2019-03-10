using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.HyperLink
{
    //[TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            //IWebElement element = ObjectRpository.Driver.FindElement(By.Id("loginLink"));
            //element.Click();

            LinkHelper.ClickLink(By.Id("loginLink"));
        }
    }
}
