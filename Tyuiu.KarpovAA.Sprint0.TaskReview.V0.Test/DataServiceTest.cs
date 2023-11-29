using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KarpovAA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var res = DataService.Calc(1, 1, 1);
            Assert.AreEqual(15, res);
        }
    }
}
