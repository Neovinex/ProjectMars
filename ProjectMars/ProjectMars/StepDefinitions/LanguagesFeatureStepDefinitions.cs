using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars.StepDefinitions
{
    [Binding]
    public class LanguagesFeatureStepDefinitions : CommonDriver
    {
        [Given(@"\[I logged into webportal successfully]")]
        public void GivenILoggedIntoWebportalSuccessfully()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }

        [When(@"\[I create a new language record]")]
        public void WhenICreateANewLanguageRecord()
        {
            LanguagesPage languagesPageObj = new LanguagesPage();
            languagesPageObj.CreatLanguages(driver);
        }

        [Then(@"\[The record should be created successfully]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            LanguagesPage languagesPageObj = new LanguagesPage();

            string newLanguage = languagesPageObj.GetLanguage(driver);
            string newLanguageLevel = languagesPageObj.GetLanguageLevel(driver);

            Assert.AreEqual("English", newLanguage, "Actual Language and expected Language do not match");
            Assert.AreEqual("Fluent", newLanguageLevel, "Actual Language level and expected Language level do not match");

        }
    }
}
