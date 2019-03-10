using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TProject.ComponentHelper;

namespace TProject.BaseClasses
{
    public class PageBase
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "logo")]
        private IWebElement HomeLink;

        //constructor which will initialize element 
        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
        }

        protected void Logout()
        {
            if (GenericHelper.IsElementPresent(By.Id("id of logout button")))
            {
                ButtonHelper.ClickButton(By.Id("id of logout button"));
            }
        }

        protected void NavigateToHomePage()
        {
            HomeLink.Click();
        }
    }
}
