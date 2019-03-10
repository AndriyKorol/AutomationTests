using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Configuration;
using TProject.Interfaces;
using TProject.Settings;

namespace TProject
{
    //[TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());

            try
            {
                ObjectRpository.Driver.FindElement(By.Id("loginLink"));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
                throw;
            }
            

        }

    }
}
