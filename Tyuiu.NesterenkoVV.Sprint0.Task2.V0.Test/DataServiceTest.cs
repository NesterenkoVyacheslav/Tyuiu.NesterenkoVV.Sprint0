using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NesterenkoVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NesterenkoVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Вячеслав";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Вячеслав", res);
        }
    }
}
