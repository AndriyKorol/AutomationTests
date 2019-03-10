using System;
using log4net.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.PageObject;
using TProject.Settings;

namespace TProject.TestScript.PageObject
{
    [TestClass]
    public class Test_logIn
    {
        private IWebDriver driver;
        [TestMethod]
        public void Test_Valid_LogIn()
        {
            HomePage homePage = new HomePage(ObjectRpository.Driver);
            WebElementExtensions.GetAttributeOfElement(homePage.LoginBtn);
            LoginPage loginPage = homePage.GoToLoginPage();
            homePage = loginPage.LogIn(ObjectRpository.Config.GetEmail(), ObjectRpository.Config.GetPassword());
            GenericHelper.IsElementPresent(By.XPath("//*[contains(text(), 'Welcome back')]"));
            
        }

        [TestMethod]
        public void Test_Invalid_LogIn_Email()
        {
            HomePage homePage = new HomePage(ObjectRpository.Driver);
            if (GenericHelper.IsElementPresent(By.XPath("//*[contains(text(), 'Welcome back')]")))
            {
                homePage.LogOutUser();
            }
            LoginPage loginPage = homePage.GoToLoginPage();
            homePage = loginPage.LogIn("3423sdfdf", "incorrect password");
            GenericHelper.IsElementPresent(By.XPath("//*[contains(text(), 'Email format is not accepted')]"));
        }

        [TestMethod]
        public void Test_Invalid_LogIn_Password()
        {
            HomePage homePage = new HomePage(ObjectRpository.Driver);
            if (GenericHelper.IsElementPresent(By.XPath("//*[contains(text(), 'Welcome back')]")))
            {
                homePage.LogOutUser();
            }
            LoginPage loginPage = homePage.GoToLoginPage();
            homePage = loginPage.LogIn(ObjectRpository.Config.GetEmail(), "incorrect password");
            GenericHelper.IsElementPresent(By.XPath("//*[contains(text(), 'password and username do not match')]"));
        }
        
    }
}
