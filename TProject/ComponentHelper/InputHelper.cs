using System;
using OpenQA.Selenium;

namespace TProject.ComponentHelper
{
    public class InputHelper
    {
        private static IWebElement element;
        public static void InputIntoField(By locator, string text)
        {
            element = GenericHelper.GetElement(locator);
            element.SendKeys(text);
        }

        public static void ClearInputField(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Clear();
            
        }
        
    }
}
