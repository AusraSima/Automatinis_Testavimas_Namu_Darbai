using NUnit.Framework;

[assembly: LevelOfParallelism(3)]
namespace Uzduotis13AT
{
    public class Zalias
    {
        [Test]
        public void Dalyba_995_3()
        {
            double expectedResult = 0;

            double actualResult = Uzduotis13zalias.Program.Tikrinimas.Dalyba(995, 3);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SavaitesDiena() 
        {
            string expectedResult = "Wednesday";

            string actualResult = Uzduotis13zalias.Program.Tikrinimas.SavaitesDiena();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Valanda() 
        {
            string expectedResult = "13:00";

            string actualResult = Uzduotis13zalias.Program.Tikrinimas.Valanda();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Arketuri() 
        {
            bool expectedResult = true;

            bool actualResult = Uzduotis13zalias.Program.Tikrinimas.ArKeturi();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
