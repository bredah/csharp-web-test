using OpenQA.Selenium;
using Selenium.Pages;
using System;
using System.Collections.Generic;
using Xunit;

namespace Selenium.XUnit.Pages
{
    public class FormPageTest : IClassFixture<BaseTest>
    {
        private readonly IWebDriver Driver;

        public FormPageTest(BaseTest baseTest)
        {
            Driver = baseTest.Driver;
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void CheckLogin(string username, string password, string expectedMessage)
        {
            var page = new FormPage(Driver);
            page.Open();
            var result = page.Login(username, password);
            Assert.Contains(expectedMessage, result);
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

        public BaseTest BaseTest { get; }
    }
}
