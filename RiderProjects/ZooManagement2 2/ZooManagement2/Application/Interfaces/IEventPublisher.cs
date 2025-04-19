namespace ZooManagement2.Application.Interfaces
{
    public interface IEventPublisher
    {
        void Publish<T>(T @event);
    }
}