using System;
using minidz.Services;
using minidz.Models.Animals;
using minidz.Models.Things;

namespace minidz
{
    class Program
    {
        static void Main()
        {
            Zoo zoo = new();

            zoo.AddAnimal(new Rabbit(1, 7));
            zoo.AddAnimal(new Monkey(2, 4));
            zoo.AddAnimal(new Tiger(3));
            zoo.AddAnimal(new Wolf(4));

            zoo.AddThing(new Table(101));
            zoo.AddThing(new Computer(102));

            zoo.PrintAnimals();
            zoo.PrintInventory();
            zoo.PrintContactZooAnimals();
            zoo.PrintFoodRequirements();
        }
    }
}