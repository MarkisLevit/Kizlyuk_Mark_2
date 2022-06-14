using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._1
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override bool Equals(object a)
        {
            return false;
        }
        public override int GetHashCode()
        {
            int a = (int)X + (int)Y;
            return a;
        }
        public override string ToString()
        {
            return $"This point has coordiante: {X} {Y}";
        }
        
    }
}
