using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public struct Point
    {
        private double x;
        private double y;

        public Point(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public double CalculateDistance(Point P)
        {
            return Math.Sqrt(Math.Pow(P.x - this.x, 2) + Math.Pow(P.y - this.y, 2));
        }
    }
}
