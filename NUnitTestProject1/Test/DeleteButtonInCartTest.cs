using NUnit.Framework;
using NUnitTestProject1.PageObject;

namespace NUnitTestProject1.Test
{
    class DeleteButtonInCartTest : StartChrome
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
        public void DeleteProductFromCart()
        {
            mainPage.AddToCartOneProduct();
            bool isCartEmpty = cart.DeleteProduct().IsCartEmpty();
            Assert.That(isCartEmpty, Is.EqualTo(true), $"Product was {(isCartEmpty ? "succesfully" : "unseccesfully")} " +
                "deleted");
        }
    }
}
