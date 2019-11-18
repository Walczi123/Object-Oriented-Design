using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Warrior : IToy
    {
        float h = 50f;
        public float Cost()
        {
            return 150f;
        }

        public float Height()
        {
            return h;
        }

        public string Summary()
        {
            return "I'm a warrior!" + "I am "+h+" cm high";
        }
    }
}
