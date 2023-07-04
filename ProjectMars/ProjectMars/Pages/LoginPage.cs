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
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();

            try
            {
                //Finding sign in button
                IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signInButton.Click();

                IWebElement emailTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                emailTextBox.SendKeys("neowij@yahoo.com");

                IWebElement passwordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextBox.SendKeys("Neo123");

                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
                Thread.Sleep(2000);
            }
            catch
            (Exception ex)
            {
                Assert.Fail("Project Mars Portal did not launch", ex);
            }
            
            
            
            

            
            



            

        }

        
        
            
        
    }

   


}
