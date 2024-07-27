﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4v2
{
    internal class Point
    {
        private double x, y;

        private string name;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }


        public Point(double x, double y, string Name)
        {
            this.x = x;
            this.y = y;
            this.name = Name;
        }
    }
}
