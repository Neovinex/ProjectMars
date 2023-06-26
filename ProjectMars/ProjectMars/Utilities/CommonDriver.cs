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
            //Home Page object initialization and definition
            HomePage HomePageObj = new HomePage();
            HomePageObj.LoginSteps(driver);

        }

        
        
    }
}
