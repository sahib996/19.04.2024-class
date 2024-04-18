using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._2024.model
{
    internal class Meat:Food
    {
        public string Type;

        public Meat(int Calorie,string name, string type): base(Calorie)
        {
            Type = type;
        }
        public Meat()
        {
            
        }
    }
}
