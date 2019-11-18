using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Doll : IToy
    {
        float h = 20f;
        public float Cost()
        {
            return 100f;
        }

        public string Summary()
        {
            return "I'm a doll." + "I am " + h + " cm high";
        }
        public float Height()
        {
            return h;
        }
    }


}
