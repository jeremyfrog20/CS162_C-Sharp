using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    public class Point
    {
        private double x, y;

        //Initializer lists in c#
        /// <summary>
        /// Point Constructs at 0, 0
        /// </summary>
        public Point() => (x, y) = (0, 0);


        //Visual studio says this is the same thing.
        /// <summary>
        /// Point Constructs a point at the given coordinates
        /// </summary>
        /// <param name="startX">initial x location</param>
        /// <param name="startY">initial y location</param>
        public Point(in double startX, in double startY) => (x, y) = (startX, startY);
        

        /// <summary>
        /// getX Accesses x loction
        /// </summary>
        /// <returns>x coordinate</returns>
        public double getX()
        {
            return x;
        }

        /// <summary>
        /// Accesses y loction
        /// </summary>
        /// <returns>y coordinate</returns>
        public double getY()
        {
            return y;
        }

        /// <summary>
        /// setX Change the x location
        /// </summary>
        /// <param name="newX">New x location</param>
        public void setX(in double newX)
        {
            x = newX;
        }

        /// <summary>
        /// setX Change the y location
        /// </summary>
        /// <param name="newY">New y location</param>
        public void setY(in double newY)
        {
            y = newY;
        }

        /// <summary>
        /// translate Moves the point by the specified offset in x and y
        /// </summary>
        /// <param name="xShift">xShift Amount to move in x</param>
        /// <param name="yShift">yShift AMount to move in y</param>
        void translate(in double xShift, in double yShift)
        {
            x += xShift;
            y += yShift;
        }

        /// <summary>
        /// isSameAs Tests if two points represent approximately the same location
        /// </summary>
        /// <param name="other">Point to compare with this one</param>
        /// <returns>True if both x and y are within 0.0000001 of each other. Else false.</returns>
        bool isSameAs(in Point other)
        {
            if (this == other)
                return true;
            else
                return false;
        }

        /// <summary>
        /// distanceTo Calculates distance to another Point
        /// </summary>
        /// <param name="other">Point to measure distance to</param>
        /// <returns>Distance</returns>
        double distanceTo(in Point other)
        {
            double xDiff = x - other.x;
            double yDiff = y - other.y;
            return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        }


        /// <summary>
        /// print Prints formated information about Point to console
        /// </summary>
        void print()
        {
            Console.WriteLine($"Point at {x}, {y})");
        }
    }
}
