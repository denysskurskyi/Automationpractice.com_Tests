using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1.Framework
{
    public static class Selenium
    {
        public static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            return driver;
        }
    }
}
