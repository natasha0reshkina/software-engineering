using System;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Domain.Events
{
    public class FeedingTimeEvent
    {
        public Guid ScheduleId { get; }
        public AnimalId AnimalId { get; }
        public DateTime Time { get; }

        public FeedingTimeEvent(
            Guid scheduleId,
            AnimalId animalId,
            DateTime time)
        {
            ScheduleId = scheduleId;
            AnimalId = animalId;
            Time = time;
        }
    }
}