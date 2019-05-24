using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.MSTest.Pages
{
    [TestClass]
    public class FormPageTest
    {
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void SetUpClass(TestContext context)
        {
            _driver = new Driver().Start(Browser.Chrome);
        }

        [ClassCleanup]
        public static void TearDownClass()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Property)]
        public void CheckLogin(string username, string password, string expectedMessage)
        {
            var page = new FormPage(_driver);
            page.Open();
            var result = page.Login(username, password);
            Assert.IsTrue(result.Contains(expectedMessage));
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                yield return new object[] { "tomsmith", "SuperSecretPassword!", "You logged into a secure area!" };
                yield return new object[] { "", "SuperSecretPassword!", "Your username is invalid!" };
                yield return new object[] { "tomsmith", "", "Your password is invalid!" };
                yield return new object[] { "", "", "Your username is invalid!" };
            }
        }

    }
}
