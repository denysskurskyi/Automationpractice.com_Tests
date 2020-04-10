using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace NUnitTestProject1.PageObject
{
    public class MainPage : PageObjectBase
    {
        private static readonly By toCartButtonFirstProduct = By.XPath("//*[@id='homefeatured']/li[1]/div/div[2]/div[2]/a[1]");
        private static readonly By toCartButtonSecondProduct = By.XPath("//*[@id='homefeatured']/li[2]/div/div[2]/div[2]/a[1]");
        private static readonly By proceedToCheckout = By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a");
        private static readonly By ContinueButton = By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span");
        private readonly Actions action;
        public MainPage(IWebDriver driver) : base(driver)
        {
            action = new Actions(Driver);
        }

        public void AddToCartTwoProducts()
        {
            action.MoveToElement(Driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div"))).Perform();
            Driver.FindElement(toCartButtonFirstProduct).Click();
            Driver.FindElement(ContinueButton).Click();
            
            action.MoveToElement(Driver.FindElement(By.XPath("//*[@id='homefeatured']/li[2]/div"))).Perform();
            Driver.FindElement(toCartButtonSecondProduct).Click();
            Driver.FindElement(proceedToCheckout).Click();
        }
        public void AddToCartOneProduct()
        {
            action.MoveToElement(Driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div"))).Perform();
            Driver.FindElement(toCartButtonFirstProduct).Click();
            Driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            Driver.FindElement(proceedToCheckout).Click();
        }
    }
}
