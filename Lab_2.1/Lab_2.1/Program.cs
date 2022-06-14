using System;

namespace Lab_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 4);
            Point C = new Point(4, 4);
            Point D = new Point(4, 0);
            Console.WriteLine(A.GetHashCode());
            Console.WriteLine(C.ToString());
            Console.WriteLine();

            Segment AB = new Segment(A, B);
            Segment BC = new Segment(B, C);
            Square square = new Square(AB, BC);
            Console.WriteLine(square.GetHashCode());
        }
    }
}

