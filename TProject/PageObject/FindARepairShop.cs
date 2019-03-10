using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TProject.BaseClasses;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.PageObject
{
    public class FindARepairShop : PageBase
    {
        private IWebDriver driver;

        #region WebElements

        [FindsBy(How = How.Id, Using = "loginLink")]
        private IWebElement LoginBtn;

        [FindsBy(How = How.Id, Using = "txtSearchRepair")]
        private IWebElement FindByServiceField;

        [FindsBy(How = How.Id, Using = "txtSearchByLoc")]
        private IWebElement FindByLocationField;

        [FindsBy(How = How.Id, Using = "btnRepairSearch")]
        private IWebElement SearchBtn;

        #endregion

        public FindARepairShop(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Actions

        public void SearchByService(string text)
        {
            FindByServiceField.SendKeys(text);
            SearchBtn.Click();
        }

        #endregion

        #region Navigation

        public LoginPage NavigateToLoginPage()
        {
            LoginBtn.Click();
            return new LoginPage(driver);
        }

        #endregion
    }
}
