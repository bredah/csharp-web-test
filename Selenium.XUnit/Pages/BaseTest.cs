using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.XUnit.Pages
{
    public class BaseTest : IDisposable
    {
        public IWebDriver Driver { get; }

        public BaseTest()
        {
            Driver = new Driver().Start(Browser.Chrome);
        }

        public void Dispose()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}
