using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaFinder;
using System;

namespace MyTestProject
{
    [TestClass]
    public class MyTest
    {
        [TestMethod]
        public void TestSearchAreaTriangle()
        {
            double expected = 6;
            var shape2 = new Triangle(3, 4, 5);
            Assert.AreEqual(expected, shape2.SearchArea());
        }

        [TestMethod]
        public void TestSearchAreaCircle()
        {
            var shape1 = new Circle(3);
            double expected = 28.27;
            Assert.AreEqual(expected, Math.Round(shape1.SearchArea(), 2));
        }
    }
}
