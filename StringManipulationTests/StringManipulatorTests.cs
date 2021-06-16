using NUnit.Framework;
using StringManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Tests
{
    [TestFixture()]
    public class StringManipulatorTests
    {
        [Test()]
        public void ReverseStringTest()
        {
            //Arrange
            string s = "gnagrevogewroops";
            //Act
            string sreverse = StringManipulator.ReverseString(s);
            //Assert
            Assert.AreEqual(sreverse, "spoorwegovergang");
                    }

        [Test()]
        public void RemoveWhitespaceTest()
        {
            //Arrange
            string s = "tijds besef";
            //Act
            string sNoWhite = StringManipulator.RemoveWhitespace(s);
            //Assert
            Assert.AreEqual(sNoWhite, "tijdsbesef");
        }
    }
}
