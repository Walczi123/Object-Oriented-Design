using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_2
{
    public abstract class Zoo
    {
        public abstract Plant plant();
        public abstract Herbivore herbivore();
        public abstract Carnivore carnivore();
        public void PrintZoo()
        {
            Program.FoodChain(plant(), herbivore(), carnivore());
        }
    }

    public class AfricanZoo : Zoo
    {
        public override Plant plant() { return new Grass(); }
        public override Herbivore herbivore() { return new Gazelle(); }
        public override Carnivore carnivore() { return new Lion(); }
    }

    public class SouthAmericanZoo : Zoo
    {
        public override Plant plant() { return new Cattails(); }
        public override Herbivore herbivore() { return new Llama(); }
        public override Carnivore carnivore() { return new Puma(); }
    }

    public class AsiaZoo : Zoo
    {
        public override Plant plant() { return new Bamboo(); }
        public override Herbivore herbivore() { return new GiantPanda(); }
        public override Carnivore carnivore() { return new Leopard(); }
    }
}
