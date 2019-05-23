using System;
using System.Drawing;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace Selenium {
    public class Driver {
        private Browser Browser;

        public IWebDriver Start (Browser browser, bool remote = false) {
            Browser = browser;
            if (remote) {
                return Remote ();
            }
            return Local ();
        }

        /// <summary>
        /// Local this instance, use during the development
        /// </summary>
        /// <returns>Local instance driver</returns>
        private IWebDriver Local () {
            var driver = new ChromeDriver (Directory.GetCurrentDirectory ());
            // Set window size
            driver.Manage ().Window.Size = new Size (1280, 730);
            // driver.Manage ().Window.Maximize();
            // Default timeout
            DefaultTimeout (driver);
            return driver;
        }

        /// <summary>
        /// Start the remote driver
        /// </summary>
        /// <returns>Remote instance driver</returns>
        private IWebDriver Remote () {
            //TODO: Create the remote connection
            switch (Browser) {
                case Browser.Chrome:
                    break;
                case Browser.Edge:
                    break;
                case Browser.Firefox:
                    break;
                case Browser.Safari:
                    break;
            }
            return null;
        }

        /// <summary>
        /// Set the default timeout
        /// </summary>
        /// <param name="driver">Current driver</param>
        public static void DefaultTimeout (IWebDriver driver) {
            driver.Manage ().Timeouts ().PageLoad = TimeSpan.FromSeconds (15);
            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (10);
        }
    }
}