using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes

{
    interface IVisitor
    {
        void Visit(IShape shape);
        void Visit(Line line);
        void Visit(Circle circle);
    }

    class SVGVisitor : IVisitor
    {
        public void Visit(IShape _shape)
        {
            IShape shape = _shape;
            Console.WriteLine("Exporting " + shape.GetType().ToString() + " : " + shape.ToString());
        }

        public void Visit(Line line)
        {
            if(line.X==line.DX|| line.Y == line.DY)
                Console.WriteLine("Exporting " + line.ToString() + " : " + line.ToString());
            else
            {
                Console.WriteLine("This line is not pararell");
            }
        }

        public void Visit(Circle circle)
        {
            Console.WriteLine("Circle is not pararell");
        }
    }

    class JPGVisitor : IVisitor
    {
        public int compressionLevel;
        public JPGVisitor(int cmp)
        {
            compressionLevel = cmp;
        }

        public void Visit(IShape _shape)
        {
            Random rng = new Random();
            IShape shape = _shape.Clone() as IShape;
            shape.Scale(rng.NextDouble() + 0.1 * compressionLevel);
            shape.Translate(rng.Next(-compressionLevel, compressionLevel), rng.Next(-compressionLevel, compressionLevel));
            Console.WriteLine("Exporting " + shape.GetType().ToString() + " : " + shape.ToString());
        }

        public void Visit(Line line)
        {
            if (line.X == line.DX || line.Y == line.DY)
            {
                Random rng = new Random();
                IShape shape = line.Clone() as IShape;
                shape.Scale(rng.NextDouble() + 0.1 * compressionLevel);
                shape.Translate(rng.Next(-compressionLevel, compressionLevel), rng.Next(-compressionLevel, compressionLevel));
                Console.WriteLine("Exporting " + shape.GetType().ToString() + " : " + shape.ToString());
            }
            else
            {
                Console.WriteLine("This line is not pararell");
            }
        }

        public void Visit(Circle circle)
        {
            Console.WriteLine("Circle is not pararell");
        }
    }
}