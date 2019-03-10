using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TProject.BaseClasses;


namespace TProject.PageObject.ShopManager
{
    public class ShopManagerLeftMenu : PageBase
    {
        private IWebDriver driver;

        #region WebElements
        [FindsBy(How = How.Name, Using = "HIDE MENU")]
        public IWebElement HideMenu;
        [FindsBy(How = How.Id, Using = "DashboardPageLink")]
        public IWebElement Dashboard_Section;
        [FindsBy(How = How.Id, Using = "ShopPageLink")]
        public IWebElement WebListing_Section;
        [FindsBy(How = How.CssSelector, Using = "div.container:nth-child(3) div.menu-slide section.menu-section-sub-items:nth-child(3) ul.menu-sub-items-list.js-menu-sub-items li:nth-child(1) > a.selected-sub-item")]
        public IWebElement DashboardActivity_Section;
        [FindsBy(How = How.CssSelector, Using = "div.container:nth-child(3) div.menu-slide section.menu-section-sub-items:nth-child(3) ul.menu-sub-items-list.js-menu-sub-items li:nth-child(2) > a:nth-child(1)")]
        public IWebElement DashboardReports_Section;
        [FindsBy(How = How.Id, Using = "SchedulePageLink")]
        public IWebElement Scheduler_Section;
        [FindsBy(How = How.Id, Using = "MessagesPageLink")]
        public IWebElement Me_Section;
        [FindsBy(How = How.Id, Using = "CampaignViewerPageLink")]
        public IWebElement Campaigns_Section;
        [FindsBy(How = How.Id, Using = "NotificationPageLink")]
        public IWebElement Notifications_Section;
        [FindsBy(How = How.Id, Using = "ReputationPageLink")]
        public IWebElement Reputation_Section;
        [FindsBy(How = How.Id, Using = "SettingPageLink")]
        public IWebElement Settings_Section;

        #endregion

        public ShopManagerLeftMenu(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver; 
        }


        #region Actions



        #endregion

        #region Navigation
        public HomePage NavigateToHomePage()
        {
            
            return new HomePage(driver);
        }

        #endregion
    }
}
