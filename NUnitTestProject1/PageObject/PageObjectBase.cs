using OpenQA.Selenium;

namespace NUnitTestProject1.PageObject
{
    public abstract class PageObjectBase
    {
        protected readonly IWebDriver Driver;
        protected PageObjectBase(IWebDriver driver) => Driver = driver;
    }
}
