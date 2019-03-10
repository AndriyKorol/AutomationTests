using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using TProject.BaseClasses;
using TProject.ComponentHelper;


namespace TProject.PageObject
{
    public class HomePage : PageBase
    {
        private IWebDriver driver;
        
        #region WebElements

        [FindsBy(How = How.Id, Using = "loginLink")]
        public IWebElement LoginBtn;

        [FindsBy(How = How.Name, Using = "Welcome back,")]
        public IWebElement IsLogged;

        [FindsBy(How = How.LinkText, Using = "FIND A REPAIR SHOP")]
        public IWebElement FindShop;

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-sign-out']")]
        public IWebElement LogOut;

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-sign-out']")]
        public IWebElement ShopOwner;


        #endregion

        public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Actions

        public HomePage LogOutUser()
        {
            GenericHelper.HoverToAnElement(By.XPath("//*[contains(text(), 'Welcome back')]"));
            LogOut.Click();
            return new HomePage(driver);
        }

        #endregion

        #region Navigation

        public LoginPage GoToLoginPage()
        {
            //Console.WriteLine(WebElementExtensions.GetAttributeOfElement(LoginBtn));
            LoginBtn.Click();
            return new LoginPage(driver);
        }

        public FindARepairShop GoToFindARepairShopPage()
        {
            FindShop.Click();
            return new FindARepairShop(driver);
        }
        
        #endregion
    }
}
