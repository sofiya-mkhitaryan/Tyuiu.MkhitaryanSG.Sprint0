﻿using Tyuiu.MkhitaryanSG.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "София";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, София", res);

        }
    }
}
