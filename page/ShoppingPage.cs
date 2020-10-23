using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpPageObjectModel.page
{
    class ShoppingPage
    {
        IWebDriver driver;
        public ShoppingPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void SelectTablet()
        {
            driver.FindElement(By.Id("tabletsImg")).Click();
        }

        public void BuyNow()
        {
            driver.FindElement(By.Name("buy_now")).Click();
        }

        public void IncreaseProductQuantity()
        {
            driver.FindElement(By.ClassName("plus")).Click();
        }

        public void AddToCart()
        {
            driver.FindElement(By.Name("save_to_cart")).Click();
        }

        public void CheckOutPage()
        {
            driver.FindElement(By.Id("checkOutPopUp")).Click();
        }
    }
}
