using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TProject.ComponentHelper;
using TProject.Settings;

namespace TProject.TestScript.MouseAction
{
    //[TestClass]
    public class TestMouseAction
    {
        [TestMethod]
        public void TestMouseRightClick()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            Actions act = new Actions(ObjectRpository.Driver);
            IWebElement el = ObjectRpository.Driver.FindElement(By.Id("loginLink"));

            //act = act.ContextClick(el);
            //IAction iact = act.Build();
            //iact.Perform();

            act.ContextClick(el).Build().Perform();

            Thread.Sleep(5000);
        }

        [TestMethod]
        public void DragAndDrop()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRpository.Driver);
            IWebElement drag = ObjectRpository.Driver.FindElement(By.Id("draggable"));
            IWebElement drop = ObjectRpository.Driver.FindElement(By.Id("droptarget"));

            act.DragAndDrop(drag, drop).Build().Perform();

            Thread.Sleep(4000);

        }

        [TestMethod]
        public void DragAndDropSortable()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/sortable/index");
            Actions act = new Actions(ObjectRpository.Driver);
            IWebElement el = ObjectRpository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[12]"));
            IWebElement tar = ObjectRpository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[2]/span"));

            act.ClickAndHold(el).MoveToElement(tar, 0, 30).Release().Build().Perform();

            Thread.Sleep(4000);

        }
    }
}
