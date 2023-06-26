using NUnit.Framework;
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

            HomePage HomePageObj = new HomePage();
            HomePageObj.LoginSteps(driver);

            HomePage HomePAgeObj = new HomePage();
            HomePageObj.GoToLanguagesPage(driver);




        }

    }

    


    
        
        
        
        
    
    
    


    
   
    


}
