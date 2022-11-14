using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_plants_animals_1
{
    public abstract class WoldFactory
    {
        public abstract Plant CreatePlant();
        public abstract Herbivorous CreateHerbivorous();
        public abstract Predator CreatePredator();
    }

    class SeeWorldFactory : WoldFactory
    {
        public override Herbivorous CreateHerbivorous()
        {
            return new GrassKarpen();
        }

        public override Plant CreatePlant()
        {
            return new Weed();
        }

        public override Predator CreatePredator()
        {
            return new Pike();
        }
    }

    class PeaceLandWorldFactory : WoldFactory
    {
        public override Herbivorous CreateHerbivorous()
        {
            return new Hare();
        }

        public override Plant CreatePlant()
        {
            return new Grass();
        }

        public override Predator CreatePredator()
        {
            return new Fox();
        }
    }

}
