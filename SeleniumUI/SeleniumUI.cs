using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTests
{
    [TestFixture]
    public class Exported
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();

            //TODO: change port accordingly.
            
            baseURL = "http://localhost:6391/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheExportedTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.XPath("//div[@id='calculator']/div[2]/span[8]")).Click();
            driver.FindElement(By.XPath("//div[@id='calculator']/div[2]/span[9]")).Click();
            driver.FindElement(By.CssSelector("span.eval")).Click();
            Assert.AreEqual("28657", driver.FindElement(By.Id("FibonacciSeries")).Text);
            Assert.AreEqual("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23", driver.FindElement(By.Id("FullSeries")).Text);
            Assert.AreEqual("2,4,6,8,10,12,14,16,18,20,22", driver.FindElement(By.Id("evens")).Text);
            Assert.AreEqual("1,3,5,7,9,11,13,15,17,19,21,23", driver.FindElement(By.Id("odds")).Text);
            Assert.AreEqual("3,6,9,12,15,18,21", driver.FindElement(By.Id("c")).Text);
            Assert.AreEqual("5,10,15,20", driver.FindElement(By.Id("e")).Text);
            Assert.AreEqual("15", driver.FindElement(By.Id("z")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
