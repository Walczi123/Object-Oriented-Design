using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{ 
    class Minotaur : IToy
    {
        string name;
        int age;
        float h = 150f;
        float mass = 1000f;
        public Minotaur(string n,int a, float m)
        {
            age = a;
            name = n;
            mass = m;
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
            return "I'm a minotaur!" + "I am " + h + " cm high"+ " My naame is "+name+" I'm "+age+" year old and my mass is "+mass;
        }
    }
}
