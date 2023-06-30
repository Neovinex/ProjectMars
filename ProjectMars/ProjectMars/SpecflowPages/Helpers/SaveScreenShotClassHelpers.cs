using OpenQA.Selenium;
using ProjectMars.SpecflowPages.Helpers;

internal static class SaveScreenShotClassHelpers
{
    public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
    {
        var folderLocation = (ConstantHelpers.ScreenshotPath);

        if (!System.IO.Directory.Exists(folderLocation))
        {
            System.IO.Directory.CreateDirectory(folderLocation);
        }


    }
}