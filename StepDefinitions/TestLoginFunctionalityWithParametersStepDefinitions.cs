using System;
using System.Diagnostics.Metrics;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRM1LoginStepsStepDefinitions
    {
        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            Console.WriteLine("The user name is " + username + "..........." + "The password is" + password);
        }

        [When(@"User clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            Console.WriteLine("The user clicked on login button");
        }

        [Then(@"user is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("The user is on home page");
        }

        [Then(@"User slects city and country information")]
        public void ThenUserSlectsCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + "," + country);
            }
        }
    }
}

