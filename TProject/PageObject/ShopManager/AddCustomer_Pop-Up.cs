using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TProject.BaseClasses;
using TProject.ComponentHelper;

namespace TProject.PageObject.ShopManager
{
    public class AddCustomer_Pop_Up
    {
        private IWebDriver driver;

        #region WebElements
        [FindsBy(How = How.ClassName, Using = "username")]
        public IWebElement UserName;

        #endregion


        #region Actions


        #endregion


        #region Navigation


        #endregion
    }
}
