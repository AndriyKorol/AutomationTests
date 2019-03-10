using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TProject.TestScript.TestClassContext
{
    //[TestClass]
   public class TestClassContext
    {
        private TestContext _testContyex;

        public TestContext TestContext
        {
            get { return _testContyex; }
            set { _testContyex = value; }
        }

        [TestMethod]
        public void TestCase1()
        {
            Console.WriteLine("Test Nam: {0}", TestContext.TestName);
        }

        [TestMethod]
        public void TestCase2()
        {
            Console.WriteLine("Test Nam: {0}", TestContext.TestName);
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("Result: {0}", TestContext.CurrentTestOutcome);
        }
    }
}
