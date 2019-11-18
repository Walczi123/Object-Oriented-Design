using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ToyDecorator : IToy

    {
        public IToy _toy;
        public ToyDecorator(IToy toy)
        {
            _toy = toy;
        }
        public virtual float Cost()

        {
            return _toy.Cost();
        }

        public virtual string Summary()
        {
            return _toy.Summary();
        }

        public virtual float Height()
        {
            return _toy.Height();
        }
    }

    class SwordDecorator : ToyDecorator
    {
        public SwordDecorator(IToy toy) : base(toy)
        {
        }

        public override float Cost()
        {
            return base.Cost() + 15;
        }
        public override string Summary()
        {
            return base.Summary() + "I have a sword!";
        }
    }

    class HelmetDecorator : ToyDecorator
    {
        public HelmetDecorator(IToy toy) : base(toy)
        {
        }

        public override float Cost()
        {
            return base.Cost() + 10;
        }
        public override string Summary()
        {
            return base.Summary() + "I have a helmet on my head!";
        }
    }

    class DressDecorator : ToyDecorator
    {
        bool d;//true flower
        //If it’s flower it increases the cost of the toy by 20 and
        //by 19.99 if it’s dotted.
        public DressDecorator(IToy toy, bool b) : base(toy)
        {
            this.d = b;
        }

        public override float Cost()
        {
            if (d)
            {
                return base.Cost() + 20;
            }
            else
            {
                return base.Cost() + 19.99f;
            }
        }
        public override string Summary()
        {
            if (d)
            {
                return base.Summary() + " I have a flower dress.";
            }
            else
            {
                return base.Summary() + " I have a dotted dress.";
            }
        }
    }
    class JumpDecorator : ToyDecorator
    {
        private int jumpcount = 0;
        private double percent = 0.5;
        public JumpDecorator(IToy b) : base(b)
        { 
        }

        public override float Cost()
        {
            return base.Cost();
        }

        public override string Summary()
        {
            if (jumpcount < 5)
            {
                jumpcount++;
                return base.Summary() + $" I can jump! I've just jumped"+this.Height() * (percent - 0.1 * jumpcount);
            }
            else
            {
                return base.Summary();
            }

        }
    }

    class DanceDecorator : ToyDecorator
    {
        private string dance;

        public DanceDecorator(IToy b,string a) : base(b)
        {
            dance = a;
        }

        public override float Cost()
        {
            if (dance == "breakdance")
            {
                return base.Cost() + 50f;
            }
            else
            {
                if (dance == "solo capoeira")
                {
                    return base.Cost() + 70f;
                }
                else
                {
                    if (dance == "gangnam style")
                    {
                        return base.Cost() + 100f;
                    }
                    else
                    {
                        return base.Cost();
                    }
                }
            }
        }

        public override string Summary()
        {
            if (dance == "breakdance")
            {
                return base.Summary() + " I can dance "+dance;
            }
            else
            {
                if (dance == "solo capoeira")
                {
                    return base.Summary() + " I can dance " + dance;
                }
                else
                {
                    if (dance == "gangnam style")
                    {
                        return base.Summary() + " I can dance " + dance;
                    }
                    else
                    {
                        return base.Summary() + " I can't.";
                    }
                }
            }
        }    
    }
    class StoryDecorator : ToyDecorator
    {
        bool joke;
        public StoryDecorator(IToy b, bool a) : base(b)
        {
            joke = a;
        }

        public override float Cost()
        {
            return base.Cost() + 30f;
        }

        public override string Summary()
        {
            if (joke)
            {
                return base.Summary() + " I tell really funny jokes!";
            }
            else
            {
                return base.Summary() + " I tell scary stories";
            }

        }
    }
}
