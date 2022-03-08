using Jane.UITest.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jane.UITest.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        IWebElement usernameField => _driver.FindElement(By.Id("username"));
        IWebElement passwordField => _driver.FindElement(By.Id("password"));
        IWebElement loginSubmit => _driver.FindElement(By.Id("loginsubmit"));
        IWebElement titlePage => _driver.FindElement(By.Id("Test - Home"));

        internal void navigateToLoginPage(string Url)
        {
            _driver.Navigate().GoToUrl(Url);
        }

        IWebElement language => _driver.FindElement(By.Id("searchLanguage"));

        public string GetTitlePage()
        {
            return titlePage.Text.Trim();
        }

        public void FillUsername(string username)
        {
            usernameField.SendKeys(username);
        }

        public void FillPassword(string password)
        {
            passwordField.SendKeys(password);
        }

        public string LanguagePage()
        {
            return language.Text.Trim();
        }


        public void ClickSubmitButton()
        {
            loginSubmit.Click();
        }
        
        public LoginPage()
        {
            _driver = Hooks1._driver;
        }
    }

}
