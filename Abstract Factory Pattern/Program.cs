using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDo: implementation
            Zoo African = new AfricanZoo();
            Zoo American = new SouthAmericanZoo();
            Zoo Asian = new AsiaZoo();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Exit")
                    break;

                if (input == "African")
                {
                    African.PrintZoo();
                }

                if (input == "American")
                {
                    American.PrintZoo();
                }

                if (input == "Asian")
                {
                    Asian.PrintZoo();
                }

                if (input == "Mixed1")
                {
                    FoodChain(African.plant(), American.herbivore(), Asian.carnivore());
                }
                
                if (input == "Mixed2")
                {
                    FoodChain(Asian.plant(), African.herbivore(), Asian.carnivore());
                }
                
                if (input == "Mixed3")
                {
                    FoodChain(Asian.plant(), African.herbivore(), African.carnivore());
                }
            }
        }

        public static void FoodChain(Plant plant, Herbivore herbivore, Carnivore carnivore)
        {
            Console.WriteLine("Food Chain:");
            herbivore.Eat(plant);
            carnivore.Eat(herbivore);
        }
    }
}
