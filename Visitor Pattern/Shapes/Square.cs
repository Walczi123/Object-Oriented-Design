namespace Shapes
{
    class Square : IShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double SideLength { get; set; }

        public Square(double x, double y, double sideLength)
        {
            X = x;
            Y = y;
            SideLength = sideLength;
        }

        public void Scale(double factor)
        {
            SideLength *= factor;
        }

        public void Translate(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public object Clone()
        {
            return new Square(X, Y, SideLength);
        }

        public override string ToString()
        {
            return $"({X}, {Y}), side length = {SideLength}";
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}