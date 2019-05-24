using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class FormPage : PageBase
    {
        private IWebElement _inputUsername => Driver.FindElement(By.Id("username"));
        private IWebElement _inputPassword => Driver.FindElement(By.Id("password"));
        private IWebElement _buttonSubmit => Driver.FindElement(By.CssSelector("button"));
        private IWebElement _labelMessage => Driver.FindElement(By.CssSelector("#flash-messages div"));

        public FormPage(IWebDriver driver) : base(driver) { }

        public override void Open()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
        }

        /// <summary>
        /// Submit the login form
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Information message</returns>
        public string Login(string username, string password)
        {
            _inputUsername?.SendKeys(username);
            _inputPassword?.SendKeys(password);
            _buttonSubmit.Click();
            return _labelMessage.Text;
        }

    }
}