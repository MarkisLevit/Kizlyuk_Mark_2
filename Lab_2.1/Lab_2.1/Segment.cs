using System;

namespace Lab_2._1
{
    internal class Segment
    {
        public Point A { get; }
        public Point B { get; }
        public Segment()
        {
            A = new Point(0, 0);
            B = new Point(0, 1);
        }
        public Segment(Point StartPoint, Point FinalPoint)
        {
            this.A = StartPoint;
            this.B = FinalPoint;
        }
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow(B.Y - A.Y, 2));
            }
        }
        public override bool Equals(object a)
        {
            return A.X == B.X;
        }
        public override int GetHashCode()
        {
            return (int)Length;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
