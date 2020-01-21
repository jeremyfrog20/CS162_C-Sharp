using System;
using Rectangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rectangle_Tester
{
    [TestClass]
    public class PointTester
    {
        [TestMethod]
        public void DefaultConstructor()
        {
            Point point = new Point();
            Assert.AreEqual(point.getX(), 0);
            Assert.AreEqual(point.getY(), 0);
        }
        [TestMethod]
        public void SecondConstructor()
        {
            Point point = new Point(5, 5);
            Assert.AreEqual(point.getX(), 5);
            Assert.AreEqual(point.getY(), 5);
        }
    }
}
