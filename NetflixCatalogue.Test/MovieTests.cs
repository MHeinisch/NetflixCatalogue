using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void OverrideToStringShouldPrintNameAndDurationTest()
        {
            //arrange
            string name = "The Pianist";
            double duration = 200;
            string toString = "The Pianist\t(200m)";
            //act
            string actualString = name + "\t(" + duration + "m)";
            //assert
            Assert.AreEqual(toString, actualString);
        }
    }
}