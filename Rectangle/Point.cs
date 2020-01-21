using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Point
    {
        private double x, y;
        //Initializer lists in c#
        Point() => (x, y) = (0, 0);

        Point(double startX, double startY) => (x, y) = (0, 0);
    }
}
