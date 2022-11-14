using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_plants_animals_1
{
    public class World
    {
        private Plant plant;
        private Herbivorous herbivorous;
        private Predator predator;
        public World(WoldFactory factory)
        {
            plant = factory.CreatePlant();
            herbivorous = factory.CreateHerbivorous();
            predator = factory.CreatePredator();
        }

        public void RunFoodChain()
        {
            plant.Grow();
            herbivorous.EatGrass();
            predator.EatHervorous();
        }
    }
}
