using OpenQA.Selenium;
using System;

namespace TProject.ComponentHelper
{
    public class WebElementExtensions 
    {
        public static string GetAttributeOfElement(IWebElement element)
        {
            //https://sqa.stackexchange.com/questions/20020/how-do-i-extract-the-inner-element-in-selenium
            //http://executeautomation.com/blog/tag/iwebelement/
            //https://www.automatetheplanet.com/selenium-webdriver-tests-csharp-six/

            Console.WriteLine("this elemem " + element);
            string tagName = element.TagName;
            Console.WriteLine("this tagName " + tagName);
            String attValue = element.GetAttribute(tagName); //This will return "SubmitButton"
            Console.WriteLine(attValue);
            return attValue;
        }
    }
}
