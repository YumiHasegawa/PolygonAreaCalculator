using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PolygonAreaCalculator
{
    class PolygonPoint
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public PolygonPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
