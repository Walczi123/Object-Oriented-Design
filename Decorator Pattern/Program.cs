using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IToy doll = new Doll();
            IToy warrior = new Warrior();
            IToy raceDriver = new RaceDriver();
            // Please make sure to put here the code which shows what you've implemented
            warrior = new SwordDecorator(warrior);
            warrior = new HelmetDecorator(warrior);
            warrior = new JumpDecorator(warrior);
            //Console.WriteLine(warrior.Cost());
            //Console.WriteLine(warrior.Summary());
            //Console.WriteLine(warrior.Summary());
            //Console.WriteLine(warrior.Summary());
            //Console.WriteLine(warrior.Summary());
            //Console.WriteLine(warrior.Summary());
            //Console.WriteLine(warrior.Summary());
            //Console.WriteLine(warrior.Summary());
            doll = new DanceDecorator(doll, "gangnam style");
            doll = new DanceDecorator(doll, "breakdance");
            doll = new DressDecorator(doll, true);
            //Console.WriteLine(doll.Cost());
            //Console.WriteLine(doll.Summary());
            raceDriver = new StoryDecorator(raceDriver, true);
            //Console.WriteLine(raceDriver.Cost());
            //Console.WriteLine(raceDriver.Summary());
            IToy minotaur = new Minotaur("Adam", 23, 1000);
            //Console.WriteLine(minotaur.Cost());
            //Console.WriteLine(minotaur.Summary());
            IToy centaur = new Centaur("Adam", 23, true);

            centaur = new SwordDecorator(centaur);
            centaur = new HelmetDecorator(centaur);
            Console.WriteLine(centaur.Cost());
            Console.WriteLine(centaur.Summary());


        }
    }
}
