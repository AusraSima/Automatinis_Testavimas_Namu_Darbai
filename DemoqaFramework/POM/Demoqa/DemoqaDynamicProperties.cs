using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoqaFramework.POM.Demoqa
{
    public class DemoqaDynamicProperties
    {

        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/dynamic-properties");
        }

        public static void ClickWillEnable5SeconsButton()
        {
            string locator = "//*[@id='enableAfter']";
            Common.Click(locator);
        }

        public static void ClickColorChangeButton()
        {
            string locator = "//*[@id='colorChange']";
            Common.WaitForElementIsVisible(locator);
            Common.Click(locator);
        }

        public static void ClickVisibleAfter5SecondsButton()
        {
            string locator = "//*[@id='visibleAfter']";
            Common.WaitForElementIsVisible(locator);
            Common.Click(locator);
        }
    }
}
