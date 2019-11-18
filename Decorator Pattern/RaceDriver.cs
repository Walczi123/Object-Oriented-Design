using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class RaceDriver : IToy
    {
        float h = 35f;
        public float Cost()
        {
            return 200f;
        }

        public string Summary()
        {
            return "I'm a race driver." + "I am " + h + " cm high";
        }

        public float Height()
        {
            return 35f;
        }
    }
}
