using System;
using OpenQA.Selenium;
using Xunit;

namespace Selenium.XUnit {
    public class DriverTest : IDisposable {
        private IWebDriver _driver;
        public DriverTest () {
            _driver = null;
        }

        public void Dispose () {
            if (_driver != null) {
                _driver.Quit ();
            }
            GC.SuppressFinalize (this);
        }

        [Fact]
        public void Local () {
            _driver = new Driver ().Start (Browser.Chrome);
            Assert.True (_driver.WindowHandles.Count > 0);
        }
    }
}