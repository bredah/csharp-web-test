using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Selenium.MSTest
{
    [TestClass]
    public class DriverTest
    {
        private IWebDriver _driver;


        [TestInitialize]
        public void SetUp()
        {
            _driver = null;
        }

        [TestCleanup]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Close();
            }
        }

        [TestMethod]
        public void Local()
        {
            _driver = new Driver().Start(Browser.Chrome);
            Assert.AreEqual(1, _driver.CurrentWindowHandle.Length);
        }
    }
}
