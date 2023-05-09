
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
            Common.GetElementText(locator);
        }
    }
}
