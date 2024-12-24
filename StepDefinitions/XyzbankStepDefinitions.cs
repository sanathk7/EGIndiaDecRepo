using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class XyzbankStepDefinitions

    {
        
        private readonly ScenarioContext _scenarioContext;
        IWebDriver _driver;
        [Given(@": when user on the xyz login page")]
        public void GivenWhenUserOnTheXyzLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");

            Thread.Sleep(1000);
            Console.WriteLine("User on the Login page");

        }

        [When(@"user clicks on Customer Login")]
        public void WhenUserClicksOnCustomerLogin()
        {
            IWebElement clogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
            clogin.Click();
            Thread.Sleep(1000);
        }

        [When(@"user selects name and  clicks login")]
        public void WhenUserSelectsNameAndClicksLogin()
        {
            IWebElement names = _driver.FindElement(By.XPath("//select[@id='userSelect'](1)"));
            names.Click();
            Thread.Sleep(1000);
            IWebElement eclogin = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            eclogin.Click();
            Thread.Sleep(1000);
        }
    }
}
//jsjs