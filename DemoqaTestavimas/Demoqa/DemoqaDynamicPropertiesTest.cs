using DemoqaFramework.POM.DemoqaTextBox;
using DemoqaFramework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoqaFramework.POM.Demoqa;

namespace DemoqaTestavimas
{
    internal class DemoqaDynamicPropertiesTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            DemoqaDynamicProperties.Open();
        }

        [Test]


        public void CheckWillWnable5SecondsButton()
        {
            DemoqaDynamicProperties.ClickWillEnable5SeconsButton();
        }

        [Test]

        public void CheckColorChangeButton()
        {
            DemoqaDynamicProperties.ClickColorChangeButton();
        }

        [Test]

        public void CheckVisibleAfter5SecondsButton()
        {
            DemoqaDynamicProperties.ClickVisibleAfter5SecondsButton();
        }
        
        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
