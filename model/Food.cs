using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._2024.model
{
    internal abstract class Food
    {
        public int Calorie;
        public Food(int calorie)
        {
            Calorie = calorie;
        }
        protected Food()
        {
            
        }
    }
}






