
namespace DemoqaFramework.POM.SeleniumEasy
{
    public class DynamicDataLoadingDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }

        public static void ClickGetNewUserButton()
        {
            string locator = "//*[@id='save']";
            
            Common.Click(locator);
            Common.WaitForElementIsVisible(locator);
        }

        public static string GetFirstName()
        {
            string locator = "//*[@id='loading']/text()[1]";
            return Common.GetElementText(locator);
        }
    }
}
