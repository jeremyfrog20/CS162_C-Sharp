using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle;
using Rect = Rectangle.Rectangle;
using Point = Rectangle.Point;

namespace Assignment2
{
    class Program
    {
        public List<Rect> initRectangles(in int count)
        {
            List<Rect> newRectangles = new List<Rect>();

            for (int i = 0; i < count; i++)
            {
                newRectangles.Add(new Rect(new Point((double)i, 0), new Point(0, (double)i)));
            }

            return newRectangles;
        }

        static void Main(string[] args)
        {
            
            

        }
    }
}
