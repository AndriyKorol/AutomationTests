using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.PopUp
{
    //[TestClass]
    public class TestPopUp
    {
        [TestMethod]
        public void TestAlert()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/jsref/met_win_alert.asp");
            //click to button for opening new window
            BrowserHelper.SwitchToWindow(1);
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            // click on btn into iframe
            ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            var text = JSPopUpHelper.GetPopUpText();
            JSPopUpHelper.AcceptPopUp();
            //IAlert alert = ObjectRpository.Driver.SwitchTo().Alert();
            //var text = alert.Text;
            //alert.Accept();
            ObjectRpository.Driver.SwitchTo().DefaultContent();

        }

        [TestMethod]
        public void TestConfirmPopUp()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_confirm");
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            ObjectRpository.Driver.SwitchTo().Alert();

            var text = JSPopUpHelper.GetPopUpText();
            JSPopUpHelper.AcceptPopUp();
            //IAlert confirm = ObjectRpository.Driver.SwitchTo().Alert();
            //confirm.Accept();


            ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            ObjectRpository.Driver.SwitchTo().Alert();
            
            JSPopUpHelper.DeclinePopUp();
            //confirm = ObjectRpository.Driver.SwitchTo().Alert();
            //confirm.Dismiss();

            ObjectRpository.Driver.SwitchTo().DefaultContent();
        }

        [TestMethod]
        public void TestPromtPopUp()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_prompt");
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));

            var text = JSPopUpHelper.GetPopUpText();
            JSPopUpHelper.SetTextIntoPopUp(text);
            JSPopUpHelper.AcceptPopUp();
            ObjectRpository.Driver.SwitchTo().DefaultContent();
            InputHelper.ClearInputField(By.Id("textareaCode"));
            InputHelper.InputIntoField(By.Id("textareaCode"), text);
            //IAlert promt = ObjectRpository.Driver.SwitchTo().Alert();
            //promt.SendKeys("Some text");
            //promt.Accept();

            //ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            //promt = ObjectRpository.Driver.SwitchTo().Alert();
            //promt.SendKeys("Some text");
            //promt.Accept();
        }
    }

}
