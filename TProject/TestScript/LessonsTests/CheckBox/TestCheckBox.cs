using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.CheckBox
{
    //[TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void CheckBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("loginLink"));
            InputHelper.InputIntoField(By.Id("LoginEmailAddress"), ObjectRpository.Config.GetEmail());
            InputHelper.InputIntoField(By.Id("LoginPassword"), ObjectRpository.Config.GetPassword());
            InputHelper.ClearInputField(By.Id("LoginEmailAddress"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("RememberMe")));
            CheckBoxHelper.IsCheckBoxChecked(By.Id("RememberMe"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("RememberMe")));
        }
    }
}

