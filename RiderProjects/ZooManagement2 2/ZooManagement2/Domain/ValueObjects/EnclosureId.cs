using System;

namespace ZooManagement2.Domain.ValueObjects
{
    public sealed class EnclosureId
    {
        public Guid Value { get; }
        public EnclosureId(Guid value)
            => Value = value != Guid.Empty
                ? value
                : throw new ArgumentException("Id не может быть пустым");
        public static EnclosureId NewId() => new EnclosureId(Guid.NewGuid());
    }
}