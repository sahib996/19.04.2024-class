using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._2024.model
{
    internal class Cow : Animal
    {
        public string Breed;
        public Cow(string breed) : base(breed)
        {
            Breed = breed;
        }
        public override void EatFood(Food food)
        {
            if (food is Grass)
            {
                Console.WriteLine("duz qida");
            }
            else
            {
                Console.WriteLine("yanlish qida");
            }
        }

        public override void MadeSound()
        {
            Console.WriteLine("moo");
        }

        public void ProductMilk()
        {
            Console.WriteLine("milk product");
        }
    }
}
