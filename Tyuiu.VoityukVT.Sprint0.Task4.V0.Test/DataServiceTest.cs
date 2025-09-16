using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoityukVT.Sprint0.Task4.V0.Lib;
namespace Tyuiu.VoityukVT.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(12, 7));
        }

        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(40, DataService.Multiplication(20, 2));
        }

        [TestMethod]

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(4, DataService.Division(16, 4));
        }

    }
}

