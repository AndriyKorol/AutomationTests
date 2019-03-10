using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using static TProject.ComponentHelper.InputHelper;
using static TProject.ComponentHelper.LinkHelper;
using static TProject.ComponentHelper.NavigationHelper;
using static TProject.Settings.ObjectRpository;


namespace TProject.TestScript.TestWait
{
    //[TestClass]
    public class TestImpWait
    {
        [TestMethod]
        public void TestWait()
        {
            NavigateToUrl(Config.GetWebsite());
            ClickLink(By.Id("loginLink"));
            InputIntoField(By.Id("LoginEmailAddress"), Config.GetEmail());
            InputIntoField(By.Id("LoginPassword"), Config.GetPassword());


        }
    }
}
