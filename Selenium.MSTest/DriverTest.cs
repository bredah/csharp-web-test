using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Selenium.MSTest {
    [TestClass]
    public class DriverTest {
        private IWebDriver _driver;

        [TestInitialize]
        public void SetUp () {
            _driver = null;
        }

        [TestCleanup]
        public void TearDown () {
            if (_driver != null) {
                _driver.Quit ();
            }
        }

        [TestMethod]
        public void Local () {
            _driver = new Driver ().Start (Browser.Chrome);
            Assert.IsTrue (_driver.WindowHandles.Count > 0);
        }
    }
}