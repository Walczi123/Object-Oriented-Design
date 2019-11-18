using System;

namespace Shapes
{
    interface IShape : ICloneable
    {
        void Scale(double factor);
        void Translate(double dx, double dy);
        void Accept(IVisitor visitor);

    }
}