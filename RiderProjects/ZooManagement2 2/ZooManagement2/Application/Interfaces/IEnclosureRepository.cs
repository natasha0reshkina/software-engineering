using System.Collections.Generic;
using ZooManagement2.Domain.Entities;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Application.Interfaces
{
    public interface IEnclosureRepository
    {
        void Add(Enclosure enclosure);
        Enclosure GetById(EnclosureId id);
        void Remove(Enclosure enclosure);
        void Update(Enclosure enclosure);
        IEnumerable<Enclosure> ListAll();
    }
}