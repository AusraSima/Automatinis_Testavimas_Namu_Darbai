
using DemoqaFramework.POM;
using DemoqaFramework.POM.DemoqaTextBox;
using NUnit.Framework;

namespace DemoqaTestavimas
{
    internal class DemoqaTextBoxTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            DemoqaTextBox.Open();
        }

        [Test]

        public void DemoqaTestBoxIvedimas()
        {
            string expectedResult1 = "Rimas Rimkus ";
            string expectedResult2 = "rimas@abc.com ";
            string expectedResult3 = "Pirma g.1-2, Kaunas ";
            string expectedResult4 = "Pirma g.1-2, Kaunas ";


            DemoqaTextBox.EnterFullName(expectedResult1);
            DemoqaTextBox.EnterEMail(expectedResult2);
            DemoqaTextBox.EnterCurrentAddress(expectedResult3);
            DemoqaTextBox.EnterPermanentAddress(expectedResult4);
            DemoqaTextBox.ClickButtonSubmit();

            string actualResult1 = DemoqaTextBox.GetFullName();
            string actualResult2 = DemoqaTextBox.GetEMail();
            string actualResult3 = DemoqaTextBox.GetCurrentAddress();
            string actualResult4 = DemoqaTextBox.GetPermanentAddress();

            Assert.AreEqual(expectedResult1, actualResult1);
            Assert.AreEqual(expectedResult2, actualResult2);
            Assert.AreEqual(expectedResult3, actualResult3);
            Assert.AreEqual(expectedResult4, actualResult4);
        }
        [TearDown]
        public void TearDown()
        {
            //Driver.ShutdownDriver();
        }
    }
}