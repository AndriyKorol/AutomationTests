using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TProject.BaseClasses;


namespace TProject.PageObject
{
    public class LoginPage : PageBase
    {
        private IWebDriver driver;

        #region WebElements

        [FindsBy(How = How.ClassName, Using = "blue-btn")]
        private IWebElement SignInBtn;

        [FindsBy(How = How.Id, Using = "LoginEmailAddress")]
        private IWebElement EmailField;

        [FindsBy(How = How.Id, Using = "LoginPassword")]
        private IWebElement PasswordField;

        [FindsBy(How = How.ClassName, Using = "logo")]
        private IWebElement Logo;

        #endregion

        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Actions

        public HomePage LogIn(string email, string password)
        {
            EmailField.SendKeys(email);
            PasswordField.SendKeys(password);
            SignInBtn.Click();
            return new HomePage(driver);
        }

        #endregion

        #region Navigation

        public HomePage NavigateToHomePage()
        {
            Logo.Click();
            return new HomePage(driver);
        }
        
        #endregion
    }
}
