using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace Selenium
{
    public class Driver
    {
        private Browser Browser;

        public IWebDriver Start(Browser browser, bool remote = false)
        {
            Browser = browser;
            if (remote)
            {
                return Remote();
            }
            return Local();
        }

        /// <summary>
        /// Local this instance, use during the development
        /// </summary>
        /// <returns>The webdriver local instance</returns>
        private IWebDriver Local()
        {
            switch (Browser)
            {
                case Browser.Chrome:
                    return new ChromeDriver();
                default:
                    return null;
            }
        }

        private IWebDriver Remote()
        {
            switch (Browser)
            {
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
    }
}
