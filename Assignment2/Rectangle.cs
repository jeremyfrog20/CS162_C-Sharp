using System;
using System.Collections.Generic;
using System.Text;


namespace Rectangle
{
    public class Rectangle
    {
        private Point upperLeftVertex, lowerRightVertex;

        private Point newUpperLeft(in Point p1, in Point p2)
        {
            double lowX, highY;

            //Comparing x
            if (p1.getX() < p2.getX())
                lowX = p1.getX();
            else
                lowX = p2.getX();

            //Comparing y
            if (p1.getY() > p2.getY())
                highY = p1.getY();
            else
                highY = p2.getY();

            return new Point(lowX, highY);
        }
        private Point newUpperLeft(in Point p1, in double height)
        {
            return new Point(p1.getX(), (p1.getY() + height));
        }
        private Point newLowerRight(in Point p1, in Point p2)
        {
            double highX, lowY;

            //Comparing x
            if (p1.getX() > p2.getX())
                highX = p1.getX();
            else
                highX = p2.getX();

            //Comparing y
            if (p1.getY() < p2.getY())
                lowY = p1.getY();
            else
                lowY = p2.getY();

            return new Point(highX, lowY);
        }

        private Point newLowerRight(in Point p1, in double width)
        {
            return new Point((p1.getX() + width), p1.getY());
        }

        //Public
        public Rectangle(in Point p1, in Point p2)
        {
            upperLeftVertex = newUpperLeft(p1, p2);
            lowerRightVertex = newLowerRight(p1, p2);
        }

        public Rectangle(in Point p1, in double width, in double height)
        {
            upperLeftVertex = newUpperLeft(p1, height);
            lowerRightVertex = newLowerRight(p1, width);
        }

        public void translate (in double xAmount, in double yAmount)
        {
            upperLeftVertex.setX(upperLeftVertex.getX() + xAmount);
            lowerRightVertex.setX(lowerRightVertex.getX() + xAmount);
            upperLeftVertex.setY(upperLeftVertex.getY() + yAmount);
            lowerRightVertex.setY(lowerRightVertex.getY() + yAmount);
        }

        public double getWidth()
        {
            return lowerRightVertex.getX() - upperLeftVertex.getX();
        }

        public double getHeight()
        {
            return upperLeftVertex.getY() - lowerRightVertex.getY();
        }

        public Point getUpperLeftVertex()
        {
            return upperLeftVertex;
        }

        public Point getCenter()
        {
            return new Point((getWidth() / 2), (getHeight() / 2));
        }

        public double getArea()
        {
            return getWidth() * getHeight();
        }

        public double getPerimeter()
        {
            return (2 * getWidth()) + (2 * getHeight());
        }

        public bool contains(in Point p)
        {
            //Within X bounds
            if ((upperLeftVertex.getX() <= p.getX()) && (lowerRightVertex.getX() >= p.getX()))

            {
                //Within Y bounds
                if ((upperLeftVertex.getY() >= p.getY()) && (lowerRightVertex.getY() <= p.getY()))
                {
                    return true;
                }
            }
            return false;
        }












    }
}
