using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Centaur : IToy
    {
        string name;
        int age;
        float h = 170f;
        bool beard;
        public Centaur(string n, int a, bool b)
        {
            age = a;
            name = n;
            beard = b;
        }
        public float Cost()
        {
            return 250f;
        }

        public float Height()
        {
            return h;
        }

        public string Summary()
        {
            if (beard)
            {
                return "I'm a centaur!" + "I am " + h + " cm high" + " My name is " + name + " I'm " + age + " year old and I have beard.";
            }
            else
            {
                return "I'm a centaur!" + "I am " + h + " cm high" + " My name is " + name + " I'm " + age + " year old and I have not beard.";
            }
        }
    }
}
