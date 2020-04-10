using NUnit.Framework;
using NUnitTestProject1.PageObject;

namespace NUnitTestProject1.Test
{
    [TestFixture]
    public class TotalPriceInCart : BaseTestsOperations
    {
        private MainPage mainPage;
        private Cart cart;

        [OneTimeSetUp]
        public void TestsSetUp()
        {
            mainPage = new MainPage(driver);
            cart = new Cart(driver);
        }

        [Test]
        public void TwoProductsTotalPriceInCart()
        {
            mainPage.AddToCartTwoProducts();
            Assert.That(cart.TotalPrice(), Is.EqualTo(cart.SumOfPrice()), $"Expected that Total Price ({cart.TotalPrice()}) " +
                $"is equal to summary price of two products ({cart.SumOfPrice()}) in cart");
        }
    }
}
