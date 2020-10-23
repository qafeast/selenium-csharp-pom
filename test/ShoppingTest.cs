using NUnit.Framework;
using SeleniumCsharpPageObjectModel.page;
using SeleniumCsharpPageObjectModel.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpPageObjectModel.test
{
    [TestFixture]
    class ShoppingTest:Hooks
    {
        [Test]
        public void testShop()
        {
            ShoppingPage shopping = new ShoppingPage(driver);
            shopping.SelectTablet();
            shopping.BuyNow();
            shopping.IncreaseProductQuantity();
            shopping.AddToCart();
            shopping.CheckOutPage();

        }
    }
}
