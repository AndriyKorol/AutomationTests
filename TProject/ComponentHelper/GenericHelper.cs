using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TProject.Settings;

namespace TProject.ComponentHelper
{
    
    public class GenericHelper
    {
        private static IWebElement element;
       

        //It's work for unique locator
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRpository.Driver.FindElements(Locator).Count == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static IWebElement GetElement(By Locator)
        {

            if (IsElementPresent(Locator))
            {
                return ObjectRpository.Driver.FindElement(Locator);
            }
            else
            {
                throw new NoSuchElementException("An element is not found: " + Locator.ToString());
            }

        }

        public static void HoverToAnElement(By Locator)
        {
            Actions actions = new Actions(ObjectRpository.Driver);
            element = GenericHelper.GetElement(Locator);
            actions.MoveToElement(element).Perform();
        }

        private static Func<IWebElement, IWebElement> WaitForWebElementOnPageFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                {
                    return x.FindElement(locator);
                }
                else
                {
                    return null;
                }
            });
        }

        internal static IWebElement GetElement(string locator1)
        {
            throw new NotImplementedException();
        }

        public static WebDriverWait GetWebDriverWait(TimeSpan timeout)
        {
            ObjectRpository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRpository.Driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500)

            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait;

        }
    }
}
