using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.NUnit.Pages
{
    public class FormPageTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUpClass()
        {
            _driver = new Driver().Start(Browser.Chrome);
        }

        [OneTimeTearDown]
        public static void TearDownClass()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }
        }

        [Test]
        [TestCaseSource(nameof(Data))]
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
