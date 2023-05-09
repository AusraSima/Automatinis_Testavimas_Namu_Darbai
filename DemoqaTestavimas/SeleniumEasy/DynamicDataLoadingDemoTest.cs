
using DemoqaFramework.POM.DemoqaTextBox;
using DemoqaFramework.POM;
using NUnit.Framework;
using DemoqaFramework.POM.SeleniumEasy;

namespace DemoqaTestavimas.SeleniumEasy
{
    internal class DynamicDataLoadingDemoTest
    {
        [SetUp]

        public void SetUp()
        {
            Driver.InitializeDriver();
            DynamicDataLoadingDemo.Open();
        }

        [Test]

        public void WaitForUserInformationToAppear()
        {
            DynamicDataLoadingDemo.ClickGetNewUserButton();
        }

        [TearDown]

        public void TearDown()
        {
            Driver.ShutdownDriver();
        }

    }
}

