using System;
using System.IO;
using OpenQA.Selenium;
using Xunit;

namespace Selenium.XUnit {
    public class BrowserTest : IDisposable {
        private IWebDriver _driver;
        public BrowserTest () {
            _driver = null;
        }

        public void Dispose () {
            if (_driver != null) {
                _driver.Quit ();
            }
            GC.SuppressFinalize (this);
        }

        [Fact]
        public void TakeScreenshot () {
            _driver = new Driver ().Start (Browser.Chrome);
            _driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            var result = BrowserHelper.TakeScreenshot (_driver);
            Assert.True (File.Exists (result));
        }
    }
}