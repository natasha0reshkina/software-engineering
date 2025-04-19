using System;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Domain.Events
{
    public class AnimalMovedEvent
    {
        public AnimalId AnimalId { get; }
        public EnclosureId From { get; }
        public EnclosureId To { get; }
        public DateTime OccurredAt { get; }

        public AnimalMovedEvent(
            AnimalId animalId,
            EnclosureId from,
            EnclosureId to,
            DateTime occurredAt)
        {
            AnimalId = animalId;
            From = from;
            To = to;
            OccurredAt = occurredAt;
        }
    }
}