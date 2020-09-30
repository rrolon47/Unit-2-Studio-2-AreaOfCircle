using System;
using System.Collections.Generic;
using System.Text;

namespace Studio2
{
    class Circle
    {

        public static double Area(string radius)
        {
            double r = double.Parse(radius);
            return Math.PI * Math.Pow(r, 2);
        }

        public static double Circumference(string radius)
        {
            double r = double.Parse(radius);
            return 2 * Math.PI * r;
        }
    }
}
