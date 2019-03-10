using Microsoft.VisualStudio.TestTools.UnitTesting;
using TProject.ComponentHelper;
using TProject.PageObject;
using TProject.Settings;

namespace TProject.TestScript.Tests
{
    [TestClass]
    public class Test_shop_searching
    {
        [TestMethod]
        public void Test_Shop_Searching()
        {
            HomePage homePage = new HomePage(ObjectRpository.Driver);
            FindARepairShop findARepairShop = homePage.GoToFindARepairShopPage();
        }
    }
}
