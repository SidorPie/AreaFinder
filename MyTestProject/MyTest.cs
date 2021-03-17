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
            Shape shape = new Shape(new Triangle(3, 4, 5));
            double area = shape.Search();
            double expected = 6;
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void TestSearchAreaCircle()
        {
            Shape shape = new Shape(new Circle(3));
            double area = shape.Search();
            double expected = 28.27;
            Assert.AreEqual(expected, Math.Round(area, 2));
        }
    }
}
