using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Selenium.MSTest {
    [TestClass]
    public class BrowserTest {
        private IWebDriver _driver;

        [TestInitialize]
        public void Setup () {
            _driver = null;
        }

        [TestCleanup]
        public void TearDown () {
            if (_driver != null) {
                _driver.Quit ();
            }
        }

        [TestMethod]
        public void TakeScreenshot () {
            _driver = new Driver ().Start (Browser.Chrome);
            _driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            var result = BrowserHelper.TakeScreenshot (_driver);
            Assert.IsTrue (File.Exists (result));
        }
    }
}