using System;

namespace ZooManagement2.Domain.ValueObjects
{
    public sealed class AnimalId
    {
        public Guid Value { get; }
        public AnimalId(Guid value)
            => Value = value != Guid.Empty
                ? value
                : throw new ArgumentException("Id не может быть пустым");
        public static AnimalId NewId() => new AnimalId(Guid.NewGuid());
    }
}