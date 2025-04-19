using ZooManagement2.Application.Interfaces;

namespace ZooManagement2.Infrastructure.Events
{
    public class InMemoryEventPublisher : IEventPublisher
    {
        public void Publish<T>(T @event)
        {
        }
    }
}