using System.Collections.Generic;
using ZooManagement2.Domain.Entities;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Application.Interfaces
{
    public interface IAnimalRepository
    {
        void Add(Animal animal);
        Animal GetById(AnimalId id);
        void Remove(Animal animal);
        void Update(Animal animal);
        IEnumerable<Animal> ListAll();
    }
}