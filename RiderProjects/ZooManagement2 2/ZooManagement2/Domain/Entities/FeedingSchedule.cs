using System;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Domain.Entities
{
    public class FeedingSchedule
    {
        public Guid Id { get; private set; }
        public AnimalId AnimalId { get; private set; }
        public DateTime Time { get; private set; }
        public FoodType Food { get; private set; }
        public bool IsCompleted { get; private set; }

        private FeedingSchedule() { }

        public FeedingSchedule(
            Guid id,
            AnimalId animalId,
            DateTime time,
            FoodType food)
        {
            Id = id;
            AnimalId = animalId;
            Time = time;
            Food = food;
            IsCompleted = false;
        }

        public void Reschedule(DateTime newTime) => Time = newTime;
        public void MarkDone() => IsCompleted = true;
    }
}