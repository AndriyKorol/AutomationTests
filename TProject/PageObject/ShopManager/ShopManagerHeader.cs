using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TProject.BaseClasses;
using TProject.ComponentHelper;

namespace TProject.PageObject
{
    public class ShopManagerHeader:PageBase
    {
        private IWebDriver driver;

        #region WebElements
        [FindsBy(How = How.ClassName, Using = "username")]
        public IWebElement UserName;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'CREATE')]")]
        public IWebElement Create_btn;
        [FindsBy(How = How.XPath, Using = "//a[@class='js-add-quick-appointment']")]
        public IWebElement Create_Appointment_item;
        [FindsBy(How = How.XPath, Using = "//a[@class='js-add-customer-btn']")]
        public IWebElement Create_Customer_item;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Text Message')]")]
        public IWebElement Create_TextMessage_item;
        [FindsBy(How = How.XPath, Using = "//a[@href='/new-email-message?shopId=634954']")]
        public IWebElement Create_EmailMessage_item;
        [FindsBy(How = How.Id, Using = "PartsTechPageLink")]
        public IWebElement PartsTech_btn;
        [FindsBy(How = How.Id, Using = "CalendarFastLink")]
        public IWebElement Calendar_btn;
        [FindsBy(How = How.Id, Using = "couponButton")]
        public IWebElement Coupon_btn;
        [FindsBy(How = How.Id, Using = "CustomerSearchInput")]
        public IWebElement CustomerSearch_field;
        [FindsBy(How = How.Id, Using = "CustomerSearchButton")]
        public IWebElement CustomerSearch_btn;
        [FindsBy(How = How.XPath, Using = "//button[@class='dropdown-button js-dropdown-button']")]
        public IWebElement ShopsList_dropdown;


        #endregion

        public ShopManagerHeader(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }


        #region Actions
        public ShopManagerHeader CreateNewCustomer()
        {
            GenericHelper.HoverToAnElement(By.XPath("//span[contains(text(),'CREATE')]"));
            Create_Customer_item.Click(); 
            return new ShopManagerHeader(driver);
        }


        #endregion

        #region Navigation
        public HomePage NavigateToHomePage()
        {

            return new HomePage(driver);
        }

        #endregion

    }
}
