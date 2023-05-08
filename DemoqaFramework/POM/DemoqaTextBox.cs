using OpenQA.Selenium;
using System;


namespace DemoqaFramework.POM
{
    public class DemoqaTextBox
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/text-box");
        }

        public static void EnterFullName(string message)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeys(locator, message);
        }

        public static string GetFullName()
        {
            string locator = "//*[@id='userName']";
            return Common.GetElementText(locator);
        }

        public static void EnterEMail(string message)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, message);
        }

        public static string GetEMail()
        {
            string locator = "//*[@id='userEmail']";
            return Common.GetElementText(locator);
        }

        public static void EnterCurrentAddress(string message)
        {
            string locator = "//*[@id='currentAddress']";
            Common.SendKeys(locator, message);
        }

        public static string GetCurrentAddress()
        {
            string locator = "//*[@id='currentAddress']";
            return Common.GetElementText(locator);
        }

        public static void EnterPermanentAddress(string message)
        {
            string locator = "//*[@id='permanentAddress']";
            Common.SendKeys(locator, message);
        }

        public static string GetPermanentAddress()
        {
            string locator = "//*[@id='permanentAddress']";
            return Common.GetElementText(locator);
        }

        public static void ClickButtonSubmit()
        {
            string locator = "//*[@id='submit']";
            Common.Click(locator);
        }        
    }
}
