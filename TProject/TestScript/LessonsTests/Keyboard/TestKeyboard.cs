using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.Keyboard
{
    //[TestClass]
    public class TestKeyboard
    {
        [TestMethod]
        public void TestKeyBoard()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            Actions act = new Actions(ObjectRpository.Driver);
            
            // ctrl + t (new tab will be appears)
            act.KeyDown(Keys.LeftControl).SendKeys("t").KeyUp(Keys.LeftControl).Build().Perform();
            
            // ctrl + shift + a
            act.KeyDown(Keys.LeftControl)
                .KeyDown(Keys.LeftShift)
                .SendKeys("a")
                .KeyUp(Keys.LeftControl)
                .KeyUp(Keys.LeftShift)
                .Build()
                .Perform();

            // alt + f + x
            act.KeyDown(Keys.LeftAlt)
                .SendKeys("f")
                .SendKeys("x")
                .Build()
                .Perform();

            //set uppercase into input field
            IWebElement el = ObjectRpository.Driver.FindElement(By.Id("locator of input field"));
            act.KeyDown(el, Keys.LeftShift)
                .SendKeys(el, "uppercase text")
                .KeyUp(el, Keys.LeftShift)
                .Build()
                .Perform();


        }
    }
}
