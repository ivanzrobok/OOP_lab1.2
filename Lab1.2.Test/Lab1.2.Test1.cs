using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOP_lab1._2;
namespace Lab1._2.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Vector1 vector = new Vector1();
            vector.CreateArray(5);
            for (int i = 0; i < 5; i++)
                vector.SetElementArray(i, i + 1);
            Assert.AreEqual(vector.GetElementArray(0), 1);
            Assert.AreEqual(vector.GetElementArray(4), 5);


        }
    }
}
