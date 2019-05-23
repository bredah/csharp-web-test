using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenium.NUnit {
    public class DriverTest {
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
        public void Local () {
            _driver = new Driver ().Start (Browser.Chrome);
            Assert.True (_driver.WindowHandles.Count > 0);
        }
    }
}