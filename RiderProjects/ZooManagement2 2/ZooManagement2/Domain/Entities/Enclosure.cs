using System;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Domain.Entities
{
    public class Enclosure
    {
        public EnclosureId Id { get; private set; }
        public EnclosureType Type { get; private set; }
        public double Size { get; private set; }
        public int CurrentCount { get; private set; }
        public int Capacity { get; private set; }

        private Enclosure() { }

        public Enclosure(
            EnclosureId id,
            EnclosureType type,
            double size,
            int capacity)
        {
            Id = id;
            Type = type;
            Size = size;
            Capacity = capacity;
            CurrentCount = 0;
        }

        public void AddAnimal()
        {
            if (CurrentCount + 1 > Capacity)
                throw new InvalidOperationException("Вольер переполнен");
            CurrentCount++;
        }

        public void RemoveAnimal()
        {
            if (CurrentCount == 0)
                throw new InvalidOperationException("Нет животных для удаления");
            CurrentCount--;
        }

        public void Clean() {}
    }
}