using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            //Login Page object initialization and definition
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginSteps(driver);

        }

        [OneTimeTearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
}
