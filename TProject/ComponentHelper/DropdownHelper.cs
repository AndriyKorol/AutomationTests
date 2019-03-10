using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TProject.ComponentHelper
{
    public class DropdownHelper
    {
        private static SelectElement select;

        public static void SelectElement(By locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByIndex(index);
        }


        public static void SelectElement(By locator, string visibletext)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByValue(visibletext);
        }
        
        public static IList<string> GetAllItems(By locator)
        {

            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
    }
}
