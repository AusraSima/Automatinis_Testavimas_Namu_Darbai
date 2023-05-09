using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoqaFramework.POM
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void WaitForElementIsVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(5));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);
            wait.Until(driver => driver.FindElement(By.XPath("//*[@id='loading']")));
        }
    }
}
