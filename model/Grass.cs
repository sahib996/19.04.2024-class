using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._2024.model
{
    internal class Grass:Food
    {

        public string Name;
            public Grass(int Calorie,string name) : base(Calorie)
        {
            Name= name;
        }
        public Grass()
        {
            
        }
    }
}
