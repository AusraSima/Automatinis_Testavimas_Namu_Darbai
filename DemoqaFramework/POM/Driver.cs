using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoqaFramework.POM
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver() 
        {
            return driver;
        }

        internal static void OpenPage(string url) 
        {
            driver.Url = url;
        }

        public static void ShutdownDriver()
        {
            driver.Quit();
        }
    }
}
