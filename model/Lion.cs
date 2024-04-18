using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._2024.model
{
    internal class Lion : Animal
    {
        public bool IsPrideLeader;
        public Lion(string breed, bool isPrideLeader) : base(breed)
        {
            IsPrideLeader = isPrideLeader;
        }
        public override void EatFood(Food food)
        {
            if(food is Meat)
            {
                Console.WriteLine("Ugurla qidalandi");
            }
            else
            {
                Console.WriteLine("yanlishdir");
            }
        }

        public override void MadeSound()
        {
            Console.WriteLine("aaaaa");
        }
    }
}
