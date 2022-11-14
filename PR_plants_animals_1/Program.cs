// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using PR_plants_animals_1;

World world_first = new World(new SeeWorldFactory());
Console.WriteLine($"{nameof(world_first)} : ");
world_first.RunFoodChain();
Console.WriteLine("---------------------------------------------------");
World world_second = new World(new PeaceLandWorldFactory());
Console.WriteLine($"{nameof(world_second)} : ");
world_second.RunFoodChain();