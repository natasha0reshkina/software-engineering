using ZooManagement2.Application.Interfaces;
using ZooManagement2.Domain.Entities;
using ZooManagement2.Domain.Events;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Application.Services
{
    public class AnimalTransferService : IAnimalTransferService
    {
        private readonly IAnimalRepository _animals;
        private readonly IEnclosureRepository _enclosures;
        private readonly IEventPublisher _publisher;

        public AnimalTransferService(
            IAnimalRepository animals,
            IEnclosureRepository enclosures,
            IEventPublisher publisher)
        {
            _animals = animals;
            _enclosures = enclosures;
            _publisher = publisher;
        }

        public void Transfer(AnimalId animalId, EnclosureId toEnclosureId)
        {
            var animal = _animals.GetById(animalId);
            var from = _enclosures.GetById(animal.CurrentEnclosureId);
            var to = _enclosures.GetById(toEnclosureId);

            to.AddAnimal();
            from.RemoveAnimal();

            var @event = animal.MoveTo(toEnclosureId);
            _animals.Update(animal);
            _enclosures.Update(from);
            _enclosures.Update(to);
            _publisher.Publish(@event);
        }
    }
}