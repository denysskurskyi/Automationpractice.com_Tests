using OpenQA.Selenium;
using System;
using System.Linq;
using System.Globalization;

namespace NUnitTestProject1.PageObject
{
    public class Cart : PageObjectBase
    {
        private static readonly By firstPriceInCart = By.Id("total_product_price_1_1_0");
        private static readonly By secondPriceInCart = By.Id("total_product_price_2_7_0");
        private static readonly By totalPriceSpan = By.Id("total_product");
        private static readonly By deleteButton = By.Id("1_1_0_0");
        private static readonly By emptyCartAlert = By.XPath("//*[@id='center_column']/p");

        public Cart(IWebDriver driver) : base(driver)
        {
        }

        public double SumOfPrice()
        {
            double firstPrice = double.Parse(Driver.FindElement(firstPriceInCart).Text.Remove(0, 1), CultureInfo.InvariantCulture);
            double secondPrice = double.Parse(Driver.FindElement(secondPriceInCart).Text.Remove(0, 1), CultureInfo.InvariantCulture);
            return Math.Round(firstPrice + secondPrice, 2);
        }

        public double TotalPrice()
        {
            double totalPriceOfProduct = double.Parse(Driver.FindElement(totalPriceSpan).Text.Remove(0, 1), CultureInfo.InvariantCulture);
            return Math.Round(totalPriceOfProduct, 2);
        }

        public Cart DeleteProduct()
        {
            Driver.FindElement(deleteButton).Click();
            return this;
        }
            
        public bool IsCartEmpty()
        {
            bool isAlertMessagePresents = Driver.FindElements(emptyCartAlert).Any();
            return isAlertMessagePresents;
        }
    }
}
