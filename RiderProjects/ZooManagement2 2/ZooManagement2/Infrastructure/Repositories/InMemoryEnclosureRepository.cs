using System;
using System.Collections.Generic;
using System.Linq;
using ZooManagement2.Application.Interfaces;
using ZooManagement2.Domain.Entities;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Infrastructure.Repositories
{
    public class InMemoryEnclosureRepository : IEnclosureRepository
    {
        private readonly List<Enclosure> _store = new();

        public void Add(Enclosure enclosure) => _store.Add(enclosure);

        public Enclosure GetById(EnclosureId id)
            => _store.SingleOrDefault(x => x.Id.Value == id.Value)
               ?? throw new KeyNotFoundException("Enclosure not found");

        public void Remove(Enclosure enclosure) => _store.Remove(enclosure);

        public void Update(Enclosure enclosure) { }

        public IEnumerable<Enclosure> ListAll() => _store;
    }
}