using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenium.NUnit {
    public class BrowserTest {
        private IWebDriver _driver;

        [SetUp]
        public void Setup () {
            _driver = null;
        }

        [TearDown]
        public void TearDown () {
            if (_driver != null) {
                _driver.Quit ();
            }
        }

        [Test]
        public void TakeScreenshot () {
            _driver = new Driver ().Start (Browser.Chrome);
            _driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            var result = BrowserHelper.TakeScreenshot(_driver);
            Assert.True (File.Exists(result));
        }
    }
}