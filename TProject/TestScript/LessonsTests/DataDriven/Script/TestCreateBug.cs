using Microsoft.VisualStudio.TestTools.UnitTesting;
using TProject.ComponentHelper;
using TProject.PageObject;
using TProject.Settings;

namespace TProject.DataDriven.Script
{
    //[TestClass]
    public class TestCreateBug
    {
        private TestContext _testContyex;

        public TestContext TestContext
        {
            get { return _testContyex; }
            set { _testContyex = value; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\filePath\FileNAme.csv", "FileNAme#csv", DataAccessMethod.Sequential)]
        public void TestBug()
        {
            NavigationHelper.NavigateToUrl(ObjectRpository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRpository.Driver);
            LoginPage loginPage = homePage.GoToLoginPage();

        }

    }
}
