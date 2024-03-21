using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Point
    {
        private double pointA, pointB;
        private string text;

        public Point(double pointA, double pointB, string text)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.text = text;
        }

        public double PointA
        {
            get { return pointA; }
        }

        public double PointB
        {
            get { return pointB; }
        }

        public string Text
        {
            get { return text; }
        }
    }
}
