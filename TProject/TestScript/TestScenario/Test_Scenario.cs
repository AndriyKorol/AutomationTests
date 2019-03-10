using Microsoft.VisualStudio.TestTools.UnitTesting;
using TProject.ComponentHelper;
using TProject.PageObject;
using TProject.Settings;
using TProject.TestScript.PageObject;

namespace TProject.TestScript.TestScenario
{
    [TestClass]
    public class Test_Scenario 
    {
        [TestMethod]
        public void Create_new__customer_with_vehicle_Test()
        {
            var logIn = new Test_logIn();
            logIn.Test_Valid_LogIn();
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetShopManager());
            ShopManagerHeader shopManagerHeader = new ShopManagerHeader(ObjectRpository.Driver);
            shopManagerHeader.CreateNewCustomer();
        }
    }
}
