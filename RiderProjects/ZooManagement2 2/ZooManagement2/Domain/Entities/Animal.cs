using System;
using ZooManagement2.Domain.ValueObjects;
using ZooManagement2.Domain.Events;

namespace ZooManagement2.Domain.Entities
{
    public class Animal
    {
        public AnimalId Id { get; private set; }
        public string Species { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Gender Gender { get; private set; }
        public FoodType FavoriteFood { get; private set; }
        public AnimalStatus Status { get; private set; }
        public EnclosureId CurrentEnclosureId { get; private set; }

        private Animal() { }

        public Animal(
            AnimalId id,
            string species,
            string name,
            DateTime birthDate,
            Gender gender,
            FoodType favoriteFood)
        {
            Id = id;
            Species = species;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            FavoriteFood = favoriteFood;
            Status = AnimalStatus.Healthy;
        }

        public void Feed() { }

        public void Treat() => Status = AnimalStatus.Healthy;

        public AnimalMovedEvent MoveTo(EnclosureId newEnclosure)
        {
            var old = CurrentEnclosureId;
            CurrentEnclosureId = newEnclosure;
            return new AnimalMovedEvent(Id, old, newEnclosure, DateTime.UtcNow);
        }
    }
}