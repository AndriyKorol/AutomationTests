using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.BrowserActions
{
    //[TestClass]
    public class TestBrowserActions
    {
        [TestMethod]
        public void TestActions()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("loginLink"));
            InputHelper.InputIntoField(By.Id("LoginEmailAddress"), ObjectRpository.Config.GetEmail());
            InputHelper.InputIntoField(By.Id("LoginPassword"), ObjectRpository.Config.GetPassword());
            ButtonHelper.ClickButton(By.ClassName("blue-btn"));
            LinkHelper.ClickLink(By.LinkText("SHOP OWNERS"));
            LinkHelper.ClickLink(By.Id("ShopManagerLink"));
            BrowserHelper.BrowserGoBack();
            BrowserHelper.BrowserForward();
            BrowserHelper.BrowserRefresh();


        }
    }
}
