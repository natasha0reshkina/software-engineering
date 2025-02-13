using System;
using System.Collections.Generic;
using System.Linq;
using minidz.Models.Animals;
using minidz.Models.Things;
namespace minidz.Services;


public class Zoo
{
    private readonly List<Animal> _animals = new();
    private readonly List<Thing> _inventory = new();

    public void AddAnimal(Animal animal)
    {
        if (VetClinic.CheckHealth())
        {
            _animals.Add(animal);
            Console.WriteLine($"{animal.Name} добавлен в зоопарк.");
        }
        else
        {
            Console.WriteLine($"{animal.Name} не прошел медосмотр.");
        }
    }

    public void AddThing(Thing thing)
    {
        _inventory.Add(thing);
    }

    public void PrintAnimals()
    {
        Console.WriteLine("\nСписок животных в зоопарке:");
        foreach (var animal in _animals)
        {
            Console.WriteLine(animal);
        }
    }

    public void PrintInventory()
    {
        Console.WriteLine("\nСписок инвентаря:");
        foreach (var item in _inventory)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintContactZooAnimals()
    {
        var contactAnimals = _animals.OfType<Herbo>()
            .Where(h => h.KindnessLevel > 5)
            .ToList();

        Console.WriteLine("\nЖивотные для контактного зоопарка:");
        foreach (var animal in contactAnimals)
        {
            Console.WriteLine(animal);
        }
    }

    public void PrintFoodRequirements()
    {
        int totalFood = _animals.Sum(a => a.Food);
        Console.WriteLine($"\nОбщее потребление пищи: {totalFood} кг/день.");
    }
    public List<Animal> GetAnimals() => _animals;
}
