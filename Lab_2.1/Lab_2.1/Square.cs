using System;

namespace Lab_2._1
{
    internal class Square
    {
        public Segment FirstSegment { get; set; }
        public Segment SecondSegment { get; set; }
        public Segment ThirdSegment { get; set; }
        public Segment FourthSegment { get; set; }
        private bool isSquare(Segment FirstSegment, Segment SecondSegment)
        {
            return FirstSegment.Length == SecondSegment.Length && ((FirstSegment.A == SecondSegment.A &&
                FirstSegment.A != SecondSegment.B) ||
                (FirstSegment.B == SecondSegment.B && FirstSegment.A != SecondSegment.B) ||
                (FirstSegment.A == SecondSegment.B && FirstSegment.B != SecondSegment.A) ||
                (FirstSegment.B == SecondSegment.A && FirstSegment.A != SecondSegment.B));
        }
        public Square()
        {
            FirstSegment = new Segment(new Point(0, 0), new Point(0, 1));
            SecondSegment = new Segment(new Point(0, 0), new Point(1, 0));
            ThirdSegment = new Segment(new Point(0, 1), new Point(1, 1));
            FourthSegment = new Segment(new Point(1, 1), new Point(1, 0));
        }
        public Square(Segment FirstSegment, Segment SecondSegment)
        {
            if (isSquare(FirstSegment, SecondSegment))
            {
                this.FirstSegment = FirstSegment;
                this.SecondSegment = SecondSegment;
                if (FirstSegment.A == SecondSegment.A)
                {
                    ThirdSegment = new Segment(new Point(FirstSegment.B.X, FirstSegment.B.Y),
                        new Point(FirstSegment.B.X, SecondSegment.B.Y));
                    FourthSegment = new Segment(new Point(SecondSegment.B.X, SecondSegment.B.Y),
                        new Point(FirstSegment.B.X, SecondSegment.B.Y));
                }
                else if (FirstSegment.B == SecondSegment.B)
                {
                    ThirdSegment = new Segment(new Point(SecondSegment.A.X, FirstSegment.A.Y),
                        new Point(FirstSegment.A.X, FirstSegment.A.Y));
                    FourthSegment = new Segment(new Point(SecondSegment.A.X, FirstSegment.A.Y),
                        new Point(SecondSegment.A.X, SecondSegment.A.Y));
                }
                else
                {
                    ThirdSegment = new Segment(new Point(SecondSegment.B.X, SecondSegment.B.Y),
                        new Point(SecondSegment.B.X, FirstSegment.A.Y));
                    FourthSegment = new Segment(new Point(SecondSegment.B.X, FirstSegment.A.Y),
                        new Point(FirstSegment.A.X, FirstSegment.A.Y));
                }
            }
            else
            {
                Console.WriteLine("You wrote wrong coordinates");
            }
        }

        public override string ToString()
        {
            return " ";
        }
        public override bool Equals(object a)
        {
            return FirstSegment.Length == SecondSegment.Length;
        }
        public override int GetHashCode()
        {
            return (int)FirstSegment.A.Y + (int)ThirdSegment.A.Y;
        }
    }
}
