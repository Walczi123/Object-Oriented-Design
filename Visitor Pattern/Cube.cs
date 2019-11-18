using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Cube : IShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double SideLength { get; set; }

        public Cube(double x, double y,double z, double sideLength)
        {
            X = x;
            Y = y;
            Z = z;
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
            Z = Z;
        }

        public object Clone()
        {
            return new Cube(X, Y,Z, SideLength);
        }

        public override string ToString()
        {
            return $"({X}, {Y},{Z}), side length = {SideLength}";
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
