using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Uzduotis13
{
    public class Zalias
    {
        [Test]
        public void Dalyba_995_3()
        {
            double expectedResult = 0;
            double actualResult = Uzduotis13__zalias.Tikrinimas.Dalyba(995, 3);
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
