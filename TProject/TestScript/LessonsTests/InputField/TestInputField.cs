using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.InputField
{
    [TestClass]
    public class TestInputField
    {
        //[TestMethod]
        public void InputField()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("loginLink"));
            //IWebElement elem = ObjectRpository.Driver.FindElement(By.Id("LoginEmailAddress"));
            //elem.SendKeys(ObjectRpository.Config.GetEmail());
            //elem = ObjectRpository.Driver.FindElement(By.Id("LoginPassword"));
            //elem.SendKeys(ObjectRpository.Config.GetPassword());
            //elem = ObjectRpository.Driver.FindElement(By.Id("LoginEmailAddress"));
            //elem.Clear();

            InputHelper.InputIntoField(By.Id("LoginEmailAddress"), ObjectRpository.Config.GetEmail());
            InputHelper.InputIntoField(By.Id("LoginPassword"), ObjectRpository.Config.GetPassword());
            InputHelper.ClearInputField(By.Id("LoginEmailAddress"));
        }
    }
}
