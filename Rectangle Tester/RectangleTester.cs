using System;
using Rectangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rect = Rectangle.Rectangle;
using Point = Rectangle.Point;

namespace Rect_Tester
{
    
    [TestClass]
    public class RectTester
    {
        
        [TestMethod]
        public void Constructor2Args()
        {
            //Does is initalize the correct bounds of the Rect?
            //(P1 x0, P1 y10) test
            Rect test1= new Rect(new Point(0, 10), new Point(5, 5));
            Assert.AreEqual(test1.getUpperLeftVertex().getX(), 0);
            Assert.AreEqual(test1.getUpperLeftVertex().getY(), 10);
            //Width and Height Assert.AreEqual for lowerRight boundry
            Assert.AreEqual(test1.getWidth(), 5);
            Assert.AreEqual(test1.getHeight(), 5);
            
            //(P1 x0, P2 y5) test
            Rect test2 = new Rect(new Point(0, 0), new Point(5, 5));
            Assert.AreEqual(test2.getUpperLeftVertex().getX(), 0);
            Assert.AreEqual(test2.getUpperLeftVertex().getY(), 5);
            //Width and Height Assert.AreEqual for lowerRight boundry
            Assert.AreEqual(test2.getWidth(), 5);
            Assert.AreEqual(test2.getHeight(), 5);

            //(P2 x5, P1 y10) test
            Rect test3 = new Rect(new Point(10, 10), new Point(5, 5));
            Assert.AreEqual(test3.getUpperLeftVertex().getX(), 5);
            Assert.AreEqual(test3.getUpperLeftVertex().getY(), 10);
            //Width and Height Assert.AreEqual for lowerRight boundry
            Assert.AreEqual(test3.getWidth(), 5);
            Assert.AreEqual(test3.getHeight(), 5);

            //(P2 x5, P2 y5) test
            Rect test4 = new Rect(new Point(10, 0), new Point(5, 5));
            Assert.AreEqual(test4.getUpperLeftVertex().getX(), 5);
            Assert.AreEqual(test4.getUpperLeftVertex().getY(), 5);
            //Width and Height Assert.AreEqual for lowerRight boundry
            Assert.AreEqual(test4.getWidth(), 5);
            Assert.AreEqual(test4.getHeight(), 5);

        }

        [TestMethod]
        public void Constructor3Args()
        {
            //Less testing seems to be needed for this,
            //as the width and height cannot be smaller than the initial point

            //(P1 x0, ) test
            //Same as rec.upperLeft = (0, 5);
            //rec.lowerRight = (5, 0);
            Rect test1 = new Rect(new Point(0, 0), 5, 3);
            //UpperLeft Assert.AreEqual
            Assert.AreEqual(test1.getUpperLeftVertex().getX(), 0);
            Assert.AreEqual(test1.getUpperLeftVertex().getY(), 3);
            //Width and Height Assert.AreEqual for lowerRight
            Assert.AreEqual(test1.getWidth(), 5);
            Assert.AreEqual(test1.getHeight(), 3);
        }
        
        [TestMethod]
        public void Translate()
        {
            Rect rec = new Rect(new Point(), 3, 5);
            rec.translate(5, 5);

            //Did it move upperLeft?
            Assert.AreEqual(rec.getUpperLeftVertex().getX(), 5);
            Assert.AreEqual(rec.getUpperLeftVertex().getY(), 10);

            //Did it move lowerRight?
            Assert.AreEqual(rec.getWidth(), 3);
            Assert.AreEqual(rec.getHeight(), 5);

        }

        [TestMethod]
        public void GetWidth()
        {
            //Find the width from a two point constructor?
            Assert.AreEqual(3, new Rect(new Point(), new Point(3, 5)).getWidth());
            //Finds the width from 3 arg constructor?
            Assert.AreEqual(3, new Rect(new Point(), 3, 5).getWidth());
            
        }

        [TestMethod]
        public void GetHeight()
        {
            //Find the height from a two point constructor?
            Assert.AreEqual(new Rect(new Point(), new Point(3, 5)).getHeight(), 5);
            //Finds the height from 3 arg constructor?
            Assert.AreEqual(new Rect(new Point(), 3, 5).getHeight(), 5);
        }

        [TestMethod]
        public void GetCenter()
        {
            Rect rec = new Rect(new Point(), new Point(3, 5));
            Point center = rec.getCenter();

            //Correct center?
            Assert.AreEqual(center.getX(), 1.5);
            Assert.AreEqual(center.getY(), 2.5);
        }

        [TestMethod]
        public void GetPerimeter()
        {
            //Adds perimeter correctly?
            Assert.AreEqual(new Rect(new Point(), new Point(3, 5)).getPerimeter(), 16);
        }

        [TestMethod]
        public void GetArea()
        {
            //Multiplies area correctly?
            Assert.AreEqual(new Rect(new Point(), new Point(3, 5)).getArea(), 15);
        }

        [TestMethod]
        public void GetUpperLeftVertex()
        {
            //p1 will be upperLeft
            Point p1 = new Point(0, 10);
            Point p2 = new Point(5, 5);
            Rect rec = new Rect(p1, p2);
            //Is p1 same as upperLeft?
            Assert.AreEqual(rec.getUpperLeftVertex().getX(), p1.getX());
            Assert.AreEqual(rec.getUpperLeftVertex().getY(), p1.getY());
        }

        [TestMethod]
        public void Contains()
        {
            Rect rec = new Rect(new Point(), new Point(3, 5));
            //Assert.AreEquals point within the Rect
            Assert.AreEqual(rec.contains(new Point(1, 1)), true);
            //Assert.AreEquals point outside of the Rect
            Assert.AreEqual(rec.contains(new Point(10, 10)), false);
        }
    }
}
