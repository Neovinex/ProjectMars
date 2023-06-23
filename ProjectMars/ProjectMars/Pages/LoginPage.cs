using NUnit.Framework;
using OpenQA.Selenium;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class LoginPage : CommonDriver
    {
        public void LoginSteps(IWebDriver driver)
        {
            // Launch Project Mars web portal
            driver.Navigate().GoToUrl("http://localhost:5000/");

            Wait.WaitToExist(driver, "name", "email", 6);

            try
            {
                IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signInButton.SendKeys("neowij@yahoo.com");

            }
            catch (Exception ex)   
            {
                Assert.Fail("Project Mars Portal did not load.", ex);
            
            }

            IWebElement passwordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            passwordTextBox.SendKeys("Neo123");

            IWebElement tickCheckBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
            tickCheckBox.Click();
            Thread.Sleep(2000);







        }  

     

    }   
    
      

        
        
    
}
