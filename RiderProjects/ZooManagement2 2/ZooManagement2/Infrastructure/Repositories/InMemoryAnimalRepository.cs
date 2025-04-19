using System;
using System.Collections.Generic;
using System.Linq;
using ZooManagement2.Application.Interfaces;
using ZooManagement2.Domain.Entities;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Infrastructure.Repositories
{
    public class InMemoryAnimalRepository : IAnimalRepository
    {
        private readonly List<Animal> _store = new();

        public void Add(Animal animal) => _store.Add(animal);

        public Animal GetById(AnimalId id)
            => _store.SingleOrDefault(x => x.Id.Value == id.Value)
               ?? throw new KeyNotFoundException("Animal not found");

        public void Remove(Animal animal) => _store.Remove(animal);

        public void Update(Animal animal) { }

        public IEnumerable<Animal> ListAll() => _store;
    }
}