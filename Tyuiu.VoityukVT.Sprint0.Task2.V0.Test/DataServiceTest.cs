using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoityukVT.Sprint0.Task2.V0.Lib;
namespace Tyuiu.VoityukVT.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
          
            var name = "Валерий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Валерий", res);
        }
    }
}
