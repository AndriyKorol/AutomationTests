using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TProject.Settings;

namespace TProject.ComponentHelper
{
    public class JSPopUpHelper
    {
        public static bool IsPopUpPresent()
        {
            try
            {
                ObjectRpository.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException )
            {
                return false;
            }
        }
        
        public static string GetPopUpText()
        {
            if (!IsPopUpPresent())
            {
                return "";
            }
            return ObjectRpository.Driver.SwitchTo().Alert().Text;
            
        }

        public static void AcceptPopUp()
        {
            if (!IsPopUpPresent())
            {
                return;
            }
            ObjectRpository.Driver.SwitchTo().Alert().Accept();
            
        }

        public static void DeclinePopUp()
        {
            if (!IsPopUpPresent())
            {
                return;
            }
            ObjectRpository.Driver.SwitchTo().Alert().Dismiss();

        }


        public static void SetTextIntoPopUp(string text)
        {
            if (!IsPopUpPresent())
            {
                return;
            }
            ObjectRpository.Driver.SwitchTo().Alert().SendKeys(text);
        }
    }
}
