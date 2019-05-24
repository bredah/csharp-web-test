using OpenQA.Selenium;

namespace Selenium.Pages {
    public abstract class PageBase {
        public IWebDriver Driver { get; }
        public PageBase (IWebDriver driver) {
            Driver = driver;
        }

        /// <summary>
        /// Open the URL
        /// </summary>
        /// <param name="url">URL to access</param>
        public abstract void Open();
    }
}