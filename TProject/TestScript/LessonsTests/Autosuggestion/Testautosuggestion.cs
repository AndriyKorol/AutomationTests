using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.Autosuggestion
{
    //[TestClass]
    public class Testautosuggestion
    {
        [TestMethod]
        public void TestAutoSuggest()
        {
            NavigationHelper.NavigateToUrl("https://mechanic.boston/find-a-repair-shop");
            //step1 - supply the initial string
            IWebElement el = ObjectRpository.Driver.FindElement(By.Id("txtSearchRepair"));
            el.SendKeys("ar");

            //step2 - wait for autosuggestion list
            //need to use dynamic web concept
            var wait = GenericHelper.GetWebDriverWait(TimeSpan.FromSeconds(40));
            IList<IWebElement> elements = wait.Until(GetAllElement(By.XPath("//ul[@id='ui-id-1']/child::li")));
            foreach (var ele1 in elements)
            {
                if (ele1.Text.Equals("Arctic Cat mechanic"))
                {
                    ele1.Click();
                }
            }
        }

        private Func<IWebDriver, IList<IWebElement>> GetAllElement(By locator)
        {
            return ((x) => { return x.FindElements(locator); });
        }
    }

    
}
