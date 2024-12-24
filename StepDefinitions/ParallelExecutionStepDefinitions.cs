using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
[assembly: Parallelizable(ParallelScope.All)]
namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class ParallelExecutionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        IWebDriver _driver;
        //IWebDriver _driver1;
        //IWebDriver _driver2;

        public ParallelExecutionStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }
        [Given(@"user is on the apllication page on FE browser")]
        public void GivenUserIsOnTheApllicationPageOnFEBrowser()
        {
           // new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //_driver1 = new ChromeDriver();
            //_driver1.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            Thread.Sleep(1000);
            
        }
            
        

        [Given(@"user is on the apllication page on FF browser")]
        public void GivenUserIsOnTheApllicationPageOnFFBrowser()
        {
            /*new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            _driver2 = new FirefoxDriver();
            _driver2.Manage().Window.Maximize();*/
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            Thread.Sleep(1000);
        }
        

        [Given(@"user is on the apllication page on IE browser")]
        public void GivenUserIsOnTheApllicationPageOnIEBrowser()
        {
            /*new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            _driver = new EdgeDriver();
            _driver.Manage().Window.Maximize();*/
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            Thread.Sleep(1000);
        }
    }
    }

