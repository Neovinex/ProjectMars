using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Tests
{

    [TestFixture]
    public class Languages_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpActions()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //LoginPage loginPageObj = new LoginPage();
            //loginPageObj.GoToLanguagesPage(driver);

        }
        [Test, Order(1)]
        public void CreatLanguages()
        {
            LanguagesPage languagesPageObj = new LanguagesPage();
            languagesPageObj.CreatLanguages(driver);

        }
        [Test, Order(2)]
        public void EditLanguages() 
        {
            LanguagesPage languagesPageObj = new LanguagesPage();
            languagesPageObj.Editlanguages(driver);
        }

    }
}
    





















//}
