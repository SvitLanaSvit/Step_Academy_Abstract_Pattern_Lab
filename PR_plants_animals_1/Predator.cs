using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_plants_animals_1
{
    public abstract class Predator
    {
        public abstract void EatHervorous();
    }

    class Fox : Predator
    {
        public override void EatHervorous()
        {
            Console.WriteLine("Fox eat hare.");
        }
    }

    class Pike : Predator
    {
        public override void EatHervorous()
        {
            Console.WriteLine("Pike eat grassKarpen.");
        }
    }
}
