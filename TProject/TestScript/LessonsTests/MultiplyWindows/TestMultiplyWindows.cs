using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.MultiplyWindows
{
    //[TestClass]
    public class TestMultiplyWindows
    {
        [TestMethod]
        public void TestMultiplyBrowser()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());

            BrowserHelper.SwitchToWindow(1);

            LinkHelper.ClickLink(By.Id("loginLink"));
            InputHelper.InputIntoField(By.Id("LoginEmailAddress"), ObjectRpository.Config.GetEmail());
            InputHelper.InputIntoField(By.Id("LoginPassword"), ObjectRpository.Config.GetPassword());
            ButtonHelper.ClickButton(By.ClassName("blue-btn"));
            LinkHelper.ClickLink(By.LinkText("SHOP OWNERS"));

            BrowserHelper.SwitchToWindow(2);

            LinkHelper.ClickLink(By.Id("ShopManagerLink"));
            
        }

        [TestMethod]
        public void TestFrame()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("loginLink"));
            LinkHelper.ClickLink(By.Id("RegisterButton"));
            ObjectRpository.Driver.SwitchTo().Frame(ObjectRpository.Driver.FindElement(By.Name("a-v4v0hdmcrlcn")));
            CheckBoxHelper.CheckBoxVerification(By.ClassName("a-v4v0hdmcrlcn"));
            //switch ouf from iframe
            ObjectRpository.Driver.SwitchTo().DefaultContent();

        }
    }
}
