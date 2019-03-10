using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.WebElements
{
    //[TestClass]
    public class TestFindElements
    {
        [TestMethod]
        public void FindAllElements()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
        }
    }
}
