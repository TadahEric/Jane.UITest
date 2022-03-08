using System;
using TechTalk.SpecFlow;
using Jane.UITest.Hooks;
using Jane.UITest.Pages;
using NUnit.Framework;

namespace Jane.UITest.StepDefinition
{
    [Binding]
    public class InterviewTestSteps
        {
          LoginPage  _loginPage;
        public InterviewTestSteps()
        {
            _loginPage = new LoginPage();
          
        }

        [Given(@"I have reached the login page ""(.*)""")]
        public void GivenIHaveReachedTheLoginPage(string Url)
        {
            _loginPage.navigateToLoginPage(Url);
        }
        
        [Given(@"I have entered ""(.*)"" as username")]
        public void GivenIHaveEnteredAsUsername(string username)
        {
            _loginPage.FillUsername(username);
        }
        
        [Given(@"I have entered ""(.*)"" as password")]
        public void GivenIHaveEnteredAsPassword(string password)
        {
            _loginPage.FillPassword(password);
        }
        
        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickSubmitButton();
        }
        
               
        [Then(@"I am taken to the Search page ""(.*)""")]
        public void ThenIAmTakenToTheSearchPage(string SearchPage)
        {
            Assert.AreEqual("searchPage", _loginPage.GetTitlePage());
        }

        [Then(@"the search language is ""(.*)""")]
        public void ThenTheSearchLanguageIs(string expectedResult)
        {
            Assert.AreEqual("expectedResult", _loginPage.LanguagePage());
        }
    }
}
