using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._2024.model
{
    internal abstract class Animal
    {
        public string Breed;
        public abstract void MadeSound();
        public abstract void EatFood(Food food);
        public Animal(string breed)
        {
            Breed = breed;
        }
        protected Animal()
        {
            
        }
    }
}
