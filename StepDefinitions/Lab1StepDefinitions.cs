using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Lab1StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;

        public Lab1StepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"User is on the registration page")]
        public void GivenUserIsOnTheRegistrationPage()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Console.WriteLine("User is on registration page");
        }

        [When(@"User enters ""([^""]*)"", ""([^""]*)"", and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersAndInTheTextFields(string name, string email, string password)
        {
            _driver.FindElement(By.XPath("//input[@name='name']")).SendKeys(name);
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//input[@name='email']")).SendKeys(email);
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//input[@id='exampleInputPassword1']")).SendKeys(password);
            Thread.Sleep(1000);
        }

        [When(@"User selects ""([^""]*)"" as gender")]
        public void WhenUserSelectsAsGender(string gender)
        {
            if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                _driver.FindElement(By.XPath("//option[normalize-space()='Male']")).Click();
            }
            else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                _driver.FindElement(By.XPath("//option[normalize-space()='Female']")).Click();
            }
            Thread.Sleep(1000);
        }

        [When(@"User chooses ""([^""]*)"" using the radio button")]
        public void WhenUserChoosesUsingTheRadioButton(string employmentStatus)
        {
            if (employmentStatus.Equals("Employed", StringComparison.OrdinalIgnoreCase))
            {
                _driver.FindElement(By.XPath("//label[normalize-space()='Employed']")).Click();
            }
            else if (employmentStatus.Equals("Student", StringComparison.OrdinalIgnoreCase))
            {
                _driver.FindElement(By.XPath("//label[normalize-space()='Student']")).Click();
            }
            Thread.Sleep(1000);
        }

        [When(@"User selects ""([^""]*)"" as date of birth")]
        public void WhenUserSelectsAsDateOfBirth(string dateOfBirth)
        {
            _driver.FindElement(By.XPath("//input[@name='bday']")).SendKeys(dateOfBirth);
            Thread.Sleep(1000);
        }

        [Then(@"The submit button should be enabled but not clicked")]
        public void ThenTheSubmitButtonShouldBeEnabledButNotClicked()
        {
            var submitButton = _driver.FindElement(By.XPath("//input[@value='Submit']"));
            Assert.IsTrue(submitButton.Enabled, "Submit button is not enabled.");
            Assert.IsFalse(submitButton.Selected, "Submit button should not be clicked.hhjd");
            Thread.Sleep(1000);

        }
    }
}