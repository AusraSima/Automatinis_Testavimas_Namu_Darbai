
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
            string expectedResult = "First name";
            
            DynamicDataLoadingDemo.ClickGetNewUserButton();
            
            string actualResult = DynamicDataLoadingDemo.GetFirstName();

            StringAssert.AreEqualIgnoringCase(actualResult, expectedResult);
        }

        [TearDown]

        public void TearDown()
        {
            Driver.ShutdownDriver();
        }

    }
}

