using Microsoft.VisualBasic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.SpecflowPages.Helpers
{
    public class CommonMethods
    {   
        //Screenshots
        //screnshott


        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                fileName.Append(".Jpeg");
                ScreenShotFileName.ToString();

            }

        }
        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports? Extent
        public static void ExtentReports()
        {
            Extent = new ExtentReports(ConstantHelpers.ReportsPath, true, DisplayOrder.NewsFirst);
            Extent.LoadConfig(ConstantHelpers.ReportXMLPath);
        }
        
    }
    #endregion


}
