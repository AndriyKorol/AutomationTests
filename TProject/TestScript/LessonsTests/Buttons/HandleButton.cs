using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.Buttons
{
    //[TestClass]
    public class HandleButton
    {
        [TestMethod]
        public void TestButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("loginLink"));
            InputHelper.InputIntoField(By.Id("LoginEmailAddress"), ObjectRpository.Config.GetEmail());
            InputHelper.InputIntoField(By.Id("LoginPassword"), ObjectRpository.Config.GetPassword());
            Console.WriteLine("Enabled : {0}", ButtonHelper.IsButtonEnable(By.ClassName("blue-btn")));
            Console.WriteLine("Button text: {0}", ButtonHelper.GetButtonText(By.ClassName("blue-btn")));
            ButtonHelper.ClickButton(By.ClassName("blue-btn"));
        }
    }
}
