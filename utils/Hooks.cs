using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpPageObjectModel.utils
{
    [SetUpFixture]
    class Hooks
    {
        public IWebDriver driver;
        [OneTimeSetUp]

        public void SetUp()
        {

            string browser = TestContext.Parameters.Get("browser", null);
            if (!String.IsNullOrEmpty(browser))
            {

                if (browser.Equals("chrome"))
                {
                    driver = new ChromeDriver();
                }
                else if (browser.Equals("opera"))
                {
                    driver = new FirefoxDriver();
                }
                else if (browser.Equals("IE"))
                {
                    driver = new InternetExplorerDriver();
                }
                else
                {
                    Assert.Fail("Unsupported browser");
                }
            }
            else
            {
                driver = new ChromeDriver();
            }
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // HP demo site
            driver.Navigate().GoToUrl("http://advantageonlineshopping.com/");


        }
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
