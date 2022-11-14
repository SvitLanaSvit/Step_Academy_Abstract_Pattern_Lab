using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_plants_animals_1
{
    public abstract class Herbivorous
    {
        public abstract void EatGrass();
    }

    class Hare : Herbivorous
    {
        public override void EatGrass()
        {
            Console.WriteLine("Hare eat grass.");
        }
    }

    class GrassKarpen : Herbivorous
    {
        public override void EatGrass()
        {
            Console.WriteLine("GrassKarpen eats weed.");
        }
    }
}