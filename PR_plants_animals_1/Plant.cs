using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_plants_animals_1
{
    public abstract class Plant
    {
        public abstract void Grow();
    }

    class Grass : Plant
    {
        public override void Grow()
        {
            Console.WriteLine("Grass grows under the sun's rays.");
        }
    }

    class Weed : Plant
    {
        public override void Grow()
        {
            Console.WriteLine("Weed grows in salt water.");
        }
    }
}
