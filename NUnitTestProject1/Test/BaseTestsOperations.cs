using NUnit.Framework;
using OpenQA.Selenium;
using NUnitTestProject1.Framework;


namespace NUnitTestProject1
{
    [TestFixture]
    public class BaseTestsOperations
    {
        protected readonly IWebDriver driver;

        protected BaseTestsOperations()
        {
            driver = Selenium.GetChromeDriver();
            driver.Navigate().GoToUrl(Settings.url);
        }

        [TearDown]
        public void TearDowm() => driver.Quit();
    }
}